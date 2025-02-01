using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    /// <summary>
    /// represents the 24 possible cube transformations using only rotation
    /// </summary>
    public class CubeRotation
    {
        public static CubeRotation NULL = new CubeRotation("");
        public static CubeRotation X = new CubeRotation("x");
        public static CubeRotation XPRIME = new CubeRotation("x'");
        public static CubeRotation X2 = new CubeRotation("x2");
        public static CubeRotation Y = new CubeRotation("y");
        public static CubeRotation YPRIME = new CubeRotation("y'");
        public static CubeRotation Y2 = new CubeRotation("y2");
        public static CubeRotation Z = new CubeRotation("z");
        public static CubeRotation ZPRIME = new CubeRotation("z'");
        public static CubeRotation Z2 = new CubeRotation("z2");

        public static CubeRotation XY = new CubeRotation("xy");
        public static CubeRotation XZ = new CubeRotation("xz");
        public static CubeRotation YX = new CubeRotation("yx");
        public static CubeRotation ZY = new CubeRotation("zy");

        public static CubeRotation XYPRIME = new CubeRotation("xy'");
        public static CubeRotation YZPRIME = new CubeRotation("yz'");
        public static CubeRotation ZXPRIME = new CubeRotation("zx'");

        public static CubeRotation XPRIMEZPRIME = new CubeRotation("x'z'");

        public static CubeRotation XY2 = new CubeRotation("xy2");
        public static CubeRotation XZ2 = new CubeRotation("xz2");
        public static CubeRotation YX2 = new CubeRotation("yx2");
        public static CubeRotation ZY2 = new CubeRotation("zy2");

        public static CubeRotation X2Y = new CubeRotation("x2y");
        public static CubeRotation Y2Z = new CubeRotation("y2z");

        static CubeRotation()
        {
            X.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XPRIME.FaceRotations.Add(CubeFaceRotation.RIGHT_ANTICLOCKWISE);
            X2.FaceRotations.Add(CubeFaceRotation.RIGHT_HALF);
            Y.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            YPRIME.FaceRotations.Add(CubeFaceRotation.UP_ANTICLOCKWISE);
            Y2.FaceRotations.Add(CubeFaceRotation.UP_HALF);
            Z.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
            ZPRIME.FaceRotations.Add(CubeFaceRotation.FRONT_ANTICLOCKWISE);
            Z2.FaceRotations.Add(CubeFaceRotation.FRONT_HALF);

            XY.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XY.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            XZ.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XZ.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
            YX.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            YX.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            ZY.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
            ZY.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);

            XYPRIME.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XYPRIME.FaceRotations.Add(CubeFaceRotation.UP_ANTICLOCKWISE);
            YZPRIME.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            YZPRIME.FaceRotations.Add(CubeFaceRotation.FRONT_ANTICLOCKWISE);
            ZXPRIME.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
            ZXPRIME.FaceRotations.Add(CubeFaceRotation.RIGHT_ANTICLOCKWISE);

            XPRIMEZPRIME.FaceRotations.Add(CubeFaceRotation.RIGHT_ANTICLOCKWISE);
            XPRIMEZPRIME.FaceRotations.Add(CubeFaceRotation.FRONT_ANTICLOCKWISE);

            XY2.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XY2.FaceRotations.Add(CubeFaceRotation.UP_HALF);
            XZ2.FaceRotations.Add(CubeFaceRotation.RIGHT_CLOCKWISE);
            XZ2.FaceRotations.Add(CubeFaceRotation.FRONT_HALF);
            YX2.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            YX2.FaceRotations.Add(CubeFaceRotation.RIGHT_HALF);
            ZY2.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
            ZY2.FaceRotations.Add(CubeFaceRotation.UP_HALF);

            X2Y.FaceRotations.Add(CubeFaceRotation.RIGHT_HALF);
            X2Y.FaceRotations.Add(CubeFaceRotation.UP_CLOCKWISE);
            Y2Z.FaceRotations.Add(CubeFaceRotation.UP_HALF);
            Y2Z.FaceRotations.Add(CubeFaceRotation.FRONT_CLOCKWISE);
        }

        public override string ToString()
        {
            return Name;
        }

        private CubeRotation(string Name)
        {
            this.Name = Name;
            FaceRotations = new List<CubeFaceRotation>();
        }

        public string Name { get; private set; }

        public List<CubeFaceRotation> FaceRotations { get; private set; }

        public static IEnumerable<CubeRotation> EnumerateRotations()
        {
            yield return NULL;
            if (TwoByTwo.ALLOW_CUBE_ROTATION_TRANSFORMATIONS)
            {
                yield return X;
                yield return XPRIME;
                yield return X2;
                yield return Y;
                yield return YPRIME;
                yield return Y2;
                yield return Z;
                yield return ZPRIME;
                yield return Z2;

                yield return XY;
                yield return XZ;
                yield return YX;
                yield return ZY;

                yield return XYPRIME;
                yield return YZPRIME;
                yield return ZXPRIME;

                yield return XPRIMEZPRIME;

                yield return XY2;
                yield return XZ2;
                yield return YX2;
                yield return ZY2;

                yield return X2Y;
                yield return Y2Z;
            }
        }
    }
}
