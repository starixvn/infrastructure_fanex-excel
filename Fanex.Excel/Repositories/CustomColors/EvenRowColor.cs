// -----------------------------------------------------------------------
// <copyright file="EvenRowColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The EvenRowColor class.
    /// </summary>
    public class EvenRowColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 32;
        private static short[] _triplet = new short[3] { 228, 242, 253 };

        public EvenRowColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return EvenRowColor._triplet; }
            set { EvenRowColor._triplet = value; }
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
