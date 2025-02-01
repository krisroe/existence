using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    /*
    internal class Program
    {
        static void Main()
        {
            MetricType mt = MetricType.MaxRUL;
            bool skipMirrors = false;
            bool bidirectionalSearch = true;
            int maxPruneCount = int.MaxValue;
            List<StandardPatterns> patternsToCheck = GetStandardPatternsToCheck();
            bool first = true;
            foreach (StandardPatterns nextPattern in patternsToCheck)
            {
                if (first)
                    first = false;
                else
                    Console.Out.WriteLine();
                Console.Out.WriteLine($"-----------Processing {nextPattern} Regular----------");
                GetSolutions(nextPattern, true, true, true);
                GetSolutions(nextPattern, true, false, true);
                GetBestSolutions(nextPattern, true, true, bidirectionalSearch, mt, skipMirrors, maxPruneCount);
                GetBestSolutions(nextPattern, true, false, bidirectionalSearch, mt, skipMirrors, maxPruneCount);
                Console.Out.WriteLine();
                Console.Out.WriteLine($"-----------Processing {nextPattern} Ortega----------");
                GetSolutions(nextPattern, false, true, true);
                GetSolutions(nextPattern, false, false, true);
                GetBestSolutions(nextPattern, false, true, bidirectionalSearch, mt, skipMirrors, maxPruneCount);
                GetBestSolutions(nextPattern, false, false, bidirectionalSearch, mt, skipMirrors, maxPruneCount);
            }
            Console.Out.WriteLine("Done!");
            Console.ReadKey();
        }

        private static List<StandardPatterns> GetStandardPatternsToCheck()
        {
            return new List<StandardPatterns>()
            {
                StandardPatterns.Fish,
                StandardPatterns.Turtle,
                StandardPatterns.SumoWrestler,
                StandardPatterns.Headlights,
                StandardPatterns.Chameleon,
                StandardPatterns.Arrow,
            };
        }

        static void GetBestSolutions(StandardPatterns topPattern, bool bottomSolved, bool countOnly, bool bidirectionalSearch, MetricType metricType, bool skipMirrors, int maxPruneCount)
        {
            TwoByTwo start = new TwoByTwo(topPattern);
            TwoByTwo finish = new TwoByTwo(StandardPatterns.UpComplete);
            if (bottomSolved)
            {
                start.SetBottomSolved();
                finish.SetBottomSolved();
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine($"Bottom solved={bottomSolved} countOnly={countOnly}");
            TwoByTwo.FindSequences(start, finish, true, false, countOnly, bidirectionalSearch, metricType, skipMirrors, maxPruneCount);
        }

        static void GetSolutions(StandardPatterns topPattern, bool bottomSolved, bool includeHalfRotations, bool bidirectionalSearch)
        {
            TwoByTwo start = new TwoByTwo(topPattern);
            TwoByTwo finish = new TwoByTwo(StandardPatterns.UpComplete);
            if (bottomSolved)
            {
                start.SetBottomSolved();
                finish.SetBottomSolved();
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine($"Bottom solved={bottomSolved} includeHalf={includeHalfRotations}");
            TwoByTwo.FindSequences(start, finish, false, includeHalfRotations, true, bidirectionalSearch, MetricType.MinimizeRotationsBeyondTwoFaces, true, 0);
        }
    }*/
    /*
    [TestClass]
    public class TwoByTwoTests
    {
        [TestMethod]
        public void TestRotations()
        {
            TwoByTwo cube = new TwoByTwo(StandardPatterns.Solved);
            TwoByTwo working = new TwoByTwo(cube);
            TwoByTwo working2 = new TwoByTwo(cube);
            foreach (CubeFace face in Enum.GetValues(typeof(CubeFace)))
            {
                FaceRotation clockwise = FaceRotation.GetRotationForFaceAndDirection(face, 1);
                FaceRotation anticlockwise = FaceRotation.GetRotationForFaceAndDirection(face, -1);
                FaceRotation half = FaceRotation.GetRotationForFaceAndDirection(face, 2);

                working.SetFromOtherCube(cube);
                working.PerformFaceRotation(clockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(clockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(clockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(clockwise);
                Assert.IsTrue(cube.IsEqualToOtherCube(working));

                working.SetFromOtherCube(cube);
                working.PerformFaceRotation(anticlockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(anticlockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(anticlockwise);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(anticlockwise);
                Assert.IsTrue(cube.IsEqualToOtherCube(working));

                working.SetFromOtherCube(cube);
                working.PerformFaceRotation(half);
                Assert.IsFalse(cube.IsEqualToOtherCube(working));
                working.PerformFaceRotation(half);
                Assert.IsTrue(cube.IsEqualToOtherCube(working));

                working.SetFromOtherCube(cube);
                working2.SetFromOtherCube(cube);
                working.PerformFaceRotation(clockwise);
                working2.PerformFaceRotation(anticlockwise);
                working2.PerformFaceRotation(anticlockwise);
                working2.PerformFaceRotation(anticlockwise);
                Assert.IsTrue(working.IsEqualToOtherCube(working2));

                working.SetFromOtherCube(cube);
                working2.SetFromOtherCube(cube);
                working.PerformFaceRotation(anticlockwise);
                working2.PerformFaceRotation(clockwise);
                working2.PerformFaceRotation(clockwise);
                working2.PerformFaceRotation(clockwise);
                Assert.IsTrue(working.IsEqualToOtherCube(working2));
            }
        }

        /// <summary>
        /// validate there are no duplicates in the rotation cycles
        /// </summary>
        [TestMethod]
        public void TestRotationCycles()
        {
            int[] cycle1 = new int[4];
            int[] cycle2 = new int[4];
            int[] cycle3 = new int[4];
            Dictionary<TwoByTwoCorner, int> cornerCounts = new Dictionary<TwoByTwoCorner, int>();
            Dictionary<TwoByTwoCorner, int> globalCornerCounts = new Dictionary<TwoByTwoCorner, int>();

            foreach (TwoByTwoCorner nextCorner in Enum.GetValues(typeof(TwoByTwoCorner)))
            {
                globalCornerCounts[nextCorner] = 0;
            }

            foreach (CubeFace face in Enum.GetValues(typeof(CubeFace)))
            {
                foreach (TwoByTwoCorner nextCorner in Enum.GetValues(typeof(TwoByTwoCorner)))
                {
                    cornerCounts[nextCorner] = 0;
                }

                HashSet<int> indexes = new HashSet<int>();
                TwoByTwo.SetRotationCycle(face, cycle1, cycle2, cycle3);
                foreach (int i in cycle1)
                {
                    if (indexes.Contains(i)) Assert.Fail();
                    indexes.Add(i);
                    TwoByTwoCorner corner = TwoByTwo.GetCornerForFace((TwoByTwoFace)i);
                    cornerCounts[corner]++;
                    globalCornerCounts[corner]++;
                }
                foreach (int i in cycle2)
                {
                    if (indexes.Contains(i)) Assert.Fail();
                    indexes.Add(i);
                    TwoByTwoCorner corner = TwoByTwo.GetCornerForFace((TwoByTwoFace)i);
                    cornerCounts[corner]++;
                    globalCornerCounts[corner]++;
                }
                foreach (int i in cycle3)
                {
                    if (indexes.Contains(i))
                    {
                        Assert.Fail();
                    }
                    indexes.Add(i);
                    TwoByTwoCorner corner = TwoByTwo.GetCornerForFace((TwoByTwoFace)i);
                    cornerCounts[corner]++;
                    globalCornerCounts[corner]++;
                }

                foreach (TwoByTwoCorner nextCorner in Enum.GetValues(typeof(TwoByTwoCorner)))
                {
                    int iCount = cornerCounts[nextCorner];
                    Assert.IsTrue(iCount == 0 || iCount == 3);
                }
            }

            foreach (TwoByTwoCorner nextCorner in Enum.GetValues(typeof(TwoByTwoCorner)))
            {
                Assert.AreEqual(globalCornerCounts[nextCorner], 9);
            }
        }

        [TestMethod]
        public void TestTransformationNumbers()
        {
            TwoByTwo working = new TwoByTwo(StandardPatterns.Unknown);
            TwoByTwo working2 = new TwoByTwo(StandardPatterns.Unknown);

            TwoByTwo baseCube = new TwoByTwo(StandardPatterns.Solved);
            Dictionary<FaceColor, BigInteger> colorValues = TwoByTwo.GetColorValuesFromCube(baseCube);
            List<Dictionary<FaceColor, FaceColor>> colorFlips = baseCube.GetValidColorFlips(working, working2);

            HashSet<BigInteger> transformationNumbers = new HashSet<BigInteger>();
            foreach (BigInteger next in baseCube.GetTransformationNumbers(working, colorValues, colorFlips))
            {
                if (!transformationNumbers.Contains(next))
                {
                    transformationNumbers.Add(next);
                }
            }
            Assert.AreEqual(transformationNumbers.Count, 24);
        }

        [TestMethod]
        public void TestTransformationRoundTrip()
        {
            TwoByTwo working = new TwoByTwo(StandardPatterns.Unknown);
            TwoByTwo working2 = new TwoByTwo(StandardPatterns.Unknown);

            TwoByTwo baseCube = new TwoByTwo(StandardPatterns.Solved);
            Dictionary<FaceColor, BigInteger> colorValues = TwoByTwo.GetColorValuesFromCube(baseCube);
            Dictionary<BigInteger, FaceColor> reverseColorValues = TwoByTwo.GetReverseColorValues(colorValues);
            List<Dictionary<FaceColor, FaceColor>> colorFlips = baseCube.GetValidColorFlips(working, working2);

            BigInteger transformationNumber = baseCube.GetLowestTransformationNumber(working, colorValues, colorFlips);
            working.SetFromStandardPattern(StandardPatterns.Unknown);
            working.SetFromTransformationNumber(transformationNumber, reverseColorValues);
            Assert.AreEqual(transformationNumber, working.GetLowestTransformationNumber(null, colorValues, colorFlips));

            transformationNumber = baseCube.GetTransformationNumber(colorValues);
            working.SetFromTransformationNumber(transformationNumber, reverseColorValues);
            Assert.AreEqual(transformationNumber, working.GetTransformationNumber(colorValues));
        }

        [TestMethod]
        public void ValidateCubeRotationTransformations()
        {
            HashSet<BigInteger> transformations1 = GetTransformationsForCubeRotationTransformations();
            HashSet<BigInteger> transformations2 = GetTransformationNumbersQuickly();
            Assert.AreEqual(transformations1.Count, transformations2.Count);
            foreach (BigInteger next in transformations1)
            {
                Assert.IsTrue(transformations2.Contains(next));
            }
        }

        [TestMethod]
        public void ValidateMirrors()
        {
            TwoByTwo solved = new TwoByTwo(StandardPatterns.Solved);
            TwoByTwo cube = new TwoByTwo(StandardPatterns.Unknown);
            HashSet<string> mirrorStrings = new HashSet<string>();
            foreach (CubeMirrorType mirror in Enum.GetValues(typeof(CubeMirrorType)))
            {
                cube.SetFromOtherCube(solved);
                cube.PerformMirror(mirror);
                string sCube = cube.ToString();
                Assert.IsFalse(mirrorStrings.Contains(sCube));
                mirrorStrings.Add(sCube);
                cube.PerformMirror(mirror);
                Assert.IsTrue(cube.IsEqualToOtherCube(solved));
            }
        }

        [TestMethod]
        public void ValidateMirrorRotations()
        {
            TwoByTwo c1 = new TwoByTwo(StandardPatterns.Unknown);
            TwoByTwo c2 = new TwoByTwo(StandardPatterns.Unknown);
            foreach (FaceRotation fr in FaceRotation.EnumerateFaceRotations(true))
            {
                foreach (CubeMirrorType mirror in Enum.GetValues(typeof(CubeMirrorType)))
                {
                    c1.SetFromStandardPattern(StandardPatterns.Solved);
                    c1.PerformFaceRotation(fr);
                    c2.SetFromStandardPattern(StandardPatterns.Solved);
                    c2.PerformMirror(mirror);
                    c2.PerformFaceRotation(fr.GetMirrorFaceRotation(mirror));
                    c2.PerformMirror(mirror);
                    Assert.IsTrue(c1.IsEqualToOtherCube(c2));
                }

            }
        }

        private HashSet<BigInteger> GetTransformationNumbersQuickly()
        {
            TwoByTwo working = new TwoByTwo(StandardPatterns.Unknown);
            TwoByTwo working2 = new TwoByTwo(StandardPatterns.Unknown);

            TwoByTwo start = new TwoByTwo(StandardPatterns.Solved);
            Dictionary<FaceColor, BigInteger> standardColorValues = TwoByTwo.GetColorValuesFromCube(start);
            List<Dictionary<FaceColor, FaceColor>> colorFlips = start.GetValidColorFlips(working, working2);

            HashSet<BigInteger> transformations = new HashSet<BigInteger>();
            foreach (BigInteger next in start.GetTransformationNumbers(working, standardColorValues, colorFlips))
            {
                transformations.Add(next);
            }
            Assert.AreEqual(transformations.Count, 24);
            return transformations;
        }


        private HashSet<BigInteger> GetTransformationsForCubeRotationTransformations()
        {
            TwoByTwo start = new TwoByTwo(StandardPatterns.Solved);
            Dictionary<FaceColor, BigInteger> standardColorValues = TwoByTwo.GetColorValuesFromCube(start);
            TwoByTwo working = new TwoByTwo(StandardPatterns.Unknown);
            HashSet<BigInteger> transformations = new HashSet<BigInteger>();
            foreach (CubeRotation cr in CubeRotation.EnumerateRotations())
            {
                working.SetFromOtherCube(start);
                working.PerformCubeRotation(cr);
                BigInteger nextTransformationNumber = working.GetTransformationNumber(standardColorValues);
                Assert.IsFalse(transformations.Contains(nextTransformationNumber));
                transformations.Add(nextTransformationNumber);
            }
            Assert.AreEqual(transformations.Count, 24);
            return transformations;
        }
    }*/
}
