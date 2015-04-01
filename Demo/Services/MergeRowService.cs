using Fanex.Excel.Models;
using Fanex.Excel.Enums;
namespace Demo.Services
{
    public class MergeRowService : BaseServices
    {
        private GridOptions _gridOptions;

        public MergeRowService()
        {
            this._gridOptions = new GridOptions();
        }

        public GridOptions GenerateData()
        {
            this.GenerateHeader();
            this.GenerateBody();
            return this._gridOptions;
        }

        private void GenerateHeader()
        {
            this._gridOptions.CustomizeHeader = true;
            this._gridOptions.TitleInfoText = "Title";
            this._gridOptions.ShowTitle = true;
            this._gridOptions.TitleType = TitleType.Normal;
            var groupHeaderRow = new GroupHeaderRows();
            groupHeaderRow.CreateGroupHeaderColumn(new HeaderColumns() { Name = "Col1", HeaderText = "Group Header 1", MergeColNumber = 2, MergeRowNumber = 3 });
            groupHeaderRow.CreateGroupHeaderColumn(new HeaderColumns() { Name = "Col3", HeaderText = "Group Header 2", MergeRowNumber = 2 });
            groupHeaderRow.CreateGroupHeaderColumn(new HeaderColumns() { Name = "Col3", HeaderText = "Group Header 3", MergeColNumber = 7, MergeRowNumber = 2 });
            this._gridOptions.CreateGroupHeaderRow(groupHeaderRow);

            groupHeaderRow = new GroupHeaderRows();
            groupHeaderRow.CreateGroupHeaderColumn(new HeaderColumns() { Name = "Col3", HeaderText = "Group Header 2" });
            this._gridOptions.CreateGroupHeaderRow(groupHeaderRow);

            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col1", HeaderText = "Header Column 1" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col2", HeaderText = "Header Column 2", CellAlignment = HAlignment.Center });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col3", HeaderText = "Header Column 3", CellAlignment = HAlignment.Left });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col4", HeaderText = "Header Column 4", CellAlignment = HAlignment.Center });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col5", HeaderText = "Header Column 5", CustomCellType = ExcelCellType.Double });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col6", HeaderText = "Header Column 6" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col7", HeaderText = "Header Column 7" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col8", HeaderText = "Header Column 8" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col9", HeaderText = "Header Column 9" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col10", HeaderText = "Header Column 10" });
        }

        private void GenerateBody()
        {
            for (int i = 0; i < 6; i++)
            {
                var bodyRow = new GridDataRow();
                bodyRow.CreateColumns(new Columns() { Name = "Col1", Value = i });
                bodyRow.CreateColumns(new Columns() { Name = "Col2", Value = RandomString() });
                if (i % 3 == 0)
                {
                    bodyRow.CreateColumns(new Columns() { Name = "Col3", Value = RandomDateTime(), MergeRowNumber = 3 });
                }

                bodyRow.CreateColumns(new Columns() { Name = "Col4", Value = RandomInteger(), CellAlignment = i == 2 ? HAlignment.Left : HAlignment.Right, CustomCellType = i == 2 ? ExcelCellType.DoubleRedParenthesisNegative : ExcelCellType.Double });
                bodyRow.CreateColumns(new Columns() { Name = "Col5", Value = RandomDouble(-999999, 999999) });
                bodyRow.CreateColumns(new Columns() { Name = "Col6", Value = RandomString() });
                bodyRow.CreateColumns(new Columns() { Name = "Col7", Value = RandomString() });
                bodyRow.CreateColumns(new Columns() { Name = "Col8", Value = RandomString() });
                bodyRow.CreateColumns(new Columns() { Name = "Col9", Value = RandomString() });
                bodyRow.CreateColumns(new Columns() { Name = "Col10", Value = RandomString() });
                this._gridOptions.CreateBodyRow(bodyRow);
            }
        }

    }
}