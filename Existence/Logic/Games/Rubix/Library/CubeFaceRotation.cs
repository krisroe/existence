using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    /// <summary>
    /// represents a single rotation of a cube along one axis
    /// </summary>
    public class CubeFaceRotation
    {
        public static CubeFaceRotation UP_CLOCKWISE = new CubeFaceRotation(CubeAxis.Up, 1);
        public static CubeFaceRotation UP_ANTICLOCKWISE = new CubeFaceRotation(CubeAxis.Up, -1);
        public static CubeFaceRotation UP_HALF = new CubeFaceRotation(CubeAxis.Up, 2);
        public static CubeFaceRotation FRONT_CLOCKWISE = new CubeFaceRotation(CubeAxis.Front, 1);
        public static CubeFaceRotation FRONT_ANTICLOCKWISE = new CubeFaceRotation(CubeAxis.Front, -1);
        public static CubeFaceRotation FRONT_HALF = new CubeFaceRotation(CubeAxis.Front, 2);
        public static CubeFaceRotation RIGHT_CLOCKWISE = new CubeFaceRotation(CubeAxis.Right, 1);
        public static CubeFaceRotation RIGHT_ANTICLOCKWISE = new CubeFaceRotation(CubeAxis.Right, -1);
        public static CubeFaceRotation RIGHT_HALF = new CubeFaceRotation(CubeAxis.Right, 2);

        private CubeFaceRotation(CubeAxis Axis, int Direction)
        {
            this.Axis = Axis;
            this.Direction = Direction;
        }

        public CubeAxis Axis { get; private set; }
        public int Direction { get; private set; }

        public static CubeFaceRotation GetRotationForAxisAndDirection(CubeAxis axis, int Direction)
        {
            CubeFaceRotation ret;
            if (Direction == 1)
            {
                switch (axis)
                {
                    case CubeAxis.Front:
                        ret = FRONT_CLOCKWISE;
                        break;
                    case CubeAxis.Right:
                        ret = RIGHT_CLOCKWISE;
                        break;
                    case CubeAxis.Up:
                        ret = UP_CLOCKWISE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else if (Direction == -1)
            {
                switch (axis)
                {
                    case CubeAxis.Front:
                        ret = FRONT_ANTICLOCKWISE;
                        break;
                    case CubeAxis.Right:
                        ret = RIGHT_ANTICLOCKWISE;
                        break;
                    case CubeAxis.Up:
                        ret = UP_ANTICLOCKWISE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else if (Direction == 2)
            {
                switch (axis)
                {
                    case CubeAxis.Front:
                        ret = FRONT_HALF;
                        break;
                    case CubeAxis.Right:
                        ret = RIGHT_HALF;
                        break;
                    case CubeAxis.Up:
                        ret = UP_HALF;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
            return ret;
        }
    }
}
