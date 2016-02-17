/* File Created: February 25, 2015 */

$(document).ready(function () {
    $('#ExportExcel').click(function () {
        Common.downloadFile(window.rootUrl + "Default/ExportExcel");
    });

    $('#Generate').click(function () {
        Common.utility.CallAjax(this,
            window.rootUrl + "Default/Generate",
            null,
            function (result) {
                $('#gridId').fanexGrid(result);
            },
            function (err) {
                alert(err);
            });
    });
});