// -----------------------------------------------------------------------
// <copyright file="HeaderColumns.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Models
{
    using System;
    using Fanex.Excel.Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// Header Columns.
    /// </summary>
    [Serializable]
    public class HeaderColumns : Columns, IHeaderColumns
    {
        public HeaderColumns(bool isGroupHeader = false)
            : base(0)
        {
            this.Width = isGroupHeader ? 0 : 150;
            this.HeaderAlign = "center";
            this.CellAlignment = HAlignment.Null;
            this.THCssClass = string.Empty;
            this.IsBold = false;
            this.Sort = false;
        }

        public HeaderColumns(string headerText, string name, int width, HAlignment cellAlignment)
            : this()
        {
            this.HeaderText = headerText;
            this.Name = name;
            this.Width = width;
            this.CellAlignment = cellAlignment;
        }

        public HeaderColumns(
            string headerText,
            string name,
            int width,
            HAlignment cellAlignment,
            string headerAlign,
            ExcelCellType customCellType = ExcelCellType.Double)
            : this()
        {
            this.HeaderText = headerText;
            this.Name = name;
            this.Width = width;
            this.CellAlignment = cellAlignment;
            this.HeaderAlign = headerAlign;
            this.CustomCellType = customCellType;
        }

        [JsonIgnore]
        public GridOptions GridOptions { get; set; }

        [JsonIgnore]
        public GroupHeaderRows GroupHeaderRow { get; set; }

        public string HeaderText { get; set; }

        public int Width { get; set; }

        [JsonIgnore]
        public int WidthExcel
        {
            get
            {
                return this.Width / 6 * 255;
            }
        }

        public string HeaderAlign { get; set; }

        public string FormatNumber
        {
            get
            {
                switch (this.CustomCellType)
                {
                    case Enums.ExcelCellType.Integer:
                    case Enums.ExcelCellType.IntegerRedPositive:
                    case Enums.ExcelCellType.IntegerRedNegative:
                    case Enums.ExcelCellType.IntegerRedparenthesisNegative:
                        return "0,0";
                    case Enums.ExcelCellType.Double:
                    case Enums.ExcelCellType.DoubleRedPositive:
                    case Enums.ExcelCellType.DoubleRedPositiveNoteInformation:
                    case Enums.ExcelCellType.DoubleRedNegative:
                    case Enums.ExcelCellType.DoubleRedParenthesisNegative:
                        return "0,0.00";
                    case Enums.ExcelCellType.Percentage:
                    case Enums.ExcelCellType.PercentageRedPositive:
                    case Enums.ExcelCellType.PercentageRedNegative:
                    case Enums.ExcelCellType.PercentageRedparenthesisNegative:
                        return "0,0.00%";
                    default:
                        return string.Empty;
                }
            }
        }

        public string FormatNegative
        {
            get
            {
                switch (this.CustomCellType)
                {
                    case Enums.ExcelCellType.IntegerRedNegative:
                    case Enums.ExcelCellType.IntegerRedparenthesisNegative:
                    case Enums.ExcelCellType.PercentageRedNegative:
                    case Enums.ExcelCellType.DoubleRedNegative:
                        return "$";
                    case Enums.ExcelCellType.DoubleRedParenthesisNegative:
                    case Enums.ExcelCellType.PercentageRedparenthesisNegative:
                        return "($)";
                    default:
                        return string.Empty;
                }
            }
        }

        public string FormatPositive
        {
            get
            {
                switch (this.CustomCellType)
                {
                    case Enums.ExcelCellType.IntegerRedPositive:
                    case Enums.ExcelCellType.DoubleRedPositive:
                    case Enums.ExcelCellType.DoubleRedPositiveNoteInformation:
                    case Enums.ExcelCellType.PercentageRedPositive:
                        return "$";
                    default:
                        return string.Empty;
                }
            }
        }

        public string FormatDateTime
        {
            get
            {
                switch (this.CustomCellType)
                {
                    case Enums.ExcelCellType.DateTimeMMDDYYYY:
                        return "MM/dd/yyyy";
                    default:
                        return string.Empty;
                }
            }
        }

        public bool IsAbs
        {
            get
            {
                switch (this.CustomCellType)
                {
                    case Enums.ExcelCellType.IntegerRedparenthesisNegative:
                    case Enums.ExcelCellType.DoubleRedParenthesisNegative:
                    case Enums.ExcelCellType.PercentageRedparenthesisNegative:
                        return true;
                    default:
                        return false;
                }
            }
        }

        [JsonIgnore]
        public bool IsBold { get; set; }

        public string THCssClass { get; set; }

        [JsonIgnore]
        public bool IsMergedColumn { get; set; }

        public bool Sort { get; set; }

        public string SortDirection { get; set; }

        public string SortType { get; set; }

        public bool ShouldSerializeFormatNumber()
        {
            return this.FormatNumber != null && !string.IsNullOrEmpty(this.FormatNumber);
        }

        public bool ShouldSerializeFormatNegative()
        {
            return this.FormatNegative != null && !string.IsNullOrEmpty(this.FormatNegative);
        }

        public bool ShouldSerializeFormatPositive()
        {
            return this.FormatPositive != null && !string.IsNullOrEmpty(this.FormatPositive);
        }

        public bool ShouldSerializeFormatDateTime()
        {
            return this.FormatDateTime != null && !string.IsNullOrEmpty(this.FormatDateTime);
        }

        public bool ShouldSerializeTHCssClass()
        {
            return this.THCssClass != null && !string.IsNullOrEmpty(this.THCssClass);
        }

        public bool ShouldSerializeWidth()
        {
            return this.Width > 0;
        }

        public bool ShouldSerializeSort()
        {
            return this.Sort;
        }

        public bool ShouldSerializeSortDirection()
        {
            return !string.IsNullOrEmpty(this.SortDirection);
        }

        public bool ShouldSerializeSortType()
        {
            return !string.IsNullOrEmpty(this.SortType);
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Header Columns object.</returns>
        public new HeaderColumns Clone()
        {
            var clone = (HeaderColumns)base.Clone();
            clone.HeaderText = this.HeaderText;
            clone.DisplayValue = this.DisplayValue;
            clone.Width = this.Width;
            clone.HeaderAlign = this.HeaderAlign;
            clone.IsBold = this.IsBold;
            clone.THCssClass = this.THCssClass;
            clone.IsMergedColumn = this.IsMergedColumn;
            clone.Sort = this.Sort;
            clone.SortDirection = this.SortDirection;
            clone.SortType = this.SortType;
            return clone;
        }
    }
}
