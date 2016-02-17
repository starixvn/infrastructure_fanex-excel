// -----------------------------------------------------------------------
// <copyright file="TitleColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The TitleColor class.
    /// </summary>
    public class TitleColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 37;
        private static short[] _triplet = new short[3] { 60, 94, 165 };

        public TitleColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return TitleColor._triplet; }
            set { TitleColor._triplet = value; }
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
