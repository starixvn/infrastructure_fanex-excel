// -----------------------------------------------------------------------
// <copyright file="NoteInformationColor.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CustomColors
{
    using System.Diagnostics.CodeAnalysis;
    using NPOI.HSSF.Util;

    /// <summary>
    /// The NoteInformationColor class.
    /// </summary>
    public class NoteInformationColor : HSSFColor
    {
        public const string HexString = "";
        public const short Index = 39;
        private static short[] _triplet = new short[3] { 181, 196, 208 };

        public NoteInformationColor()
            : base()
        {
        }

        public static short[] Triplet
        {
            get { return NoteInformationColor._triplet; }
            set { NoteInformationColor._triplet = value; }
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
