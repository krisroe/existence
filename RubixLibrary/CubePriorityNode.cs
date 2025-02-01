using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    public class CubePriorityNode
    {
        public BigInteger TransformationNumber { get; set; }
        public int Priority { get; set; }

        public CubePriorityNode(BigInteger TransformationNumber, int Priority)
        {
            this.TransformationNumber = TransformationNumber;
            this.Priority = Priority;
        }
    }
}
