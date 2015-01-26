// -----------------------------------------------------------------------
// <copyright file="HeaderCellStyles.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles
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
    public class HeaderCellStyles : BaseCellStyles, IHeaderCellStyles
    {
        private IFont _headerFont;

        private IFont _titleFont;

        public HeaderCellStyles(IWorkbook workbook)
            : base(workbook)
        {
            this._headerFont = this.CreateFont();
            this._titleFont = this.CreateTitleFont();
            this.CreateTitleStyle();
            this.CreateLeftStyle();
            this.CreateRightStyle();
            this.CreateCenterStyle();
        }

        public ICellStyle Title { get; set; }

        public ICellStyle Left { get; set; }

        public ICellStyle Right { get; set; }

        public ICellStyle Center { get; set; }

        /// <summary>
        /// Gets the header style.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns>Cell Style.</returns>
        public ICellStyle GetHeaderStyle(string alignment)
        {
            switch (alignment)
            {
                case "left":
                    return Left;
                case "right":
                    return Right;
                default:
                    return Center;
            }
        }

        private IFont CreateFont()
        {
            var boldFont = this.Workbook.CreateFont();
            boldFont.FontName = "Tahoma";
            boldFont.FontHeightInPoints = 8;
            boldFont.Boldweight = (short)FontBoldWeight.Bold;
            boldFont.Color = HSSFColor.White.Index;

            return boldFont;
        }

        private IFont CreateTitleFont()
        {
            var titleFont = this.Workbook.CreateFont();
            titleFont.FontName = "Arial";
            titleFont.FontHeightInPoints = 10;
            titleFont.Color = HSSFColor.Black.Index;
            return titleFont;
        }

        private void CreateTitleStyle()
        {
            this.Title = this.CreateCellStyle(
                string.Empty,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new TitleColor() : (IColor)(new XSSFColor(ExcelConstants.TitleBackgroundColor)),
                this._titleFont,
                HorizontalAlignment.Left,
                VerticalAlignment.Top);
        }

        private void CreateLeftStyle()
        {
            this.Left = this.CreateCellStyle(
                string.Empty,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HeaderColor() : (IColor)(new XSSFColor(ExcelConstants.HeaderBackgroundColor)),
                this._headerFont,
                HorizontalAlignment.Left,
                VerticalAlignment.Top);
        }

        private void CreateRightStyle()
        {
            this.Right = this.CreateCellStyle(
                string.Empty, 
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HeaderColor() : (IColor)(new XSSFColor(ExcelConstants.HeaderBackgroundColor)),
                this._headerFont,
                HorizontalAlignment.Right,
                VerticalAlignment.Top);
        }

        private void CreateCenterStyle()
        {
            this.Center = this.CreateCellStyle(
                string.Empty, 
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new HeaderColor() : (IColor)(new XSSFColor(ExcelConstants.HeaderBackgroundColor)),
                this._headerFont,
                HorizontalAlignment.Center,
                VerticalAlignment.Top);
        }
    }
}
