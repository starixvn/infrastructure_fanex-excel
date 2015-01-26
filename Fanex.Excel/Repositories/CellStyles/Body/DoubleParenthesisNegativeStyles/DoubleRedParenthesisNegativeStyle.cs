// -----------------------------------------------------------------------
// <copyright file="DoubleRedparenthesisNegativeStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.DoubleParenthesisNegativeStyles
{
    using Fanex.Excel.Enums;
    using Fanex.Excel.Repositories.CellStyles.Body.DoubleParenthesisNegativeStyles.OddEvenStyles;
    using NPOI.SS.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DoubleRedparenthesisNegativeStyle : BaseCellStyles
    {
        public DoubleRedparenthesisNegativeStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Odd = new OddStyle(workbook, font);
            this.Even = new EvenStyle(workbook, font);
            this.SubTotal = new SubTotalStyle(workbook, font);
        }

        public OddStyle Odd { get; set; }

        public EvenStyle Even { get; set; }

        public SubTotalStyle SubTotal { get; set; }

        /// <summary>
        /// Gets the cell style.
        /// </summary>
        /// <param name="rowType">Type of the row.</param>
        /// <returns>Cell Style object.</returns>
        public ICellStyle GetCellStyle(RowType rowType)
        {
            switch (rowType)
            {
                case RowType.Normal:
                    return this.Odd.Style;
                case RowType.Even:
                    return this.Even.Style;
                case RowType.SubTotal:
                    return this.SubTotal.Style;
                default:
                    return this.Odd.Style;
            }
        }
    }
}