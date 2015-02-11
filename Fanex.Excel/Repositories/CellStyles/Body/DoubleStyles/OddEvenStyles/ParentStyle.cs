// -----------------------------------------------------------------------
// <copyright file="ParentStyle.cs" company="Nexcel Solutions Vietnam">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.DoubleStyles.OddEvenStyles
{
    using Fanex.Excel.Constants;
    using Fanex.Excel.Repositories.CustomColors;
    using NPOI.HSSF.UserModel;
    using NPOI.SS.UserModel;
    using NPOI.XSSF.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ParentStyle : BaseCellStyles
    {
        public ParentStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Style = this.CreateCellStyle(
                ExcelConstants.Double,
                this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new ParentColor() : (IColor)(new XSSFColor(ExcelConstants.ParentRowColor)),
                font,
                HorizontalAlignment.Center,
                VerticalAlignment.Top);
        }

        public ICellStyle Style { get; set; }
    }
}