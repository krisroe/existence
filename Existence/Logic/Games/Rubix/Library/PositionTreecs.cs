using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    public class PositionTree
    {
        public PositionTree(BigInteger ExactTransformationValue, BigInteger BestTransformationValue, PositionTree? previousPositionTree, FaceRotation? FaceRotation)
        {
            this.ExactTransformationValue = ExactTransformationValue;
            this.BestTransformationValue = BestTransformationValue;
            this.PreviousPositionTree = previousPositionTree;
            this.FaceRotation = FaceRotation;
            this.NextPositions = new List<PositionTree>();
        }

        /// <summary>
        /// transformation value. here is it the actual values of the cube and not a lowest transformation
        /// </summary>
        public BigInteger ExactTransformationValue { get; set; }

        /// <summary>
        /// best transformation value
        /// </summary>
        public BigInteger BestTransformationValue { get; set; }

        /// <summary>
        /// previous position tree
        /// </summary>
        public PositionTree? PreviousPositionTree { get; set; }

        /// <summary>
        /// next positions
        /// </summary>
        public List<PositionTree> NextPositions { get; set; }

        /// <summary>
        /// face rotation to get to the position
        /// </summary>
        public FaceRotation? FaceRotation { get; set; }

        public IEnumerable<PositionTree> EnumerateLeafNodes()
        {
            if (this.NextPositions == null || this.NextPositions.Count == 0)
            {
                yield return this;
            }
            else
            {
                foreach (var next in this.NextPositions)
                {
                    foreach (var nextPos in next.EnumerateLeafNodes())
                    {
                        yield return nextPos;
                    }
                }
            }
        }
    }
}
