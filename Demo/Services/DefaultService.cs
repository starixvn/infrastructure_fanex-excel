using Fanex.Excel.Models;
namespace Demo.Services
{
    public class DefaultService : BaseServices
    {
        private GridOptions _gridOptions;

        public DefaultService()
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
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col1", HeaderText = "Header Column 1" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col2", HeaderText = "Header Column 2" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col3", HeaderText = "Header Column 3" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col4", HeaderText = "Header Column 4" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col5", HeaderText = "Header Column 5" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col6", HeaderText = "Header Column 6" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col7", HeaderText = "Header Column 7" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col8", HeaderText = "Header Column 8" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col9", HeaderText = "Header Column 9" });
            this._gridOptions.CreateColumns(new HeaderColumns() { Name = "Col10", HeaderText = "Header Column 10" });
        }

        private void GenerateBody()
        {
            for (int i = 0; i < 5; i++)
            {
                var bodyRow = new GridDataRow();
                for (int j = 0; j < 5; j++)
                {
                    var subRow = new GridDataRow();
                    subRow.CreateColumns(new Columns() { Name = "Col1", Value = j });
                    subRow.CreateColumns(new Columns() { Name = "Col2", Value = RandomString() });
                    subRow.CreateColumns(new Columns() { Name = "Col3", Value = RandomDateTime() });
                    subRow.CreateColumns(new Columns() { Name = "Col4", Value = RandomInteger() });
                    subRow.CreateColumns(new Columns() { Name = "Col5", Value = RandomDouble() });
                    subRow.CreateColumns(new Columns() { Name = "Col6", Value = RandomString() });
                    subRow.CreateColumns(new Columns() { Name = "Col7", Value = RandomString() });
                    subRow.CreateColumns(new Columns() { Name = "Col8", Value = RandomString() });
                    subRow.CreateColumns(new Columns() { Name = "Col9", Value = RandomString() });
                    subRow.CreateColumns(new Columns() { Name = "Col10", Value = RandomString() });
                    bodyRow.CreateSubRows(subRow);
                }

                this._gridOptions.CreateBodyRow(bodyRow);
            }
        }

    }
}