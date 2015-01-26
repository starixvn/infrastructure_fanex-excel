// -----------------------------------------------------------------------
// <copyright file="OddStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles.RightStyles.OddEvenStyles
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
        private ICellStyle _style;

        public OddStyle(IWorkbook workbook, IFont font)
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
                        this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HSSFColor.White() : (IColor)(new XSSFColor(Color.Transparent)),
                        this.Font,
                        HorizontalAlignment.Right,
                        VerticalAlignment.Top);
                }

                return this._style;
            }
        }
    }
}
