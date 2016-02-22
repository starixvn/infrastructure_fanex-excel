namespace Fanex.Excel.Documentation.Models
{
    using System.Collections.Generic;

    public class MenuItem
    {
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public string Url { get; set; }

        public string ViewName { get; set; }

        public List<MenuItem> SubMenus { get; set; }
    }
}