// -----------------------------------------------------------------------
// <copyright file="SubTotalRowColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The SubTotalRowColor class.
    /// </summary>
    public class SubTotalRowColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 33;
        private static short[] _triplet = new short[3] { 244, 244, 190 };

        public SubTotalRowColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return SubTotalRowColor._triplet; }
            set { SubTotalRowColor._triplet = value; }
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
