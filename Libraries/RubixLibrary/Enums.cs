using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubix
{
    public enum MetricType
    {
        All,
        MinimizeRotationsBeyondTwoFaces,
        MaxRU,
        MaxRUL,
    }

    public enum TwoByTwoCorner
    {
        ULF,
        URF,
        ULB,
        URB,
        DLF,
        DRF,
        DLB,
        DRB,
    }

    public enum TwoByTwoFace
    {
        ULFUp = 0,
        ULFLeft = 1,
        ULFFront = 2,
        URFUp = 3,
        URFRight = 4,
        URFFront = 5,
        ULBUp = 6,
        ULBLeft = 7,
        ULBBack = 8,
        URBUp = 9,
        URBRight = 10,
        URBBack = 11,
        DLFDown = 12,
        DLFLeft = 13,
        DLFFront = 14,
        DRFDown = 15,
        DRFRight = 16,
        DRFFront = 17,
        DLBDown = 18,
        DLBLeft = 19,
        DLBBack = 20,
        DRBDown = 21,
        DRBRight = 22,
        DRBBack = 23,
    }

    public enum StandardPatterns
    {
        Unknown = 0,
        Solved = 1,
        Fish = 2,
        Antifish = 3,
        Turtle = 4,
        SumoWrestler = 5,
        Headlights = 6,
        Chameleon = 7,
        Arrow = 8,
        UpComplete = 9,
    }

    public enum CubeAxis
    {
        /// <summary>
        /// along the Y axis, with rotations following the rotation of the up face
        /// </summary>
        Up,

        /// <summary>
        /// along the X axis, with rotations following the rotation of the right face
        /// </summary>
        Right,

        /// <summary>
        /// along the Z axis, with rotations following the rotation fo the left face
        /// </summary>
        Front,
    }

    public enum CubeFace
    {
        Up,
        Front,
        Left,
        Right,
        Back,
        Down,
    }

    public enum FaceColor
    {
        Unknown = 0,
        White = 1,
        Yellow = 2,
        Blue = 3,
        Green = 4,
        Red = 5,
        Orange = 6,
    }

    public enum CubeMirrorType
    {
        Null,

        /// <summary>
        /// mirror about X=0
        /// </summary>
        X,

        /// <summary>
        /// mirror about Y=0
        /// </summary>
        Y,

        /// <summary>
        /// mirror about Z=0
        /// </summary>
        Z,

        /// <summary>
        /// mirror about X=0 and Y=0
        /// </summary>
        XY,

        /// <summary>
        /// mirror about X=0 and Z=0
        /// </summary>
        XZ,

        /// <summary>
        /// mirror about Y=0 and Z=0
        /// </summary>
        YZ,
    }
}
