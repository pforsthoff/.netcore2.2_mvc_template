
$(document).ajaxStart(function () {
    $('#ajaxBusy').show();
}).ajaxStop(function () {
    $('#ajaxBusy').hide();
});
addAntiForgeryToken = function (data) {
    data.__RequestVerificationToken = $("#__AjaxAntiForgeryForm input[name='__RequestVerificationToken']").val();
    return data;
};

//Global Variable for Notifications Editior
var $last_focused = null;

$(document).ready(function () {

    // Select the correct tab
    var url = window.location.pathname.toLowerCase();
    var index;
    if (window.location.href.indexOf("sbw70001736") > -1) {
        index = 3;
    } else {
        index = 2;
    };
    var path = url.split('/')[index];
    //console.log("path " + path);
    $("#sf-menu a").removeClass("selected");

    switch (path) {
    case 'schedule':
        $('#tab-schedule').addClass('selected');
        break;
    case 'view':
        $('#tab-schedule').addClass('selected');
        break;
    case 'workflow':
        $('#tab-workflow').addClass('selected');
        break;
    case 'requirements':
        $('#tab-req').addClass('selected');
        break;
    case 'site':
        $('#tab-site').addClass('selected');
        break;
    //case 'view':
    //    $('#tab-view').addClass('selected');
    //    break;
    case 'graphics':
        $('#tab-graphics').addClass('selected');
        break;
    case 'status':
        $('#tab-status').addClass('selected');
        break;
    case 'security':
        $('#tab-sec').addClass('selected');
        break;
    case 'pub':
        $('#tab-pub').addClass('selected');
        break;
    case 'so':
        $('#tab-pub').addClass('selected');
        break;
   case 'mso':
        $('#tab-pub').addClass('selected');
        break;       
    case 'shipping':
        $('#tab-shipping').addClass('selected');
        break;
    case 'ind dmd/iwa/spares':
        $('#tab-pd').addClass('selected');
        break;
    case 'home':
        $('#tab-hom').addClass('selected');
        break;
    case 'administration':
        $('#tab-adm').addClass('selected');
        break;
    case 'screens':
        $('#tab-scr').addClass('selected');
        break;
        
    default:
        $('#tab-home').addClass('selected');
        break;
    }

    $('#create-btn').button({
        icons: { primary: "ui-icon-circle-plus" }
    });

    // Button awesomeness
    $("button, a.button").button();
    //$(".buttonset").buttonset();

    // Make the tables look purdy
    //$("table tbody tr:odd").addClass("alternate");
    //$("table tbody tr").hover(
    //    function () {
    //        $(this).addClass("hover");
    //    },
    //    function () {
    //        $(this).removeClass("hover");
    //    }
    //);

    //TextArea Size Limit
    //This bit will prevent the user from typing in too many characters...
    $('textarea').keypress(function (e) {
        //TODO: error handling...
        var limit = parseInt($(this).attr('maxlength'));

        if (limit < 0)
            return true;

        var currentText = $(this).val();
        var chars = currentText.length;

        //too many charaters?
        //if ((e.keyCode != 8 && e.keyCode != 46 && e.keyCode != 37 && e.keyCode != 38 && e.keyCode != 39 && e.keyCode != 40)
        //    && (chars >= limit)) {
        //    e.preventDefault(); //cancel the key press
        //}
    });

    //This bit will prevent the user pasting in long strings...
    $('textarea').bind('paste', function () {
        //TODO: error checking
        var limit = parseInt($(this).attr('maxlength'));

        if (limit < 0)
            return true;

        var element = $(this);
        setTimeout(function () {
            var currentText = element.val();
            var chars = currentText.length;
            if (chars > limit) {
                //get the first 'n' characters
                var newText = currentText.substr(0, limit);
                //and replace the text.
                element.val(newText);
            }
        }, 10);
    });

});//End of JQuery Document Ready

//Array.prototype.unique = function () {
//    this.sort();
//    for (var i = 1; i < this.length; i++) {
//        if (this[i - 1] == this[i])
//            this.splice(i, 1);
//        else
//            i++;
//    }
//}

AddAntiForgeryToken = function (data) {
    data.__RequestVerificationToken = $("#__AjaxAntiForgeryForm input[name='__RequestVerificationToken']").val();
    return data;
};

function serviceFailed(result) {
    toastr.error('Service call failed: ' + result.status + '  ' + result.statusText);
}

function loadUserClasses() {
    $("#user-classes-datatable-section").load(app.baseUrl + "LeadershipAcademy/DataTable/GetUserClasses");
}

function destroyDataTable(selector) {
    if ($.fn.dataTable.isDataTable(selector)) {
        $(selector).hide();
        $(selector).dataTable().fnClearTable();
        $(selector).dataTable().fnDestroy();
    }
}

function toJavaScriptDate(value) {
    var pattern = /Date\(([^)]+)\)/;
    var results = pattern.exec(value);
    var dt = new Date(parseFloat(results[1]));
    return (dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear();
}

function updateProfileSupervisorCivilians(e) {
    $.ajax({
        type: "POST",
        data: AddAntiForgeryToken({ value: e }),
        url: app.baseUrl + "profile/update"
    }).done(function (result) {
        if (result.success) {
            toastr.success(result.Message, "Success");
        } else {
            toastr.error(result.Message, "Error");
        }
    });
}

function deleteListItem(e) {
    $.ajax({
        type: "POST",
        data: AddAntiForgeryToken({ value: e }),
        url: app.baseUrl + "admin/Lists/deleteItem"
    }).done(function (result) {
        if (result.success) {
            toastr.success(result.Message, "Success");
        } else {
            toastr.error(result.Message, "Error");
        }
    });
}
//these two functions allow using .contains on an array
function contains(a, obj) {
    var i = a.length;
    while (i--) {
        if (a[i] === obj) {
            return true;
        }
    }
    return false;
}
Array.prototype.contains = function (obj) {
    var i = this.length;
    while (i--) {
        if (this[i] === obj) {
            return true;
        }
    }
    return false;
}
//Convert Json Dates back to normal format
function dtConvFromJSON(data) {
    //do not remove null check!
    if (data == null) return null;
    //if (data == null) return '1/1/1950';
    var r = /\/Date\(([0-9]+)\)\//gi
    var matches = data.match(r);
   
   // if (matches == null) return '1/1/1950';
    if (typeof matches !== "undefined" && matches != null) {
        var result = matches.toString().substring(6, 19);
        var epochMilliseconds = result.replace(
            /^\/Date\(([0-9]+)([+-][0-9]{4})?\)\/$/,
            '$1');
        var b = new Date(parseInt(epochMilliseconds));
        var c = new Date(b.toString());
        var curr_date = c.getDate();
        var curr_month = c.getMonth() + 1;
        var curr_year = c.getFullYear();
        var curr_h = c.getHours();
        var curr_m = c.getMinutes();
        var curr_s = c.getSeconds();
        var curr_offset = c.getTimezoneOffset() / 60
        var d = curr_month.toString() + '/' + curr_date + '/' + curr_year;
        return d;
    }
    else {
        return data;
    }
}
var editDropdownUrl = '';