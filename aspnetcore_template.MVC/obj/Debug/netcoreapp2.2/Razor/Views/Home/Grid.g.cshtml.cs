#pragma checksum "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659c713d79da912310ef2e6f207959e9dbe81fb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Grid), @"mvc.1.0.view", @"/Views/Home/Grid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Grid.cshtml", typeof(AspNetCore.Views_Home_Grid))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
using aspnetcore_template.ViewModels;

#line default
#line hidden
#line 2 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
using aspnetcore_template.ServiceModel.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659c713d79da912310ef2e6f207959e9dbe81fb9", @"/Views/Home/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0d0a8222bf1d9bd71ff9c96fd1707d2fc9e42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aspnetcore_template.ViewModels.HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("table-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
  
    ViewBag.Title = "Home";


#line default
#line hidden
            BeginContext(238, 454, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-10 col-sm-offset-1"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading""><h2><span class=""label label-primary"">Restaurants</span></h2></div>
                <div class=""panel-body"">
                    <div class=""row"" style=""padding-left: 10px;"">
                        <div class=""form-inline"">
                            <div class=""form-group col-lg-1"">
");
            EndContext();
            BeginContext(815, 84, true);
            WriteLiteral("                                <div>\r\n                                    Cuisine\r\n");
            EndContext();
            BeginContext(1009, 139, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"form-group col-lg-4\">\r\n");
            EndContext();
            BeginContext(1277, 75, true);
            WriteLiteral("                                <div>\r\n                                    ");
            EndContext();
            BeginContext(1353, 196, false);
#line 28 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                               Write(Html.DropDownList("CuisineType",
                                    Html.GetEnumSelectList<CuisineType>(),
                                    "Select Cuisine", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 594, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group col-lg-2"">
                                <button id=""btnQuery"" type=""button"" class=""btn btn-info input-sm"">Query</button>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <hr />
                    </div>
                    <br />
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            ");
            EndContext();
            BeginContext(2143, 836, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "659c713d79da912310ef2e6f207959e9dbe81fb96261", async() => {
                BeginContext(2165, 256, true);
                WriteLiteral(@"
                                <table id=""restaurant-table"" class=""display select"" cellspacing=""0"" width=""100%"">
                                    <thead>
                                        <tr>
                                            <th>");
                EndContext();
                BeginContext(2422, 64, false);
#line 48 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                           Write(Html.Label("Id", "Id", new { @class = "dataTable-head-column" }));

#line default
#line hidden
                EndContext();
                BeginContext(2486, 55, true);
                WriteLiteral("</th>\r\n                                            <th>");
                EndContext();
                BeginContext(2542, 68, false);
#line 49 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                           Write(Html.Label("Name", "Name", new { @class = "dataTable-head-column" }));

#line default
#line hidden
                EndContext();
                BeginContext(2610, 55, true);
                WriteLiteral("</th>\r\n                                            <th>");
                EndContext();
                BeginContext(2666, 74, false);
#line 50 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                           Write(Html.Label("Cuisine", "Cuisine", new { @class = "dataTable-head-column" }));

#line default
#line hidden
                EndContext();
                BeginContext(2740, 232, true);
                WriteLiteral("</th>\r\n                                            <th>Actions</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                </table>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2979, 8139, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-sm-12"" id=""tableActions"">
                           
                        </div>
                    </div>
            </div>
        </div>
    </div>
                <script>
                    var dt = new Date();
                    var excelfilename = (dt.getMonth() + 1) + ""/"" + dt.getDate() + ""/"" + dt.getFullYear() + ""_"" + dt.getHours() + "":"" + dt.getMinutes() + "":"" + dt.getSeconds();
                    var table = null;
                    var selected = [];
                    loadTable();
                    function loadTable() {
                        table = $('#restaurant-table').DataTable({
                            ""processing"": true,
                            ""lengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]],
                            ""pageLength"": 10,
                            stateSave: true,
                            dom: 'lBfrtip',
                            buttons: [

  ");
            WriteLiteral(@"                              {
                                    extend: 'excelHtml5',
                                    ""text"": 'Excel <span class=""glyphicon glyphicon-download-alt""></span>',
                                    ""className"": 'btn btn-info btn-sm',
                                    title: ""Restaurants_ "" + excelfilename,
                                    exportOptions: {
                                    columns: ':visible'
                                    },
                                    init: function (dt, node, config) {
                                        config.title = ""Restaurants_"" + excelfilename;
                                    }
                                }
                            ],
                            ""filterOptions"": {
                                searchButton: ""Search"",
                                clearSearchButton: ""ClearSearch"",
                                searchContainer: ""SearchContainer""
               ");
            WriteLiteral(@"             },
                            ""serverSide"": true,
                            ""ajax"": {
                                ""url"": ""/home/AjaxRestaurants"",
                                ""type"": ""POST"",
                                data: function (d) {
                                    d.cuisineNumber = $('#CuisineType').val();;
                                }
                            },
                            ""columns"": [
                                { ""data"": ""id"" },
                                { ""data"": ""name"" },
                                { ""data"": ""cuisine"" },
                                { ""data"": ""actions"" }
                            ],
                            ""aoColumnDefs"": [
                                {
                                    'targets': 0,
                                    'checkboxes': {
                                        'selectRow': false,
                                        'orderable': false,
      ");
            WriteLiteral(@"                                  'className': 'select-checkbox'
                                    }
                                },
                                {
                                    'targets': 1,
                                    'visible': true,
                                    'orderable': true
                                },
                                // Actions column not orderable
                                {
                                    'targets': 2,
                                    'orderable': true
                                }
                            ],
                            'stateSaveParams': function (settings, data) {
                                data.columns.forEach(function (column) {
                                    delete column.visible;
                                });
                            },

                            //'select': {
                            //    'style': 'multi'
   ");
            WriteLiteral(@"                         //},
                        });

                        table.search('').columns().search('').draw();
                        //Place Excel button at bottom of grid
                        table.buttons().container().appendTo('#tableActions');
                        $(document).contextmenu({
                            delegate: "".dataTable tr"",
                            menu: [
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-remove' style='color: orange'></i> Cancel Row Update"", cmd: ""remove"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-remove-sign' style='color: orange'></i> Cancel All Rows Update"", cmd: ""removeall"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-floppy-disk glyphicon-margin' style='color: green'></i> Update Selected Rows"", cmd: ""update"" },
                                { title: ""<i class='glyphicon-margin glyphicon g");
            WriteLiteral(@"lyphicon-trash glyphicon-margin' style='color: red'></i> Delete Selected Rows"", cmd: ""delete"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-plus glyphicon-margin' style='color: blue'></i> Create New Row"", cmd: ""add"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-floppy-disk glyphicon-margin' style='color: blue'></i> ...Save New Row"", cmd: ""addupdate"" },
                            ],

                            selector: 'span.context-menu',
                            className: 'css-title',
                            select: function (event, ui) {
                                var row = ui.target.closest(""tr"")
                                switch (ui.cmd) {
                                    case ""remove"":
                                        CancelRowEdit(row);
                                        break;
                                    case ""removeall"":
                                 ");
            WriteLiteral(@"       CancelAllRowsEdit(row);
                                        break;
                                    case ""update"":
                                        UpdateRows(row);
                                        break;
                                    case ""add"":
                                        ShowAddRow(row);
                                        break;
                                    case ""addupdate"":
                                        SaveAddRow(row);
                                        break;
                                    case ""delete"":
                                        DeleteSelectedRows();
                                        break;
                                }
                            },
                            beforeOpen: function (event, ui) {
                                var $menu = ui.menu,
                                    $target = ui.target,
                                    extraData = ui.extraData;
 ");
            WriteLiteral(@"                               ui.menu.zIndex(9999);
                            }
                        });
                        table.MakeCellsEditable({
                        //dataTables cellEdit
                            ""columns"": [1, 2],
                            ""inputTypes"": [
                                {
                                ""name"": ""name"",
                                ""column"": 1, // NAME
                                ""css"": ""edittext"",  // edit text box width
                                ""maxLength"": 20, //prevent characters past
                                ""required"": true // required field validator
                               
                            },
                                {
                                ""name"": ""cuisine"",
                                ""column"": 2, // Cuisine
                                ""type"": ""list"",
                                ""url"": '");
            EndContext();
            BeginContext(11119, 37, false);
#line 204 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                   Write(Url.Action("editDropdownUrl", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(11156, 3049, true);
            WriteLiteral(@"'
                            }]
                        }),
                            $(""body"")
                                .tooltip({
                                    selector: '[data-toggle=""tooltip""]',
                                    container: 'body'
                                });
                        };

                    function CancelRowEdit(e) {
                        if ($('#newrow').length) {
                            $('#newrow').remove();
                        }
                        $(this).UnselectRow(e);
                    }
                    function CancelAllRowsEdit(e) {
                        $(this).UnselectAllRows($(e));
                    }

                    function ResetSort() {
                        localStorage.removeItem('DataTables_' + window.location.pathname);
                        table.order.neutral().draw();
                    }

                    function UpdateRows(e) {
                        var row =");
            WriteLiteral(@" $(e).closest('tr');
                        var form = $('#table-form').closest('form');
                        if (form.valid()) {
                            UpdateSelectedRows(row);
                        }
                    }

                    $(document).on('click', '#btnQuery',
                            function (e) {
                                e.preventDefault();
                                var id = this.id;
                                table.ajax.reload();

                        });
                    function ShowAddRow(e) {
                    //Check for existing new row
                    if (!$('#newrow').length)
                    {
                        $(this).ShowAddRow($(e));
                    }
                }
            $(document).on('click','#btnAdd',
            function(e) {
                e.preventDefault();
                if ($(""input[name=name]"").val() === '' ||
                    $(""#cuisine option:selected"").val() === '");
            WriteLiteral(@"') {
                    toastr.error(""Please ensure Name and Cuisine are complete."", ""Error"");
                    return;
                }
                 $newName = $(""input[name=name]"").val(),
                 $newCuisine = $(""#cuisine option:selected"").val();
                 BootstrapDialog.show({
                    size: BootstrapDialog.SIZE_SMALL,
                    //closable: false,
                    type: BootstrapDialog.TYPE_DEFAULT,
                    title: ""Add New Item Confirmation"",
                    message: ""Are you sure you wish to add a new Item?"",

                    buttons: [
                        {
                            label: ""Confirm"",
                            cssClass: 'btn-primary',
                            action: function(dialog) {
                                dialog.close();

                                $.ajax({
                                    type: 'POST',
                                    url: '");
            EndContext();
            BeginContext(14206, 38, false);
#line 277 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                     Write(Url.Action("AddNewRestaurant", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(14244, 3845, true);
            WriteLiteral(@"',
                    dataType: 'json',
                    traditional: true,
                    data: addAntiForgeryToken(
                        {
                            name: newName,
                            cuisine: $newCuisine
                        })

                }).done(function (result) {
                    if (result.success) {
                       toastr.success(result.message, ""Success"");
                    } else {
                        toastr.error(result.message, ""Error"");
                    }
                    $(""#restaurant-table"").DataTable().destroy();
                    loadTable();
                });
            }
        },
            {
                label: ""Cancel"",
                action: function (dialog) {
                    dialog.close();
                }
            }
        ]
    });
            });
    // Click event to put row into edit mode - minus action column
    $('#restaurant-table tbody').on('dblclick', 'td");
            WriteLiteral(@"', function () {
        try {
            console.log('edit click');
                settingsEditColumns = $(this).GetSettingsColumns();
                // check for existing edit row controls, only showedit controls if these don't already exist
                var $row = table.row($(this).parent('tr')).nodes().to$(),
                    currentInput = $row.find('td:eq(settingsEditColumns[0]) input').length;
                //console.log(""currentinput: "" + currentInput);
                if (settingsEditColumns.contains(table.cell(this).index().columnVisible) && currentInput == 0) {
                    var rowId = table.row(this).data().Id;
                    var index = $.inArray(rowId, selected);
                    if (index === -1) {
                        selected.push(rowId);
                    } else {
                        selected.splice(index, 1);
                    }
                    $(this).ShowEditRow($(this).parent('tr'));
                    $(this).parent('tr').addCla");
            WriteLiteral(@"ss('selected');
                    $.fn.DataTable.tables({ visible: true, api: true })
                        .columns.adjust()
                        .responsive.recalc();
                }
            }
        catch (e) {console.log('errors - ' + e);
            }
    });
            function UpdateSelectedRows(e) {
                //console.log(""update"");
                var selectedRestaurants = table.rows('.selected').data().toArray();
                if (selectedRestaurants.length == 0)
                {
                    toastr.error(""Updated data required"");
                    return;
                }
                $(this).updateEditableCells(e);
                // case validation
                //for (i = 0; i < selectedConfigs.length; i++) {
                //    selectedConfigs[i].CONFIG_NAME.toUpperCase();
                //    selectedConfigs[i].CONFIG_NAME_ABREV.toUpperCase();
                //    selectedConfigs[i].CUSTOMER.toUpperCase();
                //}
");
            WriteLiteral(@"                BootstrapDialog.show({
                    size: BootstrapDialog.SIZE_SMALL,
                    //closable: false,
                    type: BootstrapDialog.TYPE_DANGER,
                    title: ""Save Confirmation"",
                    message: ""Are you sure you wish to update ALL of the selected Rows?"",
                    buttons: [{
                            label: ""Confirm"",
                            cssClass: 'btn-primary',
                            action: function (dialog) {
                                dialog.close();
                                //$(this).updateEditableCells(e);
                                $.ajax({
                                    type: 'POST',
                                    url: '");
            EndContext();
            BeginContext(18090, 40, false);
#line 362 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                     Write(Url.Action("UpdateSelectedRows", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(18130, 3081, true);
            WriteLiteral(@"',
                                    dataType: 'json',
                                    traditional: true,
                                    data: { selectedRestaurants: JSON.stringify(selectedRestaurants) }

                                }).done(function (result) {
                                    console.log('message' + result.message)
                                    if (result.success) {
                                        toastr.success(result.message, ""Success"");
                                        $(""#restaurant-table"").DataTable().destroy();
                                        selected = [];
                                        loadTable();
                                        $(this).UnselectAllRows($(e));
                                    } else {
                                        toastr.error(result.message, ""Error"");
                                    }
                                });
                            }
                    ");
            WriteLiteral(@"    },
                        {
                            label: ""Cancel"",
                            action: function (dialog) {
                                //Remove editing controls
                                $.each(table.rows('.selected').indexes(), function (index, element) {
                                    var row = table.row(element).node();
                                    $(this).UnselectRow(e);
                                    //Remove class selected
                                    $(e).removeClass('selected');
                                    table.row(element).draw();
                                });
                                dialog.close();
                            }
                        }
                    ]
                });
                };
            function SaveAddRow(e) {
            var test = $(""input[name=cuisine]"").val();
            //console.log('input val: ' + test);
                var $row = $(e).closest('tr')");
            WriteLiteral(@",
                    $config = $(""input[name=name]""),
                    $configname = $(""#cuisine option:selected"");
            if (typeof $config.val() !== ""undefined"") {
                var newRow = {};
                newRow[""NAME""] = $config.val();
                newRow[""CUISINE""] = $configname.val();
                BootstrapDialog.show({
                    size: BootstrapDialog.SIZE_SMALL,
                    //closable: false,
                    type: BootstrapDialog.TYPE_DANGER,
                    title: ""Add Confirmation"",
                    message: ""Are you sure you wish to add a new row?"",

                    buttons: [
                        {
                            label: ""Confirm"",
                            cssClass: 'btn-primary',
                            action: function(dialog) {
                                dialog.close();
                                $.ajax({
                                    type: 'POST',
                                 ");
            WriteLiteral("   url: \'");
            EndContext();
            BeginContext(21212, 38, false);
#line 423 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                     Write(Url.Action("AddNewRestaurant", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(21250, 2441, true);
            WriteLiteral(@"',
                                    dataType: 'json',
                                    traditional: true,
                                    data: addAntiForgeryToken({ NewRow: JSON.stringify(newRow) })

                                }).done(function(result) {
                                    if (result.success) {
                                        toastr.success(result.message, ""Success"");
                                        $(""#restaurant-table"").DataTable().destroy();
                                        selected = [];
                                        loadTable();
                                    } else {
                                        toastr.error(result.message, ""Error"");
                                    }
                                });
                            }
                        },
                        {
                            label: ""Cancel"",
                            action: function(dialog) {

                ");
            WriteLiteral(@"                dialog.close();
                            }
                        }
                    ]
                });
            } else {
                toastr.error(""Select Create New Row First."", ""Error"");
            }
        };
        function DeleteSelectedRows() {
            table.column(0).checkboxes.selected.length = 0;
            var rows_selected = table.column(0).checkboxes.selected();
            if (rows_selected.length === 0) {
                toastr.error(""Please select at least one checkbox."", ""Error"");
                return;
            };
            var selected = [];
            // Iterate over all selected checkboxes
            $.each(rows_selected, function (index, rowId) {
                selected.push(rowId);
            });
            BootstrapDialog.show({
                size: BootstrapDialog.SIZE_SMALL,
                type: BootstrapDialog.TYPE_DANGER,
                title: ""Delete Confirmation"",
                message: ""Are you sure");
            WriteLiteral(@" you wish to delete ALL of the selected Items?"",
                buttons: [{
                        label: ""Confirm"",
                        cssClass: 'btn-primary',
                        action: function (dialog) {
                            dialog.close();
                            $.ajax({
                                type: 'POST',
                                url: '");
            EndContext();
            BeginContext(23692, 41, false);
#line 477 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                 Write(Url.Action("DeleteSelectedItems", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(23733, 1028, true);
            WriteLiteral(@"',
                                dataType: 'json',
                                traditional: true,
                                data: addAntiForgeryToken({ selectedItems: selected })

                            }).done(function (result) {
                                if (result.success) {
                                    toastr.success(result.message, ""Success"");
                                } else {
                                    toastr.error(result.message, ""Error"");
                                }
                                table.columns(0).checkboxes.deselectAll();
                                table.ajax.reload();
                            });
                        }
                    },
                    {
                        label: ""Cancel"",
                        action: function (dialog) {
                            dialog.close();
                        }
                    }
                ]
            });
        }
 </scrip");
            WriteLiteral("t>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aspnetcore_template.ViewModels.HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
