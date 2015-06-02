// -----------------------------------------------------------------------
// <copyright file="FooterCellStyles.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles
{
    using Fanex.Excel.Enums;
    using Fanex.Excel.Repositories.CellStyles.Footer.DateTimeStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.DoubleRedNegativeStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.DoubleRedparenthesisNegativeStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.DoubleRedPositiveStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.DoubleStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.GeneralStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.IntegerStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.PercentageRedNegativeStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.PercentageRedparenthesisNegativeStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.PercentageRedPositiveStyles;
    using Fanex.Excel.Repositories.CellStyles.Footer.PercentageStyles;
    using NPOI.HSSF.Util;
    using NPOI.SS.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FooterCellStyles : BaseCellStyles, IFooterCellStyles
    {
        private IFont _footerFont;

        public FooterCellStyles(IWorkbook workbook)
            : base(workbook)
        {
            this.CreateFont();
            this.General = new GeneralStyle(workbook, this._footerFont);
            this.Integer = new IntegerStyle(workbook, this._footerFont);
            this.IntegerRedPositive = new IntegerRedPositiveStyle(workbook, this._footerFont);
            this.IntegerRedNegative = new IntegerRedNegativeStyle(workbook, this._footerFont);
            this.IntegerRedparenthesisNegative = new IntegerRedparenthesisNegativeStyle(workbook, this._footerFont);
            this.Double = new DoubleStyle(workbook, this._footerFont);
            this.DoubleRedPositive = new DoubleRedPositiveStyle(workbook, this._footerFont);
            this.DoubleRedNegative = new DoubleRedNegativeStyle(workbook, this._footerFont);
            this.DoubleRedparenthesisNegative = new DoubleRedparenthesisNegativeStyle(workbook, this._footerFont);
            this.Percentage = new PercentageStyle(workbook, this._footerFont);
            this.PercentageRedPositive = new PercentageRedPositiveStyle(workbook, this._footerFont);
            this.PercentageRedNegative = new PercentageRedNegativeStyle(workbook, this._footerFont);
            this.PercentageRedparenthesisNegative = new PercentageRedparenthesisNegativeStyle(workbook, this._footerFont);
            this.DateTimeStyle = new DateTimeStyle(workbook, this._footerFont);
            this.DoubleParenthesisNegative = new DoubleParenthesisNegativeStyle(workbook, this._footerFont);
        }

        public GeneralStyle General { get; set; }

        public IntegerStyle Integer { get; set; }

        public IntegerRedPositiveStyle IntegerRedPositive { get; set; }

        public IntegerRedNegativeStyle IntegerRedNegative { get; set; }

        public IntegerRedparenthesisNegativeStyle IntegerRedparenthesisNegative { get; set; }

        public DoubleStyle Double { get; set; }

        public DoubleRedPositiveStyle DoubleRedPositive { get; set; }

        public DoubleRedNegativeStyle DoubleRedNegative { get; set; }

        public DoubleRedparenthesisNegativeStyle DoubleRedparenthesisNegative { get; set; }

        public PercentageStyle Percentage { get; set; }

        public PercentageRedPositiveStyle PercentageRedPositive { get; set; }

        public PercentageRedNegativeStyle PercentageRedNegative { get; set; }

        public PercentageRedparenthesisNegativeStyle PercentageRedparenthesisNegative { get; set; }

        public DateTimeStyle DateTimeStyle { get; set; }

        public DoubleParenthesisNegativeStyle DoubleParenthesisNegative { get; set; }

        /// <summary>
        /// Gets the cell style.
        /// </summary>
        /// <param name="cellType">Type of the cell.</param>
        /// <param name="horizonAlign">The horizon align.</param>
        /// <param name="isFirstFooterRow">If set to <c>true</c> [is first footer row].</param>
        /// <returns>Cell style.</returns>
        public ICellStyle GetCellStyle(ExcelCellType cellType, HAlignment horizonAlign, bool isFirstFooterRow)
        {
            switch (cellType)
            {
                case ExcelCellType.Integer:
                case ExcelCellType.IntegerRedPositive:
                case ExcelCellType.IntegerRedNegative:
                case ExcelCellType.IntegerRedparenthesisNegative:
                    return this.GetIntegerCellStyle(cellType, isFirstFooterRow);

                case ExcelCellType.Double:
                case ExcelCellType.DoubleRedPositive:
                case ExcelCellType.DoubleRedPositiveNoteInformation:
                case ExcelCellType.DoubleRedNegative:
                case ExcelCellType.DoubleRedParenthesisNegative:
                case ExcelCellType.DoubleParenthesisNegative:
                    return this.GetDoubleCellStyle(cellType, isFirstFooterRow);

                case ExcelCellType.Percentage:
                case Enums.ExcelCellType.PercentageRedPositive:
                case Enums.ExcelCellType.PercentageRedNegative:
                case ExcelCellType.PercentageRedparenthesisNegative:
                    return this.GetPercentageCellStyle(cellType, isFirstFooterRow);

                case ExcelCellType.DateTimeMMDDYYYY:
                    return isFirstFooterRow ? this.DateTimeStyle.UpperStyle : this.DateTimeStyle.Style;

                case ExcelCellType.FooterInformation:
                    return this.General.Info.Style;

                default:
                    return this.GetGeneralCellStyle(horizonAlign, isFirstFooterRow);
            }
        }

        /// <summary>
        /// Gets the general cell style.
        /// </summary>
        /// <param name="horizonAlign">The horizon align.</param>
        /// <param name="isFirstFooterRow">If set to <c>true</c> [is first footer row].</param>
        /// <returns>Cell Style.</returns>
        public ICellStyle GetGeneralCellStyle(HAlignment horizonAlign, bool isFirstFooterRow)
        {
            switch (horizonAlign)
            {
                case HAlignment.Left:
                    return isFirstFooterRow ? this.General.Left.UpperStyle : this.General.Left.Style;

                case HAlignment.Right:
                    return isFirstFooterRow ? this.General.Right.UpperStyle : this.General.Right.Style;

                case HAlignment.Center:
                    return isFirstFooterRow ? this.General.Center.UpperStyle : this.General.Center.Style;

                default:
                    return isFirstFooterRow ? this.General.Left.UpperStyle : this.General.Left.Style;
            }
        }

        /// <summary>
        /// Gets the integer cell style.
        /// </summary>
        /// <param name="cellType">Type of the cell.</param>
        /// <param name="isFirstFooterRow">If set to <c>true</c> [is first footer row].</param>
        /// <returns>Integer Cell Style.</returns>
        private ICellStyle GetIntegerCellStyle(Enums.ExcelCellType cellType, bool isFirstFooterRow)
        {
            switch (cellType)
            {
                case Enums.ExcelCellType.Integer:
                    return isFirstFooterRow ? this.Integer.UpperStyle : this.Integer.Style;

                case Enums.ExcelCellType.IntegerRedPositive:
                    return isFirstFooterRow ? this.IntegerRedPositive.UpperStyle : this.IntegerRedPositive.Style;

                case Enums.ExcelCellType.IntegerRedNegative:
                    return isFirstFooterRow ? this.IntegerRedNegative.UpperStyle : this.IntegerRedNegative.Style;

                case Enums.ExcelCellType.IntegerRedparenthesisNegative:
                    return isFirstFooterRow ? this.IntegerRedparenthesisNegative.UpperStyle : this.IntegerRedparenthesisNegative.Style;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the Double cell style.
        /// </summary>
        /// <param name="cellType">Type of the cell.</param>
        /// <param name="isFirstFooterRow">If set to <c>true</c> [is first footer row].</param>
        /// <returns>Double Cell Style.</returns>
        private ICellStyle GetDoubleCellStyle(Enums.ExcelCellType cellType, bool isFirstFooterRow)
        {
            switch (cellType)
            {
                case Enums.ExcelCellType.Double:
                    return isFirstFooterRow ? this.Double.UpperStyle : this.Double.Style;

                case Enums.ExcelCellType.DoubleRedPositive:
                    return isFirstFooterRow ? this.DoubleRedPositive.UpperStyle : this.DoubleRedPositive.Style;

                case Enums.ExcelCellType.DoubleRedPositiveNoteInformation:
                    return isFirstFooterRow ? this.DoubleRedPositive.UppderNoteInformationStyle : this.DoubleRedPositive.Style;

                case Enums.ExcelCellType.DoubleRedNegative:
                    return isFirstFooterRow ? this.DoubleRedNegative.UpperStyle : this.DoubleRedNegative.Style;

                case Enums.ExcelCellType.DoubleRedParenthesisNegative:
                    return isFirstFooterRow ? this.DoubleRedparenthesisNegative.UpperStyle : this.DoubleRedparenthesisNegative.Style;

                case Enums.ExcelCellType.DoubleParenthesisNegative:
                    return isFirstFooterRow ? this.DoubleParenthesisNegative.UpperStyle : this.DoubleParenthesisNegative.Style;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Gets the Percentage cell style.
        /// </summary>
        /// <param name="cellType">Type of the cell.</param>
        /// <param name="isFirstFooterRow">If set to <c>true</c> [is first footer row].</param>
        /// <returns>Percentage Cell Style.</returns>
        private ICellStyle GetPercentageCellStyle(Enums.ExcelCellType cellType, bool isFirstFooterRow)
        {
            switch (cellType)
            {
                case Enums.ExcelCellType.Percentage:
                    return isFirstFooterRow ? this.Percentage.UpperStyle : this.Percentage.Style;

                case Enums.ExcelCellType.PercentageRedPositive:
                    return isFirstFooterRow ? this.PercentageRedPositive.UpperStyle : this.PercentageRedPositive.Style;

                case Enums.ExcelCellType.PercentageRedNegative:
                    return isFirstFooterRow ? this.PercentageRedNegative.UpperStyle : this.PercentageRedNegative.Style;

                case Enums.ExcelCellType.PercentageRedparenthesisNegative:
                    return isFirstFooterRow ? this.PercentageRedparenthesisNegative.UpperStyle : this.PercentageRedparenthesisNegative.Style;

                default:
                    return null;
            }
        }

        private void CreateFont()
        {
            this._footerFont = this.Workbook.CreateFont();
            this._footerFont.FontName = "Tahoma";
            this._footerFont.FontHeightInPoints = 8;
            this._footerFont.Boldweight = (short)FontBoldWeight.Bold;
            this._footerFont.Color = HSSFColor.Black.Index;
        }
    }
}