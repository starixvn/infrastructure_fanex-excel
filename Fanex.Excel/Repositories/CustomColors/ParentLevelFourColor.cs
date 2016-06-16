// -----------------------------------------------------------------------
// <copyright file="ParentLevelFourColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The ParentColor class.
    /// </summary>
    public class ParentLevelFourColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 41;
        private static short[] _triplet = new short[3] { 204, 255, 255 };

        public ParentLevelFourColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return ParentLevelFourColor._triplet; }
            set { ParentLevelFourColor._triplet = value; }
        }

        public override short GetIndex()
        {
            return Index;
        }

        public override short[] GetTriplet()
        {
            return _triplet;
        }
    }
}
