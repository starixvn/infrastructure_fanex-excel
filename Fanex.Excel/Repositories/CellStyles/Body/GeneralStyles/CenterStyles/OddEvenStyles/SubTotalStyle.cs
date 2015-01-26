// -----------------------------------------------------------------------
// <copyright file="SubTotalStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles.CenterStyles.OddEvenStyles
{
    using Fanex.Excel.Constants;
    using Fanex.Excel.Repositories.CustomColors;
    using NPOI.HSSF.UserModel;
    using NPOI.SS.UserModel;
    using NPOI.XSSF.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SubTotalStyle : BaseCellStyles
    {
        public SubTotalStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.General,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new SubTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.SubTotalRowColor)),
                font,
                HorizontalAlignment.Center,
                VerticalAlignment.Top);
        }

        public ICellStyle Style { get; set; }
    }
}
