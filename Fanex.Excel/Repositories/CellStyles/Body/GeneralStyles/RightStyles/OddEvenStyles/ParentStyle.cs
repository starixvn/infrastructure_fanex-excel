// -----------------------------------------------------------------------
// <copyright file="ParentStyle.cs" company="Nexcel Solutions Vietnam">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles.RightStyles.OddEvenStyles
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
        private ICellStyle _style;

        public ParentStyle(IWorkbook workbook, IFont font)
            : base(workbook, font)
        {
        }

        public ICellStyle Style
        {
            get
            {
                if (this._style == null)
                {
                    this._style = this.CreateCellStyle(
                        ExcelConstants.General,
                        this.Workbook.GetType().Equals(typeof(HSSFWorkbook)) ? (IColor)new SubTotalRowColor() : (IColor)(new XSSFColor(ExcelConstants.ParentRowColor)),
                        this.Font,
                        HorizontalAlignment.Right,
                        VerticalAlignment.Top);
                }

                return this._style;
            }
        }
    }
}