using System.Collections.Generic;
using System;

namespace Rubix
{
    /// <summary>
    /// a single rotation of one of the faces of the cube
    /// </summary>
    public class FaceRotation : IComparable<FaceRotation>
    {
        public override string ToString()
        {
            string ret;

            switch (Face)
            {
                case CubeFace.Up:
                    ret = "U";
                    break;
                case CubeFace.Down:
                    ret = "D";
                    break;
                case CubeFace.Left:
                    ret = "L";
                    break;
                case CubeFace.Right:
                    ret = "R";
                    break;
                case CubeFace.Front:
                    ret = "F";
                    break;
                case CubeFace.Back:
                    ret = "B";
                    break;
                default:
                    throw new InvalidOperationException();
            }

            if (Direction == -1)
            {
                ret += "'";
            }
            else if (Direction == 2)
            {
                ret += "2";
            }

            return ret;
        }

        public static FaceRotation UP_CLOCKWISE = new FaceRotation(CubeFace.Up, 1);
        public static FaceRotation UP_ANTICLOCKWISE = new FaceRotation(CubeFace.Up, -1);
        public static FaceRotation UP_HALF = new FaceRotation(CubeFace.Up, 2);
        public static FaceRotation DOWN_CLOCKWISE = new FaceRotation(CubeFace.Down, 1);
        public static FaceRotation DOWN_ANTICLOCKWISE = new FaceRotation(CubeFace.Down, -1);
        public static FaceRotation DOWN_HALF = new FaceRotation(CubeFace.Down, 2);
        public static FaceRotation LEFT_CLOCKWISE = new FaceRotation(CubeFace.Left, 1);
        public static FaceRotation LEFT_ANTICLOCKWISE = new FaceRotation(CubeFace.Left, -1);
        public static FaceRotation LEFT_HALF = new FaceRotation(CubeFace.Left, 2);
        public static FaceRotation RIGHT_CLOCKWISE = new FaceRotation(CubeFace.Right, 1);
        public static FaceRotation RIGHT_ANTICLOCKWISE = new FaceRotation(CubeFace.Right, -1);
        public static FaceRotation RIGHT_HALF = new FaceRotation(CubeFace.Right, 2);
        public static FaceRotation FRONT_CLOCKWISE = new FaceRotation(CubeFace.Front, 1);
        public static FaceRotation FRONT_ANTICLOCKWISE = new FaceRotation(CubeFace.Front, -1);
        public static FaceRotation FRONT_HALF = new FaceRotation(CubeFace.Front, 2);
        public static FaceRotation BACK_CLOCKWISE = new FaceRotation(CubeFace.Back, 1);
        public static FaceRotation BACK_ANTICLOCKWISE = new FaceRotation(CubeFace.Back, -1);
        public static FaceRotation BACK_HALF = new FaceRotation(CubeFace.Back, 2);

        public static List<FaceRotation> SortedFaceRotations { get; set; }

        static FaceRotation()
        {
            SortedFaceRotations = new List<FaceRotation>()
            {
                UP_CLOCKWISE,
                UP_ANTICLOCKWISE,
                UP_HALF,
                RIGHT_CLOCKWISE,
                RIGHT_ANTICLOCKWISE,
                RIGHT_HALF,
                FRONT_CLOCKWISE,
                FRONT_ANTICLOCKWISE,
                FRONT_HALF,
                LEFT_CLOCKWISE,
                LEFT_ANTICLOCKWISE,
                LEFT_HALF,
                DOWN_CLOCKWISE,
                DOWN_ANTICLOCKWISE,
                DOWN_HALF,
                BACK_CLOCKWISE,
                BACK_ANTICLOCKWISE,
                BACK_HALF,
            };
        }

        public FaceRotation GetOppositeRotation()
        {
            FaceRotation opposite;
            if (Direction == 2)
            {
                opposite = this;
            }
            else
            {
                opposite = GetRotationForFaceAndDirection(Face, 0 - Direction);
            }
            return opposite;
        }

        public FaceRotation GetMirrorFaceRotation(CubeMirrorType mirror)
        {
            FaceRotation ret;
            if (mirror == CubeMirrorType.Null)
            {
                ret = this;
            }
            else
            {
                CubeFace newFace = Face;
                switch (mirror)
                {
                    case CubeMirrorType.X:
                        if (Face == CubeFace.Left)
                            newFace = CubeFace.Right;
                        else if (Face == CubeFace.Right)
                            newFace = CubeFace.Left;
                        break;
                    case CubeMirrorType.Y:
                        if (Face == CubeFace.Up)
                            newFace = CubeFace.Down;
                        else if (Face == CubeFace.Down)
                            newFace = CubeFace.Up;
                        break;
                    case CubeMirrorType.Z:
                        if (Face == CubeFace.Front)
                            newFace = CubeFace.Back;
                        else if (Face == CubeFace.Back)
                            newFace = CubeFace.Front;
                        break;
                    case CubeMirrorType.XY:
                        if (Face == CubeFace.Left)
                            newFace = CubeFace.Right;
                        else if (Face == CubeFace.Right)
                            newFace = CubeFace.Left;
                        else if (Face == CubeFace.Up)
                            newFace = CubeFace.Down;
                        else if (Face == CubeFace.Down)
                            newFace = CubeFace.Up;
                        break;
                    case CubeMirrorType.XZ:
                        if (Face == CubeFace.Left)
                            newFace = CubeFace.Right;
                        else if (Face == CubeFace.Right)
                            newFace = CubeFace.Left;
                        else if (Face == CubeFace.Front)
                            newFace = CubeFace.Back;
                        else if (Face == CubeFace.Back)
                            newFace = CubeFace.Front;
                        break;
                    case CubeMirrorType.YZ:
                        if (Face == CubeFace.Up)
                            newFace = CubeFace.Down;
                        else if (Face == CubeFace.Down)
                            newFace = CubeFace.Up;
                        else if (Face == CubeFace.Front)
                            newFace = CubeFace.Back;
                        else if (Face == CubeFace.Back)
                            newFace = CubeFace.Front;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                int newDirection;
                if (Direction == 2)
                {
                    newDirection = 2;
                }
                else
                {
                    if (mirror == CubeMirrorType.X || mirror == CubeMirrorType.Y || mirror == CubeMirrorType.Z)
                    {
                        newDirection = Direction * -1;
                    }
                    else if (mirror == CubeMirrorType.XY || mirror == CubeMirrorType.XZ || mirror == CubeMirrorType.YZ)
                    {
                        newDirection = Direction;
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                ret = GetRotationForFaceAndDirection(newFace, newDirection);
            }
            return ret;
        }


        public static FaceRotation GetRotationForFaceAndDirection(CubeFace face, int Direction)
        {
            FaceRotation ret;
            if (Direction == 1)
            {
                switch (face)
                {
                    case CubeFace.Up:
                        ret = UP_CLOCKWISE;
                        break;
                    case CubeFace.Down:
                        ret = DOWN_CLOCKWISE;
                        break;
                    case CubeFace.Left:
                        ret = LEFT_CLOCKWISE;
                        break;
                    case CubeFace.Right:
                        ret = RIGHT_CLOCKWISE;
                        break;
                    case CubeFace.Front:
                        ret = FRONT_CLOCKWISE;
                        break;
                    case CubeFace.Back:
                        ret = BACK_CLOCKWISE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else if (Direction == -1)
            {
                switch (face)
                {
                    case CubeFace.Up:
                        ret = UP_ANTICLOCKWISE;
                        break;
                    case CubeFace.Down:
                        ret = DOWN_ANTICLOCKWISE;
                        break;
                    case CubeFace.Left:
                        ret = LEFT_ANTICLOCKWISE;
                        break;
                    case CubeFace.Right:
                        ret = RIGHT_ANTICLOCKWISE;
                        break;
                    case CubeFace.Front:
                        ret = FRONT_ANTICLOCKWISE;
                        break;
                    case CubeFace.Back:
                        ret = BACK_ANTICLOCKWISE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else if (Direction == 2)
            {
                switch (face)
                {
                    case CubeFace.Up:
                        ret = UP_HALF;
                        break;
                    case CubeFace.Down:
                        ret = DOWN_HALF;
                        break;
                    case CubeFace.Left:
                        ret = LEFT_HALF;
                        break;
                    case CubeFace.Right:
                        ret = RIGHT_HALF;
                        break;
                    case CubeFace.Front:
                        ret = FRONT_HALF;
                        break;
                    case CubeFace.Back:
                        ret = BACK_HALF;
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

        public static IEnumerable<FaceRotation> EnumerateFaceRotations(bool IncludeHalf)
        {
            foreach (FaceRotation next in SortedFaceRotations)
            {
                if (IncludeHalf || next.Direction != 2)
                {
                    yield return next;
                }
            }
        }

        public int CompareTo(FaceRotation? other)
        {
            return SortedFaceRotations.IndexOf(this).CompareTo(SortedFaceRotations.IndexOf(other));
        }

        private FaceRotation(CubeFace face, int Direction)
        {
            this.Face = face;
            this.Direction = Direction;
        }

        public CubeFace Face { get; private set; }
        public int Direction { get; private set; }
    }
}
