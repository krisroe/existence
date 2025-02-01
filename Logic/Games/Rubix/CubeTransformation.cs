using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    public class CubeTransformation
    {
        public CubeTransformation(CubeRotation Rotation, Dictionary<FaceColor, FaceColor> ColorFlip)
        {
            this.Rotation = Rotation;
            this.ColorFlip = ColorFlip;
        }
        public CubeRotation Rotation { get; set; }
        public Dictionary<FaceColor, FaceColor> ColorFlip { get; set; }

        public static IEnumerable<CubeTransformation> EnumerateTransformations(List<Dictionary<FaceColor, FaceColor>> colorFlips)
        {
            foreach (var nextColorFlip in colorFlips)
            {
                foreach (var nextRotation in CubeRotation.EnumerateRotations())
                {
                    yield return new CubeTransformation(nextRotation, nextColorFlip);
                }
            }
        }

        public bool IsNullTransformation()
        {
            bool ret = Rotation == CubeRotation.NULL;
            if (ret)
            {
                foreach (var next in ColorFlip)
                {
                    if (next.Key != next.Value)
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
