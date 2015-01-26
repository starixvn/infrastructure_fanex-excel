// -----------------------------------------------------------------------
// <copyright file="OddStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.DoubleRedParenthesisNegativeStyles.OddEvenStyles
{
    using System.Drawing;
    using Fanex.Excel.Constants;
    using NPOI.HSSF.UserModel;
    using NPOI.HSSF.Util;
    using NPOI.SS.UserModel;
    using NPOI.XSSF.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class OddStyle : BaseCellStyles
    {
        public OddStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.DoubleRedParenthesisNegative,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HSSFColor.White() : (IColor)(new XSSFColor(Color.Transparent)),
                font,
                HorizontalAlignment.General,
                VerticalAlignment.Top);
        }

        public ICellStyle Style { get; set; }
    }
}
