// -----------------------------------------------------------------------
// <copyright file="OddStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.IntegerStyles.OddEvenStyles
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
        private ICellStyle _leftStyle;
        private ICellStyle _centerStyle;
        private ICellStyle _rightStyle;

        public OddStyle(IWorkbook workbook, IFont font)
            : base(workbook, font)
        {
        }

        /// <summary>
        /// Gets the style.
        /// </summary>
        /// <param name="horizontalAlignment">The horizontal alignment.</param>
        /// <returns>The object of ICellStyle.</returns>
        public ICellStyle GetStyle(HorizontalAlignment horizontalAlignment)
        {
            if (horizontalAlignment == HorizontalAlignment.Left)
            {
                return this.GetLeftStyle();
            }
            else if (horizontalAlignment == HorizontalAlignment.Center)
            {
                return this.GetCenterStyle();
            }
            else
            {
                return this.GetRightStyle();
            }
        }

        private ICellStyle GetLeftStyle()
        {
            if (this._leftStyle == null)
            {
                this._leftStyle = this.CreateCellStyle(HorizontalAlignment.Left);
            }

            return this._leftStyle;
        }

        private ICellStyle GetCenterStyle()
        {
            if (this._centerStyle == null)
            {
                this._centerStyle = this.CreateCellStyle(HorizontalAlignment.Center);
            }

            return this._centerStyle;
        }

        private ICellStyle GetRightStyle()
        {
            if (this._rightStyle == null)
            {
                this._rightStyle = this.CreateCellStyle(HorizontalAlignment.Right);
            }

            return this._rightStyle;
        }

        private ICellStyle CreateCellStyle(HorizontalAlignment horizontalAlignment)
        {
            return this.CreateCellStyle(
                           ExcelConstants.Integer,
                           this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HSSFColor.White() : (IColor)(new XSSFColor(Color.Transparent)),
                           this.Font,
                           horizontalAlignment,
                           VerticalAlignment.Top);
        }
    }
}
