// -----------------------------------------------------------------------
// <copyright file="GridOptions.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Models
{
    using System;
    using System.Collections.Generic;
    using Fanex.Excel.Constants;
    using Fanex.Excel.Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [Serializable]
    public class GridOptions
    {
        public GridOptions()
        {
            this.GroupHeaderRows = new List<GroupHeaderRows>();
            this.Columns = new List<HeaderColumns>();
            this.BodyRows = new List<GridDataRow>();
            this.FooterRows = new List<GridDataRow>();
            this.ShowDistinctRow = true;
            this.ShowHighlightRow = true;
            this.TitleSeperatorRowNum = 1;
            this.NoDataText = ExcelConstants.ThereIsNoData;
            this.ShowPager = false;
            this.CustomPager = false;
            this.ShowFooterLineBreak = true;
        }

        [JsonProperty("groupHeaderRows")]
        public List<GroupHeaderRows> GroupHeaderRows { get; set; }

        [JsonProperty("columns")]
        public List<HeaderColumns> Columns { get; set; }

        [JsonProperty("bodyRows")]
        public List<GridDataRow> BodyRows { get; set; }

        [JsonProperty("footerRows")]
        public List<GridDataRow> FooterRows { get; set; }

        [JsonProperty("showTitle")]
        public bool ShowTitle { get; set; }

        public string TitleInfoText { get; set; }

        [JsonProperty("showFooter")]
        public bool ShowFooter { get; set; }

        [JsonProperty("noDataText")]
        public string NoDataText { get; set; }

        [JsonProperty("showDistinctRow")]
        public bool ShowDistinctRow { get; set; }

        [JsonProperty("showHighlightRow")]
        public bool ShowHighlightRow { get; set; }

        [JsonProperty("customizeHeader")]
        public bool CustomizeHeader { get; set; }

        [JsonProperty("numberOfFrozenColumn")]
        public int NumberOfFrozenColumn { get; set; }

        [JsonIgnore]
        public TitleType TitleType { get; set; }

        [JsonProperty("pagerOption")]
        public PagerOption PagerOption { get; set; }

        [JsonProperty("showPager")]
        public bool ShowPager { get; set; }

        [JsonProperty("customPager")]
        public bool CustomPager { get; set; }

        [JsonIgnore]
        public int TitleSeperatorRowNum { get; set; }

        [JsonIgnore]
        public bool ShowFooterLineBreak { get; set; }

        public bool ShouldSerializePagerOption()
        {
            return this.ShowPager && this.CustomPager;
        }

        public bool ShouldSerializeGroupHeaderRows()
        {
            return this.CustomizeHeader;
        }

        public string GetCellAlign(int cellIndex)
        {
            return this.Columns[cellIndex].CellAlign;
        }

        public void CreateGroupHeaderRow(GroupHeaderRows groupHeaderRow)
        {
            groupHeaderRow.GridOptions = this;
            this.GroupHeaderRows.Add(groupHeaderRow);
        }

        public void CreateColumns(HeaderColumns headerColumn)
        {
            headerColumn.GridOptions = this;
            this.Columns.Add(headerColumn);
        }

        public void CreateBodyRow(GridDataRow bodyRow)
        {
            bodyRow.GridOptions = this;
            this.BodyRows.Add(bodyRow);
        }

        public void CreateFooterRow(GridDataRow footerRow)
        {
            footerRow.GridOptions = this;
            this.FooterRows.Add(footerRow);
        }

        /// <summary>
        /// Clones the specified is clone body.
        /// </summary>
        /// <param name="isCloneBody">If set to <c>true</c> [is clone body].</param>
        /// <returns>Grid Options object.</returns>
        public GridOptions Clone(bool isCloneBody = false)
        {
            GridOptions clone = new GridOptions();
            clone.ShowTitle = this.ShowTitle;
            clone.TitleInfoText = this.TitleInfoText;
            clone.ShowFooter = this.ShowFooter;
            clone.NoDataText = this.NoDataText;
            clone.ShowDistinctRow = this.ShowDistinctRow;
            clone.ShowHighlightRow = this.ShowHighlightRow;
            clone.CustomizeHeader = this.CustomizeHeader;
            clone.NumberOfFrozenColumn = this.NumberOfFrozenColumn;
            clone.TitleType = this.TitleType;
            clone.PagerOption = this.PagerOption.Clone();
            clone.ShowPager = this.ShowPager;
            clone.CustomPager = this.CustomPager;
            clone.TitleSeperatorRowNum = this.TitleSeperatorRowNum;

            int i = 0;
            int groupHeaderRowsCount = this.GroupHeaderRows.Count;
            int columnsCount = this.Columns.Count;
            int bodyRowsCount = this.BodyRows.Count;
            int footerRowsCount = this.FooterRows.Count;
            for (; i < groupHeaderRowsCount; i++)
            {
                clone.GroupHeaderRows.Add(this.GroupHeaderRows[i]);
            }

            for (i = 0; i < columnsCount; i++)
            {
                clone.Columns.Add(this.Columns[i]);
            }

            if (isCloneBody)
            {
                for (i = 0; i < bodyRowsCount; i++)
                {
                    clone.BodyRows.Add(this.BodyRows[i]);
                }
            }

            for (i = 0; i < footerRowsCount; i++)
            {
                clone.FooterRows.Add(this.FooterRows[i]);
            }

            return clone;
        }
    }
}
