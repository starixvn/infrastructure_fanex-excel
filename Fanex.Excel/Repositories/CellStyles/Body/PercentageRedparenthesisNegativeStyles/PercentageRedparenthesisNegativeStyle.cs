// -----------------------------------------------------------------------
// <copyright file="PercentageRedparenthesisNegativeStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.PercentageRedparenthesisNegativeStyles
{
    using Fanex.Excel.Enums;
    using Fanex.Excel.Repositories.CellStyles.Body.PercentageRedparenthesisNegativeStyles.OddEvenStyles;
    using NPOI.SS.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PercentageRedparenthesisNegativeStyle : BaseCellStyles
    {
        public PercentageRedparenthesisNegativeStyle(IWorkbook workbook, IFont font)
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
        /// <returns>Cell Style Object.</returns>
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