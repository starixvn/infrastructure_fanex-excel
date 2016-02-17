// -----------------------------------------------------------------------
// <copyright file="GrandTotalRowColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The TotalRowColor class.
    /// </summary>
    public class GrandTotalRowColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 34;
        private static short[] _triplet = new short[3] { 220, 226, 188 };

        public GrandTotalRowColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return GrandTotalRowColor._triplet; }
            set { GrandTotalRowColor._triplet = value; }
        }

        public override short Indexed
        {
            get
            {
                return Index;
            }
        }
    }
}
