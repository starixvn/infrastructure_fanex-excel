// -----------------------------------------------------------------------
// <copyright file="EvenStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.DateTimeStyles.OddEvenStyles
{
    using Fanex.Excel.Constants;
    using Fanex.Excel.Repositories.CustomColors;
    using NPOI.HSSF.UserModel;
    using NPOI.SS.UserModel;
    using NPOI.XSSF.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class EvenStyle : BaseCellStyles
    {
        public EvenStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.DateTimemMmddyyyy,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new EvenRowColor() : (IColor)(new XSSFColor(ExcelConstants.EvenRowColor)),
                font,
                HorizontalAlignment.Center,
                VerticalAlignment.Top);
        }

        public ICellStyle Style { get; set; }
    }
}
