// -----------------------------------------------------------------------
// <copyright file="IntegerStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.IntegerStyles
{
    using Fanex.Excel.Enums;
    using Fanex.Excel.Repositories.CellStyles.Body.IntegerStyles.OddEvenStyles;
    using NPOI.SS.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class IntegerStyle : BaseCellStyles
    {
        public IntegerStyle(IWorkbook workbook, IFont font)
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
        /// <param name="horizonAlign">The horizon align.</param>
        /// <param name="rowType">Type of the row.</param>
        /// <returns>
        /// Cell Style Object.
        /// </returns>
        public ICellStyle GetCellStyle(HAlignment horizonAlign, RowType rowType)
        {
            HorizontalAlignment horizontalAlignment = this.GetHorizontalAlignment(horizonAlign);

            switch (rowType)
            {
                case RowType.Normal:
                    return this.Odd.GetStyle(horizontalAlignment);
                case RowType.Even:
                    return this.Even.GetStyle(horizontalAlignment);
                case RowType.SubTotal:
                    return this.SubTotal.GetStyle(horizontalAlignment);
                default:
                    return this.Odd.GetStyle(horizontalAlignment);
            }
        }
    }
}