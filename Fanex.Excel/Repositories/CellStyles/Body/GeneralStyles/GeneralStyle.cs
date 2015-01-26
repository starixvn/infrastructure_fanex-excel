// -----------------------------------------------------------------------
// <copyright file="GeneralStyle.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles
{
    using Fanex.Excel.Repositories.CellStyles.Body.GeneralStyles.LeftStyles;
    using NPOI.SS.UserModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GeneralStyle : BaseCellStyles
    {
        public GeneralStyle(IWorkbook workbook, IFont font)
            : base(workbook)
        {
            this.Left = new LeftStyle(workbook, font);
            this.Right = new RightStyle(workbook, font);
            this.Center = new CenterStyle(workbook, font);
        }

        public LeftStyle Left { get; set; }

        public RightStyle Right { get; set; }

        public CenterStyle Center { get; set; }
    }
}
