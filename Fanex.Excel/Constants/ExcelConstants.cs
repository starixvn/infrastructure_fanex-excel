// -----------------------------------------------------------------------
// <copyright file="ExcelConstants.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Constants
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// Excel Constants.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed.")]
    public static class ExcelConstants
    {
        public const string General = "General";

        public const string Integer = "#,##0";

        public const string IntegerRedPositive = "[Red]#,##0;-#,##0;0";

        public const string IntegerRedNegative = "#,##0;[Red]-#,##0";

        public const string IntegerparenthesisNegative = "#,##0;(#,##0)";

        public const string IntegerRedparenthesisNegative = "#,##0;[Red](#,##0)";

        public const string Double = "#,##0.00";

        public const string DoubleRedPositive = "[Red]#,##0.00;-#,##0.00;0.00";

        public const string DoubleRedNegative = "#,##0.00;[Red]-#,##0.00";

        public const string DoubleParenthesisNegative = "#,##0.00;(#,##0.00)";

        public const string DoubleRedParenthesisNegative = "#,##0.00;[Red](#,##0.00)";

        public const string Percentage = "0.00%";

        public const string PercentageRedPositive = "[Red]#,##0.00%;-#,##0.00%;#,##0.00%";

        public const string PercentageRedNegative = "#,##0.00%;[Red]-#,##0.00%";

        public const string PercentageRedparenthesisNegative = "#,##0.00%;[Red](#,##0.00%)";

        public const string PercentageparenthesisNegative = "#,##0.00%;(#,##0.00%)";

        public const string DateTimemmddyyyy = "mm/dd/yyyy";

        public const string ThereIsNoData = "There is no data.";

        public static Color TitleBackgroundColor = Color.FromArgb(210, 178, 77);

        public static Color HeaderBackgroundColor = Color.FromArgb(60, 94, 165);

        public static Color FooterBackgroundColor = Color.FromArgb(244, 244, 190);

        public static Color EvenRowColor = Color.FromArgb(228, 242, 253);

        public static Color SubTotalRowColor = Color.FromArgb(194, 217, 236);

        public static Color ParentRowLevelOneColor = Color.FromArgb(194, 217, 236);

        public static Color ParentRowLevelTwoColor = Color.FromArgb(212, 237, 251);

        public static Color ParentRowLevelThreeColor = Color.FromArgb(235, 253, 255);

        public static Color ParentRowLevelFourColor = Color.FromArgb(204, 255, 255);

        public static Color ParentRowLevelFiveColor = Color.FromArgb(204, 255, 255);
    }
}