namespace Fanex.Excel.Documentation.Services
{
    using Fanex.Excel.Models;
    using Fanex.Excel.Enums;

    public class FrozenColumnService : BaseServices
    {
        private GridOptions _gridOptions;

        public FrozenColumnService()
        {
            this._gridOptions = new GridOptions();
        }

        public GridOptions GenerateData()
        {
            this.GenerateHeader();
            this.GenerateBody();
            this._gridOptions.NumberOfFrozenColumn = 3;
            this._gridOptions.FreezeHeader = true;
            return this._gridOptions;
        }

        private void GenerateHeader()
        {
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 1", Width = 60, Name = "No", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Center });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 2", Width = 100, Name = "Text1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 3", Width = 100, Name = "Number1", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
            this._gridOptions.CreateColumns(new HeaderColumns() { HeaderText = "Header 4", Width = 100, Name = "Number2", HeaderAlignment = HAlignment.Center, CellAlignment = HAlignment.Right });
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

    }
}