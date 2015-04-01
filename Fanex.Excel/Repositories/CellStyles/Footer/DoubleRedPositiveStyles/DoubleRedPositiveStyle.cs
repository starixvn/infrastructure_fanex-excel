// -----------------------------------------------------------------------
// <copyright file="DoubleRedPositiveStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Footer.DoubleRedPositiveStyles
{
    using Fanex.Excel.Constants;
    using Fanex.Excel.Repositories.CustomColors;
    using NPOI.HSSF.UserModel;
    using NPOI.HSSF.Util;
    using NPOI.SS.UserModel;
    using NPOI.XSSF.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DoubleRedPositiveStyle : BaseCellStyles
    {
        public DoubleRedPositiveStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.DoubleRedPositive,
                IsHSSFWorkbook() ? (IColor)new GrandTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor)),
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            this.UpperStyle = this.CreateCellStyle(
                ExcelConstants.DoubleRedPositive,
                IsHSSFWorkbook() ? (IColor)new GrandTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor)),
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            var color = IsHSSFWorkbook() ? (IColor)new NoteInformationColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor));
            this.NoteInformationStyle = this.CreateCellStyle(
                ExcelConstants.DoubleRedPositive,
                color,
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            color = IsHSSFWorkbook() ? (IColor)new NoteInformationColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor));
            this.UppderNoteInformationStyle = this.CreateCellStyle(
                ExcelConstants.DoubleRedPositive,
                color,
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            this.UpperStyle.BorderTop = BorderStyle.Thick;
            this.UpperStyle.TopBorderColor = HSSFColor.Orange.Index;

            this.UppderNoteInformationStyle.BorderTop = BorderStyle.Thick;
            this.UppderNoteInformationStyle.TopBorderColor = HSSFColor.Orange.Index;
        }

        public ICellStyle UpperStyle { get; set; }

        public ICellStyle NoteInformationStyle { get; set; }

        public ICellStyle UppderNoteInformationStyle { get; set; }

        private bool IsHSSFWorkbook()
        {
            return this.Workbook.GetType().Equals(typeof(HSSFWorkbook));
        }
    }
}
