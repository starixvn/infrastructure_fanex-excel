// -----------------------------------------------------------------------
// <copyright file="DoubleRedNegativeStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Footer.DoubleRedNegativeStyles
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
    public class DoubleRedNegativeStyle : BaseCellStyles
    {
        public DoubleRedNegativeStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.DoubleRedNegative,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new GrandTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor)),
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            this.UpperStyle = this.CreateCellStyle(
                ExcelConstants.DoubleRedNegative,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new GrandTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.FooterBackgroundColor)),
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);

            this.UpperStyle.BorderTop = BorderStyle.Thick;
            this.UpperStyle.TopBorderColor = HSSFColor.Orange.Index;
        }

        public ICellStyle Style { get; set; }

        public ICellStyle UpperStyle { get; set; }
    }
}
