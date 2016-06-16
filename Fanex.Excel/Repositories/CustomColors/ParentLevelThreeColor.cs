// -----------------------------------------------------------------------
// <copyright file="ParentLevelThreeColor.cs" company="Nexcel Solutions Vietnam">
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
    public class ParentLevelThreeColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 38;
        private static short[] _triplet = new short[3] { 235, 253, 253 };

        public ParentLevelThreeColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return ParentLevelThreeColor._triplet; }
            set { ParentLevelThreeColor._triplet = value; }
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
