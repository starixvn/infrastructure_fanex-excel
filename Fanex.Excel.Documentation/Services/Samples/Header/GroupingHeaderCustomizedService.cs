namespace Fanex.Excel.Documentation.Services
{
    using Fanex.Excel.Models;
    using Fanex.Excel.Enums;
    using System.Collections.Generic;
    using NPOI.HSSF.Util;
    using NPOI.SS.UserModel;
    using Grid.Documentation.Services;
    public class GroupingHeaderCustomizedService : BaseServices, ISampleService
    {
        private GridOptions _gridOptions;

        public GroupingHeaderCustomizedService()
        {
            this._gridOptions = new GridOptions();
        }

        public GridOptions GenerateData()
        {
            this.GenerateHeader();
            this.GenerateBody();
            this._gridOptions.ShowDistinctRow = false;
            return this._gridOptions;
        }

        private void GenerateHeader()
        {
            this.RegisterCustomCell();
            this.GenerateGroupHeaderRows();
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 1", Width = 60, Name = "No", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Center });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 2", Width = 100, Name = "Text1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 3", Width = 100, Name = "Number1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 4", Width = 100, Name = "Number2", MergeHeaderColNumber = 2 });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 5", Width = 100, Name = "Number3", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 6", Width = 110, Name = "Text2", MergeHeaderColNumber = 3, ThClass="demo-class", CustomExcelCellStyleIndex = 0 });
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

        private void GenerateGroupHeaderRows()
        {
            this._gridOptions.CustomizeHeader = true;
            var groupHeader = new GroupHeaderRows()
            {
                Columns = new List<HeaderColumns>() {
                    new HeaderColumns() {
                        HeaderText = "Group Header 1", Name="No", MergeColNumber = 2, ThClass = "demo-class", CustomExcelCellStyleIndex = 0
                    },
                    new HeaderColumns() {
                        HeaderText = "Header 3", Name="Number1", MergeRowNumber = 2, ThClass = "demo-class", CustomExcelCellStyleIndex = 0
                    },
                    new HeaderColumns() {
                        HeaderText = "Header 4", Name="Number2", MergeColNumber = 2
                    },
                    new HeaderColumns() {
                        HeaderText = "Group Header 2", Name="Text2", MergeColNumber = 3
                    },
                    new HeaderColumns() {
                        HeaderText = "Header 10", Name="Number4", MergeRowNumber = 2
                    },
                    new HeaderColumns() {
                        HeaderText = "Header 10", Name="Number5", MergeRowNumber = 2
                    }
                }
            };
            this._gridOptions.CreateGroupHeaderRow(groupHeader);
        }

        private void RegisterCustomCell()
        {
            this._gridOptions.CustomExcelCellStyles = new List<CustomExcelCellStyle>() {
                new CustomExcelCellStyle() {
                    BackgroundColor = HSSFColor.Red.Index,
                    Font = new CustomExcelFont() {
                        FontName = "Tahoma",
                        ForegroundColor = HSSFColor.Yellow.Index,
                        IsBold = true
                    },
                    HAlign = HorizontalAlignment.Center
                }
            };
        }
    }
}