namespace Fanex.Excel.Documentation.Services
{
    using Fanex.Excel.Models;
    using Fanex.Excel.Enums;
    using System.Collections.Generic;
    using NPOI.HSSF.Util;
    using Grid.Documentation.Services;
    public class CustomizedFooterService : BaseServices, ISampleService
    {
        private GridOptions _gridOptions;

        public CustomizedFooterService()
        {
            this._gridOptions = new GridOptions();
        }

        public GridOptions GenerateData()
        {
            this.RegisterCustomCellStyle();
            this.GenerateHeader();
            this.GenerateBody();
            this.GenerateFooter();
            this._gridOptions.ShowFooter = true;
            return this._gridOptions;
        }

        private void GenerateHeader()
        {
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 1", Width = 60, Name = "No", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Center });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 2", Width = 100, Name = "Text1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 3", Width = 100, Name = "Number1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 4", Width = 100, Name = "Number2", CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 5", Width = 100, Name = "Number3", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 6", Width = 110, Name = "Text2" });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 7", Width = 120, Name = "Text3" });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 8", Width = 150, Name = "Text4" });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 9", Width = 90, Name = "Number4", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 10", Width = 120, Name = "Number5", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
        }

        private void GenerateBody()
        {
            for (int i = 0; i < 100; i++)
            {
                var bodyRow = new GridDataRow();
                bodyRow.CreateColumns(new Columns() { Name = "No", Value = i });
                bodyRow.CreateColumns(new Columns() { Name = "Text1", Value = RandomString(5) });
                bodyRow.CreateColumns(new Columns() { Name = "Number1", Value = RandomDouble().ToString("0.###") });
                bodyRow.CreateColumns(new Columns() { Name = "Number2", Value = RandomInteger() });
                bodyRow.CreateColumns(new Columns() { Name = "Number3", Value = RandomDouble().ToString("0.####") });
                bodyRow.CreateColumns(new Columns() { Name = "Text2", Value = RandomString(6) });
                bodyRow.CreateColumns(new Columns() { Name = "Text3", Value = RandomString(7) });
                bodyRow.CreateColumns(new Columns() { Name = "Text4", Value = RandomString(8) });
                bodyRow.CreateColumns(new Columns() { Name = "Number4", Value = RandomInteger() });
                bodyRow.CreateColumns(new Columns() { Name = "Number5", Value = RandomInteger() });
                this._gridOptions.CreateBodyRow(bodyRow);
            }
        }

        public void GenerateFooter()
        {
            var footerRow = new GridDataRow();
            footerRow.CreateColumns(new Columns() { Value = "Total", Name = "No", MergeColNumber = 2 });
            footerRow.CreateColumns(new Columns() { Value = "Footer 3", Name = "Number1", TDClass = "demo-class", CustomExcelCellStyleIndex = 0 });
            footerRow.CreateColumns(new Columns() { Value = "Footer 4", Name = "Number2", MergeRowNumber = 2 });
            footerRow.CreateColumns(new Columns() { Value = "Footer 5", Name = "Number3", MergeRowNumber = 2 });
            footerRow.CreateColumns(new Columns() { Value = "Footer Merge 6", Name = "Text2", MergeColNumber = 3, CellAlignment = HAlignment.Center });
            footerRow.CreateColumns(new Columns() { Value = "Footer 9", Name = "Number4" });
            footerRow.CreateColumns(new Columns() { Value = "Footer 10", Name = "Number5" });
            GenerateSubFooterRows(footerRow);
            this._gridOptions.CreateFooterRow(footerRow);

            footerRow = new GridDataRow();
            footerRow.CreateColumns(new Columns() { Value = "Total 2", Name = "No", MergeColNumber = 3 });
            footerRow.CreateColumns(new Columns() { Value = "Footer 6 Verrrrrrry loooooog texxxxxxxt", Name = "Text2" });
            footerRow.CreateColumns(new Columns() { Value = "Footer 7", Name = "Text3" });
            footerRow.CreateColumns(new Columns() { Value = "Footer 8", Name = "Text4", TDClass = "demo-class", CustomExcelCellStyleIndex = 0 });
            footerRow.CreateColumns(new Columns() { Value = "Footer Merge 9", Name = "Number4", MergeColNumber = 2 });
            GenerateSubFooterRows(footerRow);
            this._gridOptions.CreateFooterRow(footerRow);
        }

        public void GenerateSubFooterRows(GridDataRow footerRow)
        {
            for (int i = 0; i < 3; i++)
            {
                var subFooterRow = new GridDataRow();
                subFooterRow.CreateColumns(new Columns() { Name = "No", Value = i });
                subFooterRow.CreateColumns(new Columns() { Name = "Text1", Value = RandomString(5), CustomExcelCellStyleIndex = 0 });
                subFooterRow.CreateColumns(new Columns() { Name = "Number1", Value = RandomDouble() });
                subFooterRow.CreateColumns(new Columns() { Name = "Number2", Value = RandomInteger() });
                subFooterRow.CreateColumns(new Columns() { Name = "Number3", Value = RandomDouble() });
                subFooterRow.CreateColumns(new Columns() { Name = "Text2", Value = RandomString(6), CustomExcelCellStyleIndex = 0 });
                subFooterRow.CreateColumns(new Columns() { Name = "Text3", Value = RandomString(7) });
                subFooterRow.CreateColumns(new Columns() { Name = "Text4", Value = RandomString(8) });
                subFooterRow.CreateColumns(new Columns() { Name = "Number4", Value = RandomInteger(), CustomExcelCellStyleIndex = 0 });
                subFooterRow.CreateColumns(new Columns() { Name = "Number5", Value = RandomInteger() });
                footerRow.CreateSubRows(subFooterRow);
            }

        }

        public void RegisterCustomCellStyle()
        {
            this._gridOptions.CustomExcelCellStyles = new List<CustomExcelCellStyle>() {
                new CustomExcelCellStyle() {
                    BackgroundColor = HSSFColor.Red.Index,
                    Font = new CustomExcelFont() {
                        ForegroundColor = HSSFColor.Yellow.Index,
                        IsBold = true
                    }
                }
            };
        }
    }
}