// -----------------------------------------------------------------------
// <copyright file="RevenueLicenseeColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The RevenueLicenseeColor class.
    /// </summary>
    public class RevenueLicenseeColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 36;
        private static short[] _triplet = new short[3] { 213, 132, 52 };

        public RevenueLicenseeColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return RevenueLicenseeColor._triplet; }
            set { RevenueLicenseeColor._triplet = value; }
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
