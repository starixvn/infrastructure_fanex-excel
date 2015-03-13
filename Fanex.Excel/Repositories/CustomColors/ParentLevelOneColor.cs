// -----------------------------------------------------------------------
// <copyright file="ParentLevelOneColor.cs" company="Nexcel Solutions Vietnam">
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
    public class ParentLevelOneColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 25;
        private static short[] _triplet = new short[3] { 194, 217, 236 };

        public ParentLevelOneColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return ParentLevelOneColor._triplet; }
            set { ParentLevelOneColor._triplet = value; }
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
