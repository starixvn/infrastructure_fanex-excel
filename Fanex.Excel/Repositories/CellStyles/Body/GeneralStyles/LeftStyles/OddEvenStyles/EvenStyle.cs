// -----------------------------------------------------------------------
// <copyright file="EvenStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles.LeftStyles.OddEvenStyles
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
        private ICellStyle _style;

        public EvenStyle(IWorkbook workbook, IFont font)
            : base(workbook, font)
        {
        }

        /// <summary>
        /// Gets the style.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        /// <returns>The object of ICellStyle.</returns>
        public ICellStyle Style
        {
            get
            {
                if (this._style == null)
                {
                    this._style = this.CreateCellStyle(
                                ExcelConstants.General,
                                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new EvenRowColor() : (IColor)(new XSSFColor(ExcelConstants.EvenRowColor)),
                                this.Font,
                                HorizontalAlignment.Left,
                                VerticalAlignment.Top);
                }

                return this._style;
            }
        }
    }
}
