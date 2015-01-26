// -----------------------------------------------------------------------
// <copyright file="ParentColor.cs" company="Nexcel Solutions Vietnam">
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
    public class ParentColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 33;
        private static short[] _triplet = new short[3] { 194, 217, 236 };

        public ParentColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return ParentColor._triplet; }
            set { ParentColor._triplet = value; }
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
