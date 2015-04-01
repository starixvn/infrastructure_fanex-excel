/* File Created: February 25, 2015 */

$(document).ready(function () {
    $('#ExportExcel').click(function () {
        Common.downloadFile(window.rootUrl + "MergeRow/ExportExcel");
    });
});