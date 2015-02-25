/* jshint ignore:start */
/* File Created: November 12, 2012 */
$(document).ready(function () {
    Common.initialize();
});

var FormatConstant = {
    INT_NUMBER: '0,0',
    TWO_DECIMAL_NUMBER: '0,0.00',
    FOUR_DECIMAL_NUMBER: '0,0.0000',
    TWO_DECIMAL_PERCENT_NUMBER: '0,0.00%',
    MMM_DD_YYYY_STRING: 'MMM DD, YYYY',
    M_DD_YY_STRING: 'M dd, yy',
    MM_DD_YYYY_WITH_SLASH_STRING: 'MM/dd/yyyy',
    MMM_YY_STRING: 'MMM YY',
    MMM_YY_STRING_MONTH_PICKER: 'MMM yyyy',
    MMM_DD_YY_STRING_MONTH_PICKER: 'MMM dd, yyyy',
    MM_DD_YYYY_WITH_SLASH_STRING_MOMENT: 'M/D/YYYY',
    MMM_DD_YYYY_STRING_MOMENT: 'MMM D, YYYY',
    MMM_DD_YYYY_H_M_STRING: 'MMM DD, YYYY HH:mm',
    MMM_DD_YYYY_H_M_S_A_STRING: 'MMMM DD, YYYY h:mm:ss A'
};

var Common = function ($) {
    var MessageType = {
        Success: 1,
        Warning: 2,
        Error: 3,
        Notification: 4
    };

    var SortDirection = {
        Desc: 'DESC',
        Asc: 'ASC',
        None: ''
    };

    return {
        disableInput: function () {
            try { $.blockUI(); } catch (e) { }
        },
        enableInput: function () {
            try { $.unblockUI(); } catch (e) { }
        },
        rootUrl: null,
        initialize: function () {
            Common.rootUrl = window.rootUrl;
        },
        downloadFile: function (url) {
            var downloadUrl = url;
            var iframe = $('body iframe');
            if (iframe.length == 0) {
                iframe = $('<iframe width="0" height="0" class="display-none"></iframe>');
                iframe.appendTo('body');
            }

            iframe.attr('src', downloadUrl);
        },
        utility: {
            StringFormat: function (strValue, paramArr) {
                var len = paramArr.length;
                for (var i = 0; i < len; i++) {
                    var paramInfo = paramArr[i];
                    var formatIndex = '{' + i + '}';
                    while (strValue.indexOf(formatIndex) != -1) {
                        strValue = strValue.replace(formatIndex, paramInfo);
                    }
                }

                return strValue;
            },

            CallAjax: function (reportHandler,
                url,
                requestParams,
                successFunction,
                errorFunction,
                completeFunction,
                isKeepingMessage) {
                $.ajax({
                    type: "POST",
                    url: url,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: requestParams ? JSON.stringify(requestParams) : null,
                    beforeSend: function () {
                    },
                    success: function (rs) {
                        if (!isKeepingMessage) {
                            AccReport.popUp.hide();
                        }

                        if (successFunction && typeof (successFunction) == 'function') {
                            successFunction.call(reportHandler, rs);
                        }
                    },
                    error: function (jqXHR, event, ajaxSettings) {
                        if (jqXHR.status &&
                            jqXHR.status == AccReportData.Constants.HtmlErrorCode.SystemError) {
                            var r = jQuery.parseJSON(jqXHR.responseText);
                            AccReport.popUp.show(r.message);
                        }

                        if (errorFunction && typeof (errorFunction) == 'function') {
                            errorFunction.call(reportHandler);
                        }
                    },
                    complete: function () {
                        if (completeFunction && typeof (completeFunction) == 'function') {
                            completeFunction();
                        }
                    }
                });
            }
        }
    };
} (jQuery);