using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    public class TwoByTwo
    {
        public static bool ALLOW_CUBE_ROTATION_TRANSFORMATIONS = true;

        public static void FindSequences(TwoByTwo start, TwoByTwo finish, bool allCombinations, bool includeHalfRotations, bool countOnly, bool bidirectionalSearch, MetricType metricType, bool skipMirrors, int maxPruneCount)
        {
            TwoByTwo working = new TwoByTwo(start);
            TwoByTwo working2 = new TwoByTwo(start);

            List<Dictionary<FaceColor, FaceColor>> colorFlips = finish.GetValidColorFlips(working, working2);
            Dictionary<FaceColor, BigInteger> colorValues = GetColorValuesFromCube(start);
            List<CubeMirrorType> cubeMirrors = new List<CubeMirrorType>(start.GetMirrors(working));

            BigInteger startLowestTransformationNumber = start.GetLowestTransformationNumber(working, colorValues, colorFlips);
            BigInteger finishLowestTransformationNumber = finish.GetLowestTransformationNumber(working, colorValues, colorFlips);
            if (startLowestTransformationNumber == finishLowestTransformationNumber)
            {
                Console.Out.WriteLine("Already solved!");
            }
            else
            {
                Dictionary<BigInteger, FaceColor> reverseColorValues = GetReverseColorValues(colorValues);
                Dictionary<int, HashSet<BigInteger>>? goodSequencePositions;
                if (bidirectionalSearch)
                {
                    goodSequencePositions = DoBidirectionalSearch(startLowestTransformationNumber, finishLowestTransformationNumber, working, working2, colorValues, reverseColorValues, colorFlips, includeHalfRotations);
                }
                else
                {
                    goodSequencePositions = DoBreadthFirstSearch(startLowestTransformationNumber, finishLowestTransformationNumber, working, working2, colorValues, reverseColorValues, colorFlips, includeHalfRotations);
                }

                if (goodSequencePositions != null)
                {
                    int finishPriorityValue = 0;
                    while (goodSequencePositions.ContainsKey(finishPriorityValue + 1))
                    {
                        finishPriorityValue++;
                    }

                    BigInteger startExactValue = start.GetTransformationNumber(colorValues);

                    PositionTree pt = new PositionTree(startExactValue, startLowestTransformationNumber, null, null);
                    bool foundSequence = ProcessPositionTree(pt, 0, finishPriorityValue, goodSequencePositions, working, working2, colorValues, reverseColorValues, colorFlips, allCombinations, includeHalfRotations, 0, maxPruneCount, metricType);

                    if (!foundSequence)
                    {
                        Console.Out.WriteLine("All sequences pruned.");
                        return;
                    }

                    //obtain all the sequences
                    List<CubeSequence> cubeSequences = new List<CubeSequence>();
                    foreach (PositionTree nextLeaf in pt.EnumerateLeafNodes())
                    {
                        CubeSequence nextSequence = new CubeSequence();
                        PositionTree? nextPT = nextLeaf;
                        while (nextPT != null && nextPT.FaceRotation != null)
                        {
                            if (nextSequence.Rotations.Count == 0)
                            {
                                nextSequence.Rotations.Add(nextPT.FaceRotation);
                            }
                            else if (nextSequence.Rotations[0] == nextPT.FaceRotation && Math.Abs(nextPT.FaceRotation.Direction) == 1)
                            {
                                nextSequence.Rotations[0] = FaceRotation.GetRotationForFaceAndDirection(nextPT.FaceRotation.Face, 2);
                            }
                            else
                            {
                                nextSequence.Rotations.Insert(0, nextPT.FaceRotation);
                            }
                            nextPT = nextPT.PreviousPositionTree;
                        }
                        cubeSequences.Add(nextSequence);

                        //validate the sequence works. This is not strictly necessary, but validates the sequences chosen are valid.
                        if (!nextSequence.Validate(start, finish, working, working2, colorValues))
                        {
                            throw new InvalidOperationException("Failed to validate sequence.");
                        }
                    }
                    cubeSequences.Sort(); //sort the sequences

                    Dictionary<BigInteger, string> positionText = new Dictionary<BigInteger, string>();
                    positionText[startLowestTransformationNumber] = "0";
                    Dictionary<int, char> positionCharacters = new Dictionary<int, char>();

                    HashSet<string> sequencesSet = new HashSet<string>();
                    Dictionary<string, string> allStrings = new Dictionary<string, string>();

                    int? currentBest = null;
                    foreach (var nextCubeSequence in cubeSequences)
                    {
                        if (!countOnly)
                        {
                            int iNextSequenceMetric = GetMetric(nextCubeSequence, metricType);
                            bool newBest = false;
                            if (currentBest.HasValue)
                            {
                                if (currentBest.Value < iNextSequenceMetric)
                                {
                                    continue; //skip this sequence
                                }
                                else if (iNextSequenceMetric < currentBest.Value)
                                {
                                    newBest = true;
                                }
                            }
                            else
                            {
                                newBest = true;
                            }
                            if (newBest)
                            {
                                currentBest = iNextSequenceMetric;
                                sequencesSet.Clear();
                                allStrings.Clear();
                                positionCharacters.Clear();
                                positionText.Clear();
                                positionText[startLowestTransformationNumber] = "0";
                            }
                        }

                        //eliminate duplicate sequences if they are mirrors of an already processed sequence
                        bool found = false;
                        string baseSequence = string.Empty;
                        foreach (CubeMirrorType nextMirror in cubeMirrors)
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (var nextRotation in nextCubeSequence.Rotations)
                            {
                                sb.Append(nextRotation.GetMirrorFaceRotation(nextMirror).ToString());
                            }
                            string nextSequenceText = sb.ToString();
                            if (nextMirror == CubeMirrorType.Null)
                            {
                                baseSequence = nextSequenceText;
                                if (countOnly)
                                {
                                    break;
                                }
                            }
                            if (sequencesSet.Contains(nextSequenceText))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found || !skipMirrors)
                        {
                            if (string.IsNullOrEmpty(baseSequence)) throw new InvalidOperationException();

                            int sequenceIndex = 0;
                            List<BigInteger> positions = new List<BigInteger>();
                            working.SetFromOtherCube(start);
                            positions.Add(startLowestTransformationNumber);
                            foreach (FaceRotation fr in nextCubeSequence.Rotations)
                            {
                                sequenceIndex++;
                                working.PerformFaceRotation(fr);
                                BigInteger bestTxValue = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                                positions.Add(bestTxValue);

                                if (!positionText.ContainsKey(bestTxValue))
                                {
                                    if (positionCharacters.TryGetValue(sequenceIndex, out char charIndex))
                                    {
                                        charIndex = (char)(charIndex + 1);
                                    }
                                    else
                                    {
                                        charIndex = 'a';
                                    }
                                    positionCharacters[sequenceIndex] = charIndex;
                                    positionText[bestTxValue] = sequenceIndex.ToString() + charIndex;
                                }
                            }
                            sequencesSet.Add(baseSequence);
                            StringBuilder positionSequence = new StringBuilder();
                            foreach (BigInteger next in positions)
                            {
                                positionSequence.Append(positionText[next]);
                            }
                            allStrings[baseSequence] = positionSequence.ToString();
                        }
                    }

                    List<string> sequences = new List<string>();
                    foreach (string next in sequencesSet)
                    {
                        sequences.Add(next);
                    }
                    Console.Out.WriteLine($"Found {sequences.Count} sequences of length {finishPriorityValue}.");
                    if (countOnly)
                    {
                        Console.Out.WriteLine("Sequences omitted.");
                    }
                    else
                    {
                        foreach (string s in sequences)
                        {
                            Console.Out.WriteLine(s + " " + allStrings[s]);
                        }
                    }
                }
            }
        }

        private static int GetMetric(CubeSequence seq, MetricType metricType)
        {
            int iNextSequenceMetric = 0;
            if (metricType != MetricType.All)
            {
                int iR, iU, iL;
                Dictionary<CubeFace, int> faceCounts = new Dictionary<CubeFace, int>();
                bool treatHalvesAsTwo = metricType == MetricType.MaxRU || metricType == MetricType.MaxRUL;
                foreach (FaceRotation fr in seq.Rotations)
                {
                    if (!faceCounts.TryGetValue(fr.Face, out int currentValue))
                    {
                        currentValue = 0;
                    }
                    int increment;
                    if (treatHalvesAsTwo && fr.Direction == 2)
                    {
                        increment = 2;
                    }
                    else
                    {
                        increment = 1;
                    }
                    faceCounts[fr.Face] = currentValue + increment;
                }
                if (metricType == MetricType.MinimizeRotationsBeyondTwoFaces)
                {
                    List<int> faceCountsValues = new List<int>();
                    foreach (var next in faceCounts)
                    {
                        faceCountsValues.Add(next.Value);
                    }
                    if (faceCountsValues.Count > 2)
                    {
                        faceCountsValues.Sort();
                        faceCountsValues.Reverse();
                        for (int i = 2; i < faceCountsValues.Count; i++)
                        {
                            iNextSequenceMetric += faceCountsValues[i];
                        }
                    }
                }
                else if (metricType == MetricType.MaxRU)
                {
                    faceCounts.TryGetValue(CubeFace.Right, out iR);
                    faceCounts.TryGetValue(CubeFace.Up, out iU);
                    iNextSequenceMetric = 0 - iR - iU;
                }
                else if (metricType == MetricType.MaxRUL)
                {
                    faceCounts.TryGetValue(CubeFace.Right, out iR);
                    faceCounts.TryGetValue(CubeFace.Left, out iL);
                    faceCounts.TryGetValue(CubeFace.Up, out iU);
                    iNextSequenceMetric = 0 - iR - iU - iL;
                }
            }
            return iNextSequenceMetric;
        }

        private static Dictionary<int, HashSet<BigInteger>>? DoBidirectionalSearch(BigInteger startLowestTransformationNumber, BigInteger finishLowestTransformationNumber, TwoByTwo working, TwoByTwo working2, Dictionary<FaceColor, BigInteger> colorValues, Dictionary<BigInteger, FaceColor> reverseColorValues, List<Dictionary<FaceColor, FaceColor>> colorFlips, bool includeHalfRotations)
        {
            Dictionary<BigInteger, int> finalPositionsFromStart = new Dictionary<BigInteger, int>();
            Dictionary<BigInteger, int> currentPositionsFromStart = new Dictionary<BigInteger, int>();
            Dictionary<BigInteger, int> finalPositionsFromEnd = new Dictionary<BigInteger, int>();
            Dictionary<BigInteger, int> currentPositionsFromEnd = new Dictionary<BigInteger, int>();
            PriorityQueue<CubePriorityNode, int> pqFromStart = new PriorityQueue<CubePriorityNode, int>();
            PriorityQueue<CubePriorityNode, int> pqFromEnd = new PriorityQueue<CubePriorityNode, int>();
            pqFromStart.Enqueue(new CubePriorityNode(startLowestTransformationNumber, 0), 0);
            currentPositionsFromStart[startLowestTransformationNumber] = 0;
            pqFromEnd.Enqueue(new CubePriorityNode(finishLowestTransformationNumber, 0), 0);
            currentPositionsFromEnd[finishLowestTransformationNumber] = 0;

            bool foundPathFromStart = false;
            int? processedStartPriority = null;
            int? processedEndPriority = null;
            int nextToProcessStartPriority = 0;
            int nextToProcessEndPriority = 0;
            while (!foundPathFromStart)
            {
                int startCount = pqFromStart.Count;
                int endCount = pqFromEnd.Count;
                bool processFromStart = startCount <= endCount;
                PriorityQueue<CubePriorityNode, int> nextPQ;
                int nextToProcessPriority;
                Dictionary<BigInteger, int> nextCurrentPositions;
                Dictionary<BigInteger, int> nextFinalPositions, oppositeFinalPositions;
                string sProcessFrom;
                if (processFromStart)
                {
                    nextPQ = pqFromStart;
                    nextToProcessPriority = nextToProcessStartPriority;
                    nextCurrentPositions = currentPositionsFromStart;
                    nextFinalPositions = finalPositionsFromStart;
                    oppositeFinalPositions = finalPositionsFromEnd;
                    sProcessFrom = "start";
                }
                else
                {
                    nextPQ = pqFromEnd;
                    nextToProcessPriority = nextToProcessEndPriority;
                    nextCurrentPositions = currentPositionsFromEnd;
                    nextFinalPositions = finalPositionsFromEnd;
                    oppositeFinalPositions = finalPositionsFromStart;
                    sProcessFrom = "end";
                }
                CubePriorityNode? cpn;
                while (true)
                {
                    if (!nextPQ.TryPeek(out cpn, out int iCPNPriority))
                    {
                        return null;
                    }
                    if (iCPNPriority == nextToProcessPriority)
                    {
                        CubePriorityNode cpn2 = nextPQ.Dequeue();
                        BigInteger txNumber = cpn2.TransformationNumber;
                        working.SetFromTransformationNumber(txNumber, reverseColorValues);
                        nextFinalPositions[txNumber] = nextToProcessPriority;
                        nextCurrentPositions.Remove(txNumber);
                        if (oppositeFinalPositions.ContainsKey(txNumber))
                        {
                            foundPathFromStart = true;
                            break; //found a link from start to end, so stop processing
                        }
                        else
                        {
                            bool first = true;
                            foreach (FaceRotation nextRotationMove in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                            {
                                if (first)
                                {
                                    first = false;
                                }
                                else
                                {
                                    working.SetFromTransformationNumber(txNumber, reverseColorValues);
                                }
                                working.PerformFaceRotation(nextRotationMove);
                                ProcessNextRotation(working, working2, colorValues, nextFinalPositions, nextCurrentPositions, iCPNPriority, nextPQ, colorFlips);
                            }
                        }
                    }
                    else
                    {
                        if (processFromStart)
                        {
                            processedStartPriority = nextToProcessStartPriority;
                        }
                        else
                        {
                            processedEndPriority = nextToProcessEndPriority;
                        }
                        Console.Out.WriteLine($"Finished priority {nextToProcessPriority} from {sProcessFrom} with {nextCurrentPositions.Count} positions.");
                        if (processFromStart)
                        {
                            nextToProcessStartPriority++;
                        }
                        else
                        {
                            nextToProcessEndPriority++;
                        }
                        break;
                    }
                }
            }

            Dictionary<int, HashSet<BigInteger>>? ret = null;
            if (foundPathFromStart)
            {
                int finalStartPriority = processedStartPriority.Value;
                int finalEndPriority = processedEndPriority.Value;
                ret = new Dictionary<int, HashSet<BigInteger>>();
                ret[finalStartPriority] = new HashSet<BigInteger>();
                HashSet<BigInteger> nextPriorityPositions = ret[finalStartPriority];

                foreach (var next in finalPositionsFromStart)
                {
                    if (next.Value == finalStartPriority)
                    {
                        foreach (FaceRotation nextFaceRotation in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                        {
                            working.SetFromTransformationNumber(next.Key, reverseColorValues);
                            working.PerformFaceRotation(nextFaceRotation);
                            BigInteger nextPositionNumber = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                            if (finalPositionsFromEnd.TryGetValue(nextPositionNumber, out int foundFinalPositionNumber))
                            {
                                if (foundFinalPositionNumber == finalEndPriority & !nextPriorityPositions.Contains(next.Key))
                                {
                                    nextPriorityPositions.Add(next.Key);
                                }
                            }
                        }
                    }
                }

                for (int i = finalStartPriority - 1; i >= 0; i--)
                {
                    ret[i] = new HashSet<BigInteger>();
                    nextPriorityPositions = ret[i];
                    foreach (BigInteger nextPosition in ret[i + 1])
                    {
                        foreach (FaceRotation nextFaceRotation in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                        {
                            working.SetFromTransformationNumber(nextPosition, reverseColorValues);
                            working.PerformFaceRotation(nextFaceRotation);
                            BigInteger nextPositionNumber = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                            if (finalPositionsFromStart.TryGetValue(nextPositionNumber, out int foundFinalPositionNumber))
                            {
                                if (foundFinalPositionNumber == i & !nextPriorityPositions.Contains(nextPositionNumber))
                                {
                                    nextPriorityPositions.Add(nextPositionNumber);
                                }
                            }
                        }
                    }
                }

                int nextPositionPriority = finalStartPriority;
                for (int i = finalEndPriority; i >= 0; i--)
                {
                    nextPositionPriority++;
                    ret[nextPositionPriority] = new HashSet<BigInteger>();
                    nextPriorityPositions = ret[nextPositionPriority];
                    foreach (BigInteger nextPosition in ret[nextPositionPriority - 1])
                    {
                        foreach (FaceRotation nextFaceRotation in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                        {
                            working.SetFromTransformationNumber(nextPosition, reverseColorValues);
                            working.PerformFaceRotation(nextFaceRotation);
                            BigInteger nextPositionNumber = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                            if (finalPositionsFromEnd.TryGetValue(nextPositionNumber, out int foundFinalPositionNumber))
                            {
                                if (foundFinalPositionNumber == i & !nextPriorityPositions.Contains(nextPositionNumber))
                                {
                                    nextPriorityPositions.Add(nextPositionNumber);
                                }
                            }
                        }
                    }
                }
            }

            return ret;
        }

        private static Dictionary<int, HashSet<BigInteger>>? DoBreadthFirstSearch(BigInteger startLowestTransformationNumber, BigInteger finishLowestTransformationNumber, TwoByTwo working, TwoByTwo working2, Dictionary<FaceColor, BigInteger> colorValues, Dictionary<BigInteger, FaceColor> reverseColorValues, List<Dictionary<FaceColor, FaceColor>> colorFlips, bool includeHalfRotations)
        {
            int nextPriority = 0;
            Dictionary<BigInteger, int> finalPositions = new Dictionary<BigInteger, int>();
            Dictionary<BigInteger, int> currentPositions = new Dictionary<BigInteger, int>();
            PriorityQueue<CubePriorityNode, int> pq = new PriorityQueue<CubePriorityNode, int>();
            pq.Enqueue(new CubePriorityNode(startLowestTransformationNumber, 0), 0);
            currentPositions[startLowestTransformationNumber] = 0;
            int? finishPriority = null;
            while (pq.Count > 0)
            {
                CubePriorityNode cpn = pq.Dequeue();
                startLowestTransformationNumber = cpn.TransformationNumber;
                working.SetFromTransformationNumber(startLowestTransformationNumber, reverseColorValues);

                if (!finalPositions.ContainsKey(startLowestTransformationNumber))
                {
                    int currentPriority = cpn.Priority;

                    if (currentPriority > nextPriority)
                    {
                        Console.Out.WriteLine($"Finished priority {nextPriority} with {currentPositions.Count} positions.");
                        nextPriority = currentPriority;
                        if (finishPriority.HasValue && currentPriority > finishPriority.Value)
                        {
                            break;
                        }
                    }

                    finalPositions[startLowestTransformationNumber] = currentPriority;
                    currentPositions.Remove(startLowestTransformationNumber);

                    if (startLowestTransformationNumber == finishLowestTransformationNumber)
                    {
                        if (finishPriority.HasValue)
                        {
                            if (currentPriority != finishPriority.Value)
                            {
                                throw new InvalidOperationException();
                            }
                        }
                        else
                        {
                            finishPriority = currentPriority;
                        }
                    }
                    else //process all rotations
                    {
                        bool first = true;
                        foreach (FaceRotation nextRotationMove in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                        {
                            if (first)
                            {
                                first = false;
                            }
                            else
                            {
                                working.SetFromTransformationNumber(startLowestTransformationNumber, reverseColorValues);
                            }
                            working.PerformFaceRotation(nextRotationMove);
                            ProcessNextRotation(working, working2, colorValues, finalPositions, currentPositions, currentPriority, pq, colorFlips);
                        }
                    }
                }
            }

            Dictionary<int, HashSet<BigInteger>>? goodSequencePositions = null;
            if (finishPriority.HasValue)
            {
                int finishPriorityValue = finishPriority.Value;

                //find all positions on the optimal path between the start and finish, with a separate list for each
                //sequence number
                goodSequencePositions = new Dictionary<int, HashSet<BigInteger>>();
                goodSequencePositions[finishPriorityValue] = new HashSet<BigInteger>()
                    {
                        finishLowestTransformationNumber
                    };
                int currentlyProcessingPriorityValue = finishPriorityValue - 1;
                while (currentlyProcessingPriorityValue >= 0)
                {
                    HashSet<BigInteger> nextPriorityPositions = new HashSet<BigInteger>();
                    goodSequencePositions[currentlyProcessingPriorityValue] = nextPriorityPositions;
                    foreach (BigInteger nextPosition in goodSequencePositions[currentlyProcessingPriorityValue + 1])
                    {
                        foreach (FaceRotation nextFaceRotation in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
                        {
                            working.SetFromTransformationNumber(nextPosition, reverseColorValues);
                            working.PerformFaceRotation(nextFaceRotation);
                            BigInteger nextPositionNumber = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                            if (finalPositions.TryGetValue(nextPositionNumber, out int foundFinalPositionNumber))
                            {
                                if (foundFinalPositionNumber == currentlyProcessingPriorityValue & !nextPriorityPositions.Contains(nextPositionNumber))
                                {
                                    nextPriorityPositions.Add(nextPositionNumber);
                                }
                            }
                        }
                    }
                    currentlyProcessingPriorityValue--;
                }
            }

            return goodSequencePositions;
        }

        public IEnumerable<CubeMirrorType> GetMirrors(TwoByTwo working)
        {
            yield return CubeMirrorType.Null;
            foreach (CubeMirrorType nextMirror in Enum.GetValues(typeof(CubeMirrorType)))
            {
                if (nextMirror != CubeMirrorType.Null)
                {
                    working.SetFromOtherCube(this);
                    working.PerformMirror(nextMirror);
                    if (this.IsEqualToOtherCube(working))
                    {
                        yield return nextMirror;
                    }
                }
            }
        }

        public List<Dictionary<FaceColor, FaceColor>> GetValidColorFlips(TwoByTwo working, TwoByTwo working2)
        {
            bool hasUnknown = false;
            Dictionary<FaceColor, int> colorCounts = new Dictionary<FaceColor, int>();
            foreach (FaceColor c in Faces)
            {
                if (c == FaceColor.Unknown)
                {
                    hasUnknown = true;
                }
                else
                {
                    if (!colorCounts.TryGetValue(c, out int count))
                    {
                        count = 0;
                    }
                    count++;
                    colorCounts[c] = count;
                }
            }
            Dictionary<int, List<FaceColor>> byCount = new Dictionary<int, List<FaceColor>>();
            foreach (var next in colorCounts)
            {
                List<FaceColor> faces;
                if (!byCount.TryGetValue(next.Value, out faces))
                {
                    faces = new List<FaceColor>();
                    byCount[next.Value] = faces;
                }
                faces.Add(next.Key);
            }

            Dictionary<int, List<Dictionary<FaceColor, FaceColor>>> flipOptionsByCount = new Dictionary<int, List<Dictionary<FaceColor, FaceColor>>>();
            foreach (var nextCount in byCount)
            {
                List<Dictionary<FaceColor, FaceColor>> nextList = new List<Dictionary<FaceColor, FaceColor>>();
                foreach (var next in GetFlips(nextCount.Value, nextCount.Value, new Dictionary<FaceColor, FaceColor>()))
                {
                    nextList.Add(next);
                }
                flipOptionsByCount[nextCount.Key] = nextList;
            }

            List<Dictionary<FaceColor, FaceColor>> validColorFlips = new List<Dictionary<FaceColor, FaceColor>>();
            foreach (var nextCombination in GetCombinations(flipOptionsByCount))
            {
                bool isValidColorFlip = false;
                if (hasUnknown)
                {
                    nextCombination[FaceColor.Unknown] = FaceColor.Unknown;
                }
                working.SetFromOtherCube(this);
                working.PerformColorFlip(nextCombination);
                foreach (CubeRotation nextRotation in CubeRotation.EnumerateRotations())
                {
                    working2.SetFromOtherCube(working);
                    working2.PerformCubeRotation(nextRotation);
                    if (this.IsEqualToOtherCube(working2))
                    {
                        isValidColorFlip = true;
                        break;
                    }
                }
                if (isValidColorFlip)
                {
                    validColorFlips.Add(nextCombination);
                }
            }

            return validColorFlips;
        }

        public void PerformColorFlip(Dictionary<FaceColor, FaceColor> mapping)
        {
            for (int i = 0; i < Faces.Length; i++)
            {
                Faces[i] = mapping[Faces[i]];
            }
        }

        public IEnumerable<Dictionary<FaceColor, FaceColor>> GetCombinations(Dictionary<int, List<Dictionary<FaceColor, FaceColor>>> input)
        {
            if (input.Count == 1)
            {
                foreach (var singleEntry in input)
                {
                    foreach (var nextEntry in singleEntry.Value)
                    {
                        yield return nextEntry;
                    }
                }
            }
            else
            {
                var firstEntry = input.First();
                Dictionary<int, List<Dictionary<FaceColor, FaceColor>>> newInput = new Dictionary<int, List<Dictionary<FaceColor, FaceColor>>>();
                foreach (var next in input)
                {
                    if (next.Key != firstEntry.Key)
                    {
                        newInput[next.Key] = next.Value;
                    }
                }
                foreach (var next in GetCombinations(newInput))
                {
                    foreach (var nextEntry in firstEntry.Value)
                    {
                        Dictionary<FaceColor, FaceColor> ret = new Dictionary<FaceColor, FaceColor>();
                        foreach (var nextFaceMapping in next)
                        {
                            ret[nextFaceMapping.Key] = nextFaceMapping.Value;
                        }
                        foreach (var nextFaceMapping in nextEntry)
                        {
                            ret[nextFaceMapping.Key] = nextFaceMapping.Value;
                        }
                        yield return ret;
                    }
                }
            }
        }

        public IEnumerable<Dictionary<FaceColor, FaceColor>> GetFlips(List<FaceColor> Sources, List<FaceColor> Targets, Dictionary<FaceColor, FaceColor> ExistingMapping)
        {
            if (Sources.Count == 1)
            {
                Dictionary<FaceColor, FaceColor> newMapping = new Dictionary<FaceColor, FaceColor>();
                foreach (var next in ExistingMapping)
                {
                    newMapping[next.Key] = next.Value;
                }
                newMapping[Sources[0]] = Targets[0];
                yield return newMapping;
            }
            else
            {
                FaceColor source1 = Sources[0];
                List<FaceColor> remainingSources = new List<FaceColor>();
                foreach (FaceColor fc in Sources)
                {
                    if (fc != source1)
                    {
                        remainingSources.Add(fc);
                    }
                }
                foreach (FaceColor nextTarget in Targets)
                {
                    Dictionary<FaceColor, FaceColor> newMapping = new Dictionary<FaceColor, FaceColor>();
                    foreach (var next in ExistingMapping)
                    {
                        newMapping[next.Key] = next.Value;
                    }
                    newMapping[source1] = nextTarget;

                    List<FaceColor> newTargets = new List<FaceColor>();
                    foreach (FaceColor next in Targets)
                    {
                        if (next != nextTarget)
                        {
                            newTargets.Add(next);
                        }
                    }
                    foreach (var next in GetFlips(remainingSources, newTargets, newMapping))
                    {
                        yield return next;
                    }
                }
            }
        }

        private static bool ProcessPositionTree(PositionTree pt, int currentPriority, int finishPriority, Dictionary<int, HashSet<BigInteger>> goodSequencePositions, TwoByTwo working, TwoByTwo working2, Dictionary<FaceColor, BigInteger> colorValues, Dictionary<BigInteger, FaceColor> reverseColorValues, List<Dictionary<FaceColor, FaceColor>> colorFlips, bool allCombinations, bool includeHalfRotations, int currentPruneCount, int maxPruneCount, MetricType metricType)
        {
            List<PositionTree>? nextPositions = null;
            bool ret = false;
            HashSet<BigInteger>? foundBestPositions = allCombinations ? null : new HashSet<BigInteger>();
            foreach (FaceRotation nextRotation in FaceRotation.EnumerateFaceRotations(includeHalfRotations))
            {
                CubeFace cf = nextRotation.Face;
                bool isPruneRotation = false;
                if (metricType == MetricType.MaxRU)
                {
                    isPruneRotation = cf != CubeFace.Right && cf != CubeFace.Up;
                }
                else if (metricType == MetricType.MaxRUL)
                {
                    isPruneRotation = cf != CubeFace.Right && cf != CubeFace.Up && cf != CubeFace.Left;
                }
                int nextPruneCount = currentPruneCount;
                if (isPruneRotation)
                {
                    if (currentPruneCount == maxPruneCount) //stop processing if beyond the prune count
                    {
                        continue;
                    }
                    else
                    {
                        nextPruneCount++;
                    }
                }
                working.SetFromTransformationNumber(pt.ExactTransformationValue, reverseColorValues);
                working.PerformFaceRotation(nextRotation);
                BigInteger afterTransformationNumber = working.GetLowestTransformationNumber(working2, colorValues, colorFlips);
                if (goodSequencePositions[currentPriority + 1].Contains(afterTransformationNumber) && (foundBestPositions == null || !foundBestPositions.Contains(afterTransformationNumber)))
                {
                    BigInteger afterExactValue = working.GetTransformationNumber(colorValues);
                    if (foundBestPositions != null) foundBestPositions.Add(afterTransformationNumber);
                    PositionTree nextPT = new PositionTree(afterExactValue, afterTransformationNumber, pt, nextRotation);
                    bool nextPositionRet = false;
                    if (currentPriority + 1 < finishPriority)
                        nextPositionRet = ProcessPositionTree(nextPT, currentPriority + 1, finishPriority, goodSequencePositions, working, working2, colorValues, reverseColorValues, colorFlips, allCombinations, includeHalfRotations, nextPruneCount, maxPruneCount, metricType);
                    else
                        nextPositionRet = true;
                    if (nextPositionRet)
                    {
                        if (nextPositions == null) nextPositions = new List<PositionTree>();
                        nextPositions.Add(nextPT);
                        ret = true;
                    }
                }
            }
            if (ret)
            {
                pt.NextPositions.AddRange(nextPositions);
            }
            return ret;
        }

        public class CubeSequence : IComparable<CubeSequence>
        {
            public CubeSequence()
            {
                this.Rotations = new List<FaceRotation>();
            }
            public List<FaceRotation> Rotations { get; set; }

            public int CompareTo(CubeSequence? other)
            {
                int iRotationCountA = this.Rotations.Count;
                int iRotationCountB = other.Rotations.Count;
                for (int i = 0; i < Math.Min(iRotationCountA, iRotationCountB); i++)
                {
                    int next = Rotations[i].CompareTo(other.Rotations[i]);
                    if (next != 0) return next;
                }
                return iRotationCountA.CompareTo(iRotationCountB);
            }

            /// <summary>
            /// validates applying the sequence yields the expected result
            /// </summary>
            /// <param name="start">starting position. The state of this cube is changed to try to get to the finish state.</param>
            /// <param name="finish">finishing position</param>
            /// <returns>true if successfully validated, false otherwise</returns>
            public bool Validate(TwoByTwo start, TwoByTwo finish, TwoByTwo working, TwoByTwo working2, Dictionary<FaceColor, BigInteger> colorValues)
            {
                working.SetFromOtherCube(start);
                foreach (FaceRotation fr in Rotations)
                {
                    working.PerformFaceRotation(fr);
                }
                return working.GetLowestTransformationNumber(working2, colorValues, null) == finish.GetLowestTransformationNumber(working2, colorValues, null);
            }
        }

        private static void ProcessNextRotation(TwoByTwo rotation, TwoByTwo working, Dictionary<FaceColor, BigInteger> colorValues, Dictionary<BigInteger, int> finalPositions, Dictionary<BigInteger, int> currentPositions, int currentPriority, PriorityQueue<CubePriorityNode, int> pq, List<Dictionary<FaceColor, FaceColor>> colorFlips)
        {
            BigInteger nextTransformationNumber = rotation.GetLowestTransformationNumber(working, colorValues, colorFlips);
            if (!finalPositions.ContainsKey(nextTransformationNumber))
            {
                bool enqueue;
                if (currentPositions.TryGetValue(nextTransformationNumber, out int existingPriority))
                {
                    enqueue = currentPriority + 1 < existingPriority;
                }
                else
                {
                    enqueue = true;
                }
                if (enqueue)
                {
                    int newPriority = currentPriority + 1;
                    currentPositions[nextTransformationNumber] = newPriority;
                    CubePriorityNode cpn = new CubePriorityNode(nextTransformationNumber, newPriority);
                    pq.Enqueue(cpn, newPriority);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Faces.Length; i++)
            {
                sb.Append(GetCharForFaceColor(Faces[i]));
            }
            return sb.ToString();
        }

        public static char GetCharForFaceColor(FaceColor fc)
        {
            char cNext;
            switch (fc)
            {
                case FaceColor.Unknown:
                    cNext = '?';
                    break;
                case FaceColor.White:
                    cNext = 'W';
                    break;
                case FaceColor.Yellow:
                    cNext = 'Y';
                    break;
                case FaceColor.Blue:
                    cNext = 'B';
                    break;
                case FaceColor.Green:
                    cNext = 'G';
                    break;
                case FaceColor.Red:
                    cNext = 'R';
                    break;
                case FaceColor.Orange:
                    cNext = 'O';
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return cNext;
        }

        public IEnumerable<BigInteger> GetTransformationNumbers(TwoByTwo? working, Dictionary<FaceColor, BigInteger> Values, List<Dictionary<FaceColor, FaceColor>>? colorFlips)
        {
            if (working == null)
            {
                working = new TwoByTwo(this);
            }
            else
            {
                working.SetFromOtherCube(this);
            }

            if (colorFlips == null) //just the null color flip
            {
                foreach (BigInteger next in working.GetTransformationNumbers(Values))
                {
                    yield return next;
                }
            }
            else
            {
                foreach (var nextColorFlip in colorFlips)
                {
                    working.PerformColorFlip(nextColorFlip);
                    foreach (BigInteger next in working.GetTransformationNumbers(Values))
                    {
                        yield return next;
                    }
                }
            }
        }

        /// <summary>
        /// retrieves transformation numbers. This modifies the state of the cube.
        /// </summary>
        /// <param name="Values">color mapping</param>
        /// <returns>transformation numbers</returns>
        private IEnumerable<BigInteger> GetTransformationNumbers(Dictionary<FaceColor, BigInteger> Values)
        {
            yield return GetTransformationNumber(Values);

            if (ALLOW_CUBE_ROTATION_TRANSFORMATIONS)
            {
                CubeFaceRotation rightAntiClockwise = CubeFaceRotation.GetRotationForAxisAndDirection(CubeAxis.Right, -1);
                CubeFaceRotation frontClockwise = CubeFaceRotation.GetRotationForAxisAndDirection(CubeAxis.Front, 1);
                CubeFaceRotation frontAntiClockwise = CubeFaceRotation.GetRotationForAxisAndDirection(CubeAxis.Front, -1);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(frontAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(frontAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(frontClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(frontClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(frontAntiClockwise);
                yield return GetTransformationNumber(Values);

                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
                PerformCubeFaceRotation(rightAntiClockwise);
                yield return GetTransformationNumber(Values);
            }
        }

        public BigInteger GetLowestTransformationNumber(TwoByTwo? working, Dictionary<FaceColor, BigInteger> Values, List<Dictionary<FaceColor, FaceColor>>? colorFlips)
        {
            bool found = false;
            BigInteger transformationNumber = 0;
            foreach (BigInteger next in GetTransformationNumbers(working, Values, colorFlips))
            {
                if (found)
                {
                    if (transformationNumber < next)
                    {
                        transformationNumber = next;
                    }
                }
                else
                {
                    transformationNumber = next;
                    found = true;
                }
            }
            return transformationNumber;
        }

        public void SetFromTransformationNumber(BigInteger transformationNumber, Dictionary<BigInteger, FaceColor> Values)
        {
            BigInteger numberOfValues = Values.Count;
            for (int i = 0; i < Faces.Length; i++)
            {
                BigInteger newValue = transformationNumber % numberOfValues;
                Faces[i] = Values[newValue];
                transformationNumber = (transformationNumber - newValue) / numberOfValues;
            }
        }

        public BigInteger GetTransformationNumber(Dictionary<FaceColor, BigInteger> Values)
        {
            BigInteger number = 0;
            BigInteger baseNumber = 1;
            int numberOfValues = Values.Count;
            for (int i = 0; i < Faces.Length; i++)
            {
                if (i != 0)
                {
                    baseNumber *= numberOfValues;
                }
                number += (baseNumber * Values[Faces[i]]);
                if (number < 0)
                {
                    System.Diagnostics.Trace.WriteLine("confused");
                }
            }
            return number;
        }

        public TwoByTwo(StandardPatterns standardPattern)
        {
            SetFromStandardPattern(standardPattern);
        }

        private void SetOrtegaBottom()
        {
            Faces[(int)TwoByTwoFace.DLFDown] = FaceColor.White;
            Faces[(int)TwoByTwoFace.DRFDown] = FaceColor.White;
            Faces[(int)TwoByTwoFace.DLBDown] = FaceColor.White;
            Faces[(int)TwoByTwoFace.DRBDown] = FaceColor.White;
        }

        public void SetBottomSolved()
        {
            SetOrtegaBottom();
            Faces[(int)TwoByTwoFace.DLFFront] = FaceColor.Green;
            Faces[(int)TwoByTwoFace.DRFFront] = FaceColor.Green;
            Faces[(int)TwoByTwoFace.DLFLeft] = FaceColor.Red;
            Faces[(int)TwoByTwoFace.DLBLeft] = FaceColor.Red;
            Faces[(int)TwoByTwoFace.DRFRight] = FaceColor.Orange;
            Faces[(int)TwoByTwoFace.DRBRight] = FaceColor.Orange;
            Faces[(int)TwoByTwoFace.DLBBack] = FaceColor.Blue;
            Faces[(int)TwoByTwoFace.DRBBack] = FaceColor.Blue;
        }

        public TwoByTwo(TwoByTwo copied)
        {
            SetFromOtherCube(copied);
        }

        public void SetFromOtherCube(TwoByTwo copied)
        {
            for (int i = 0; i < Faces.Length; i++) Faces[i] = copied.Faces[i];
        }

        public void SetFromStandardPattern(StandardPatterns standardPattern)
        {
            for (int i = 0; i < Faces.Length; i++) Faces[i] = FaceColor.Unknown;
            if (standardPattern == StandardPatterns.Solved)
            {
                Faces[(int)TwoByTwoFace.ULFUp] = FaceColor.White;
                Faces[(int)TwoByTwoFace.URFUp] = FaceColor.White;
                Faces[(int)TwoByTwoFace.ULBUp] = FaceColor.White;
                Faces[(int)TwoByTwoFace.URBUp] = FaceColor.White;
                Faces[(int)TwoByTwoFace.DLFDown] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.DRFDown] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.DLBDown] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.DRBDown] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULFFront] = FaceColor.Green;
                Faces[(int)TwoByTwoFace.URFFront] = FaceColor.Green;
                Faces[(int)TwoByTwoFace.DLFFront] = FaceColor.Green;
                Faces[(int)TwoByTwoFace.DRFFront] = FaceColor.Green;
                Faces[(int)TwoByTwoFace.ULBBack] = FaceColor.Blue;
                Faces[(int)TwoByTwoFace.URBBack] = FaceColor.Blue;
                Faces[(int)TwoByTwoFace.DLBBack] = FaceColor.Blue;
                Faces[(int)TwoByTwoFace.DRBBack] = FaceColor.Blue;
                Faces[(int)TwoByTwoFace.ULFLeft] = FaceColor.Orange;
                Faces[(int)TwoByTwoFace.ULBLeft] = FaceColor.Orange;
                Faces[(int)TwoByTwoFace.DLFLeft] = FaceColor.Orange;
                Faces[(int)TwoByTwoFace.DLBLeft] = FaceColor.Orange;
                Faces[(int)TwoByTwoFace.URFRight] = FaceColor.Red;
                Faces[(int)TwoByTwoFace.URBRight] = FaceColor.Red;
                Faces[(int)TwoByTwoFace.DRFRight] = FaceColor.Red;
                Faces[(int)TwoByTwoFace.DRBRight] = FaceColor.Red;
            }
            else if (standardPattern == StandardPatterns.Unknown)
            {
                //do nothing
            }
            else if (standardPattern == StandardPatterns.Fish)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFRight] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBBack] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.Antifish)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFLeft] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBBack] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBUp] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.Turtle)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBBack] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBBack] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.SumoWrestler)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFLeft] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBLeft] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBBack] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.Headlights)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFLeft] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBLeft] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBUp] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.Chameleon)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBBack] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBUp] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.Arrow)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFFront] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBRight] = FaceColor.Yellow;
            }
            else if (standardPattern == StandardPatterns.UpComplete)
            {
                SetOrtegaBottom();
                Faces[(int)TwoByTwoFace.ULFUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URFUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.ULBUp] = FaceColor.Yellow;
                Faces[(int)TwoByTwoFace.URBUp] = FaceColor.Yellow;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool IsEqualToOtherCube(TwoByTwo compare)
        {
            bool equal = true;
            for (int i = 0; i < Faces.Length; i++)
            {
                if (Faces[i] != compare.Faces[i])
                {
                    equal = false;
                    break;
                }
            }
            return equal;
        }

        public FaceColor[] Faces = new FaceColor[24];

        public void PerformCubeTransformation(CubeTransformation crt)
        {
            PerformColorFlip(crt.ColorFlip);
            PerformCubeRotation(crt.Rotation);
        }

        public void PerformCubeRotation(CubeRotation cr)
        {
            foreach (var nextRotation in cr.FaceRotations)
            {
                PerformCubeFaceRotation(nextRotation);
            }
        }

        public void PerformCubeFaceRotation(CubeFaceRotation rotation)
        {
            if (rotation.Direction == 2)
            {
                CubeFaceRotation clockwise = CubeFaceRotation.GetRotationForAxisAndDirection(rotation.Axis, 1);
                PerformCubeFaceRotation(clockwise);
                PerformCubeFaceRotation(clockwise);
            }
            else
            {
                bool isclockwise = rotation.Direction == 1;
                switch (rotation.Axis)
                {
                    case CubeAxis.Front:
                        if (isclockwise)
                        {
                            PerformFaceRotation(FaceRotation.FRONT_CLOCKWISE);
                            PerformFaceRotation(FaceRotation.BACK_ANTICLOCKWISE);
                        }
                        else
                        {
                            PerformFaceRotation(FaceRotation.FRONT_ANTICLOCKWISE);
                            PerformFaceRotation(FaceRotation.BACK_CLOCKWISE);
                        }
                        break;
                    case CubeAxis.Right:
                        if (isclockwise)
                        {
                            PerformFaceRotation(FaceRotation.LEFT_ANTICLOCKWISE);
                            PerformFaceRotation(FaceRotation.RIGHT_CLOCKWISE);
                        }
                        else //anticlockwise
                        {
                            PerformFaceRotation(FaceRotation.LEFT_CLOCKWISE);
                            PerformFaceRotation(FaceRotation.RIGHT_ANTICLOCKWISE);
                        }
                        break;
                    case CubeAxis.Up:
                        if (isclockwise)
                        {
                            PerformFaceRotation(FaceRotation.UP_CLOCKWISE);
                            PerformFaceRotation(FaceRotation.DOWN_ANTICLOCKWISE);
                        }
                        else
                        {
                            PerformFaceRotation(FaceRotation.UP_ANTICLOCKWISE);
                            PerformFaceRotation(FaceRotation.DOWN_CLOCKWISE);
                        }
                        break;
                }
            }
        }

        public void PerformFaceRotation(FaceRotation move)
        {
            if (move.Direction == 2)
            {
                FaceRotation clockwiseMove = FaceRotation.GetRotationForFaceAndDirection(move.Face, 1);
                PerformFaceRotation(clockwiseMove);
                PerformFaceRotation(clockwiseMove);
            }
            else
            {
                int[] cycle1 = new int[4];
                int[] cycle2 = new int[4];
                int[] cycle3 = new int[4];

                SetRotationCycle(move.Face, cycle1, cycle2, cycle3);

                if (move.Direction == -1)
                {
                    int temp;
                    temp = cycle1[0];
                    cycle1[0] = cycle1[3];
                    cycle1[3] = temp;
                    temp = cycle1[1];
                    cycle1[1] = cycle1[2];
                    cycle1[2] = temp;
                    temp = cycle2[0];
                    cycle2[0] = cycle2[3];
                    cycle2[3] = temp;
                    temp = cycle2[1];
                    cycle2[1] = cycle2[2];
                    cycle2[2] = temp;
                    temp = cycle3[0];
                    cycle3[0] = cycle3[3];
                    cycle3[3] = temp;
                    temp = cycle3[1];
                    cycle3[1] = cycle3[2];
                    cycle3[2] = temp;
                }

                PerformCycle(cycle1);
                PerformCycle(cycle2);
                PerformCycle(cycle3);
            }
        }

        private void PerformCycle(int[] indexes)
        {
            FaceColor saved;
            saved = Faces[indexes[0]];
            for (int i = 0; i < indexes.Length - 1; i++)
            {
                Faces[indexes[i]] = Faces[indexes[i + 1]];
            }
            Faces[indexes[indexes.Length - 1]] = saved;
        }

        public void PerformMirror(CubeMirrorType mirrorType)
        {
            if (mirrorType != CubeMirrorType.Null)
            {
                int[] cycle = new int[2];
                if (mirrorType == CubeMirrorType.X)
                {
                    cycle[0] = (int)TwoByTwoFace.ULFUp;
                    cycle[1] = (int)TwoByTwoFace.URFUp;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFFront;
                    cycle[1] = (int)TwoByTwoFace.URFFront;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFLeft;
                    cycle[1] = (int)TwoByTwoFace.URFRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBUp;
                    cycle[1] = (int)TwoByTwoFace.URBUp;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBBack;
                    cycle[1] = (int)TwoByTwoFace.URBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBLeft;
                    cycle[1] = (int)TwoByTwoFace.URBRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFDown;
                    cycle[1] = (int)TwoByTwoFace.DRFDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFFront;
                    cycle[1] = (int)TwoByTwoFace.DRFFront;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFLeft;
                    cycle[1] = (int)TwoByTwoFace.DRFRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLBDown;
                    cycle[1] = (int)TwoByTwoFace.DRBDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLBBack;
                    cycle[1] = (int)TwoByTwoFace.DRBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLBLeft;
                    cycle[1] = (int)TwoByTwoFace.DRBRight;
                    PerformCycle(cycle);
                }
                else if (mirrorType == CubeMirrorType.Y)
                {
                    cycle[0] = (int)TwoByTwoFace.ULFFront;
                    cycle[1] = (int)TwoByTwoFace.DLFFront;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFLeft;
                    cycle[1] = (int)TwoByTwoFace.DLFLeft;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFUp;
                    cycle[1] = (int)TwoByTwoFace.DLFDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFFront;
                    cycle[1] = (int)TwoByTwoFace.DRFFront;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFRight;
                    cycle[1] = (int)TwoByTwoFace.DRFRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFUp;
                    cycle[1] = (int)TwoByTwoFace.DRFDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBBack;
                    cycle[1] = (int)TwoByTwoFace.DLBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBLeft;
                    cycle[1] = (int)TwoByTwoFace.DLBLeft;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULBUp;
                    cycle[1] = (int)TwoByTwoFace.DLBDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URBBack;
                    cycle[1] = (int)TwoByTwoFace.DRBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URBRight;
                    cycle[1] = (int)TwoByTwoFace.DRBRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URBUp;
                    cycle[1] = (int)TwoByTwoFace.DRBDown;
                    PerformCycle(cycle);
                }
                else if (mirrorType == CubeMirrorType.Z)
                {
                    cycle[0] = (int)TwoByTwoFace.ULFUp;
                    cycle[1] = (int)TwoByTwoFace.ULBUp;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFLeft;
                    cycle[1] = (int)TwoByTwoFace.ULBLeft;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.ULFFront;
                    cycle[1] = (int)TwoByTwoFace.ULBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFUp;
                    cycle[1] = (int)TwoByTwoFace.URBUp;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFRight;
                    cycle[1] = (int)TwoByTwoFace.URBRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.URFFront;
                    cycle[1] = (int)TwoByTwoFace.URBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFDown;
                    cycle[1] = (int)TwoByTwoFace.DLBDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFLeft;
                    cycle[1] = (int)TwoByTwoFace.DLBLeft;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DLFFront;
                    cycle[1] = (int)TwoByTwoFace.DLBBack;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DRFDown;
                    cycle[1] = (int)TwoByTwoFace.DRBDown;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DRFRight;
                    cycle[1] = (int)TwoByTwoFace.DRBRight;
                    PerformCycle(cycle);
                    cycle[0] = (int)TwoByTwoFace.DRFFront;
                    cycle[1] = (int)TwoByTwoFace.DRBBack;
                    PerformCycle(cycle);
                }
                else if (mirrorType == CubeMirrorType.XY)
                {
                    PerformMirror(CubeMirrorType.X);
                    PerformMirror(CubeMirrorType.Y);
                }
                else if (mirrorType == CubeMirrorType.XZ)
                {
                    PerformMirror(CubeMirrorType.X);
                    PerformMirror(CubeMirrorType.Z);
                }
                else if (mirrorType == CubeMirrorType.YZ)
                {
                    PerformMirror(CubeMirrorType.Y);
                    PerformMirror(CubeMirrorType.Z);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public static TwoByTwoCorner GetCornerForFace(TwoByTwoFace face)
        {
            TwoByTwoCorner ret;
            switch (face)
            {
                case TwoByTwoFace.DLBBack:
                case TwoByTwoFace.DLBDown:
                case TwoByTwoFace.DLBLeft:
                    ret = TwoByTwoCorner.DLB;
                    break;
                case TwoByTwoFace.DLFDown:
                case TwoByTwoFace.DLFFront:
                case TwoByTwoFace.DLFLeft:
                    ret = TwoByTwoCorner.DLF;
                    break;
                case TwoByTwoFace.DRBBack:
                case TwoByTwoFace.DRBDown:
                case TwoByTwoFace.DRBRight:
                    ret = TwoByTwoCorner.DRB;
                    break;
                case TwoByTwoFace.DRFDown:
                case TwoByTwoFace.DRFFront:
                case TwoByTwoFace.DRFRight:
                    ret = TwoByTwoCorner.DRF;
                    break;
                case TwoByTwoFace.ULBBack:
                case TwoByTwoFace.ULBLeft:
                case TwoByTwoFace.ULBUp:
                    ret = TwoByTwoCorner.ULB;
                    break;
                case TwoByTwoFace.ULFFront:
                case TwoByTwoFace.ULFLeft:
                case TwoByTwoFace.ULFUp:
                    ret = TwoByTwoCorner.ULF;
                    break;
                case TwoByTwoFace.URBBack:
                case TwoByTwoFace.URBRight:
                case TwoByTwoFace.URBUp:
                    ret = TwoByTwoCorner.URB;
                    break;
                case TwoByTwoFace.URFFront:
                case TwoByTwoFace.URFRight:
                case TwoByTwoFace.URFUp:
                    ret = TwoByTwoCorner.URF;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return ret;
        }

        public static Dictionary<BigInteger, FaceColor> GetReverseColorValues(Dictionary<FaceColor, BigInteger> colorValues)
        {
            Dictionary<BigInteger, FaceColor> ret = new Dictionary<BigInteger, FaceColor>();
            foreach (var next in colorValues)
            {
                ret[next.Value] = next.Key;
            }
            return ret;
        }

        public static Dictionary<FaceColor, BigInteger> GetColorValuesFromCube(TwoByTwo cube)
        {
            Dictionary<FaceColor, BigInteger> colorValues = new Dictionary<FaceColor, BigInteger>();
            int count = 0;
            foreach (FaceColor fc in cube.Faces)
            {
                if (!colorValues.ContainsKey(fc))
                {
                    colorValues[fc] = count++;
                }
            }
            return colorValues;
        }

        public static void SetRotationCycle(CubeFace face, int[] cycle1, int[] cycle2, int[] cycle3)
        {
            if (face == CubeFace.Up)
            {
                cycle1[3] = (int)TwoByTwoFace.ULBLeft;
                cycle1[2] = (int)TwoByTwoFace.URBBack;
                cycle1[1] = (int)TwoByTwoFace.URFRight;
                cycle1[0] = (int)TwoByTwoFace.ULFFront;
                cycle2[3] = (int)TwoByTwoFace.ULBBack;
                cycle2[2] = (int)TwoByTwoFace.URBRight;
                cycle2[1] = (int)TwoByTwoFace.URFFront;
                cycle2[0] = (int)TwoByTwoFace.ULFLeft;
                cycle3[3] = (int)TwoByTwoFace.ULBUp;
                cycle3[2] = (int)TwoByTwoFace.URBUp;
                cycle3[1] = (int)TwoByTwoFace.URFUp;
                cycle3[0] = (int)TwoByTwoFace.ULFUp;
            }
            else if (face == CubeFace.Down)
            {
                cycle1[3] = (int)TwoByTwoFace.DLBLeft;
                cycle1[2] = (int)TwoByTwoFace.DLFFront;
                cycle1[1] = (int)TwoByTwoFace.DRFRight;
                cycle1[0] = (int)TwoByTwoFace.DRBBack;
                cycle2[3] = (int)TwoByTwoFace.DLBBack;
                cycle2[2] = (int)TwoByTwoFace.DLFLeft;
                cycle2[1] = (int)TwoByTwoFace.DRFFront;
                cycle2[0] = (int)TwoByTwoFace.DRBRight;
                cycle3[3] = (int)TwoByTwoFace.DLBDown;
                cycle3[2] = (int)TwoByTwoFace.DLFDown;
                cycle3[1] = (int)TwoByTwoFace.DRFDown;
                cycle3[0] = (int)TwoByTwoFace.DRBDown;
            }
            else if (face == CubeFace.Left)
            {
                cycle1[3] = (int)TwoByTwoFace.ULBUp;
                cycle1[2] = (int)TwoByTwoFace.ULFFront;
                cycle1[1] = (int)TwoByTwoFace.DLFDown;
                cycle1[0] = (int)TwoByTwoFace.DLBBack;
                cycle2[3] = (int)TwoByTwoFace.ULBBack;
                cycle2[2] = (int)TwoByTwoFace.ULFUp;
                cycle2[1] = (int)TwoByTwoFace.DLFFront;
                cycle2[0] = (int)TwoByTwoFace.DLBDown;
                cycle3[3] = (int)TwoByTwoFace.ULBLeft;
                cycle3[2] = (int)TwoByTwoFace.ULFLeft;
                cycle3[1] = (int)TwoByTwoFace.DLFLeft;
                cycle3[0] = (int)TwoByTwoFace.DLBLeft;
            }
            else if (face == CubeFace.Right)
            {
                cycle1[3] = (int)TwoByTwoFace.URBUp;
                cycle1[2] = (int)TwoByTwoFace.DRBBack;
                cycle1[1] = (int)TwoByTwoFace.DRFDown;
                cycle1[0] = (int)TwoByTwoFace.URFFront;
                cycle2[3] = (int)TwoByTwoFace.URBBack;
                cycle2[2] = (int)TwoByTwoFace.DRBDown;
                cycle2[1] = (int)TwoByTwoFace.DRFFront;
                cycle2[0] = (int)TwoByTwoFace.URFUp;
                cycle3[3] = (int)TwoByTwoFace.URBRight;
                cycle3[2] = (int)TwoByTwoFace.DRBRight;
                cycle3[1] = (int)TwoByTwoFace.DRFRight;
                cycle3[0] = (int)TwoByTwoFace.URFRight;
            }
            else if (face == CubeFace.Front)
            {
                cycle1[3] = (int)TwoByTwoFace.ULFUp;
                cycle1[2] = (int)TwoByTwoFace.URFRight;
                cycle1[1] = (int)TwoByTwoFace.DRFDown;
                cycle1[0] = (int)TwoByTwoFace.DLFLeft;
                cycle2[3] = (int)TwoByTwoFace.ULFLeft;
                cycle2[2] = (int)TwoByTwoFace.URFUp;
                cycle2[1] = (int)TwoByTwoFace.DRFRight;
                cycle2[0] = (int)TwoByTwoFace.DLFDown;
                cycle3[3] = (int)TwoByTwoFace.ULFFront;
                cycle3[2] = (int)TwoByTwoFace.URFFront;
                cycle3[1] = (int)TwoByTwoFace.DRFFront;
                cycle3[0] = (int)TwoByTwoFace.DLFFront;
            }
            else if (face == CubeFace.Back)
            {
                cycle1[3] = (int)TwoByTwoFace.ULBUp;
                cycle1[2] = (int)TwoByTwoFace.DLBLeft;
                cycle1[1] = (int)TwoByTwoFace.DRBDown;
                cycle1[0] = (int)TwoByTwoFace.URBRight;
                cycle2[3] = (int)TwoByTwoFace.ULBLeft;
                cycle2[2] = (int)TwoByTwoFace.DLBDown;
                cycle2[1] = (int)TwoByTwoFace.DRBRight;
                cycle2[0] = (int)TwoByTwoFace.URBUp;
                cycle3[3] = (int)TwoByTwoFace.ULBBack;
                cycle3[2] = (int)TwoByTwoFace.DLBBack;
                cycle3[1] = (int)TwoByTwoFace.DRBBack;
                cycle3[0] = (int)TwoByTwoFace.URBBack;
            }
        }
    }
}
