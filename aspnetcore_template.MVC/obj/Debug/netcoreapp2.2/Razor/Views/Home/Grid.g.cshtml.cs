#pragma checksum "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db13c9bd1f08e2ad8606170a567c6e4d1d2d258"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db13c9bd1f08e2ad8606170a567c6e4d1d2d258", @"/Views/Home/Grid.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4db13c9bd1f08e2ad8606170a567c6e4d1d2d2586261", async() => {
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
            BeginContext(2979, 11573, true);
            WriteLiteral(@"
                        </div>
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

                                {
                                    extend: 'excelHtml5',
            ");
            WriteLiteral(@"                        ""text"": 'Excel <span class=""glyphicon glyphicon-download-alt""></span>',
                                    ""className"": 'btn btn-info btn-sm',
                                    title: ""BRAIDSS_Config_Maint_ "" + excelfilename,
                                    init: function (dt, node, config) {
                                        config.title = ""BRAIDSS_Config_Maint_"" + excelfilename;
                                    }
                                }
                            ],
                            ""filterOptions"": {
                                searchButton: ""Search"",
                                clearSearchButton: ""ClearSearch"",
                                searchContainer: ""SearchContainer""
                            },
                            ""serverSide"": true,
                            ""ajax"": {
                                ""url"": ""/home/AjaxRestaurants"",
                                ""type"": ""POST"",
                  ");
            WriteLiteral(@"              data: function (d) {
                                    d.cuisine = $('#CuisineType').val();;
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
                                        'className': 'select-checkbox'
                                    }
                                },
                                {
                                    'targets': 1,
                ");
            WriteLiteral(@"                    'visible': true,
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
                            //},
                        });

                        table.search('').columns().search('').draw();

                        $(document).contextmenu({
                            delegate: "".dataTable tr"",
 ");
            WriteLiteral(@"                           menu: [
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-remove' style='color: orange'></i> Cancel Row Update"", cmd: ""remove"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-remove-sign' style='color: orange'></i> Cancel All Rows Update"", cmd: ""removeall"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-floppy-disk glyphicon-margin' style='color: green'></i> Update Selected Rows"", cmd: ""update"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-trash glyphicon-margin' style='color: red'></i> Delete Selected Rows"", cmd: ""delete"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-plus glyphicon-margin' style='color: blue'></i> Create New Row"", cmd: ""add"" },
                                { title: ""<i class='glyphicon-margin glyphicon glyphicon-floppy-disk glyphicon-margin'");
            WriteLiteral(@" style='color: blue'></i> ...Save New Row"", cmd: ""addupdate"" },
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
                                        CancelAllRowsEdit(row);
                                        break;
                                    case ""update"":
                                        UpdateRows(row);
                                        break;
                                    case ""add"":
                                        AddRow(row);
                                        brea");
            WriteLiteral(@"k;
                                    case ""addupdate"":
                                        AddUpdateRow(row);
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
                                ui.menu.zIndex(9999);
                            }
                        });
                        table.MakeCellsEditable({
                        //dataTables cellEdit
                        ""columns"": [1,2]
                        }),
                            $(""body"")
                                .tooltip({
                     ");
            WriteLiteral(@"               selector: '[data-toggle=""tooltip""]',
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
                        var row = $(e).closest('tr');
                        var form = $('#table-form').closest('form');
                        if (form.valid()) {
                            Upd");
            WriteLiteral(@"ateSelectedRows(row);
                        }
                    }

                    $(document)
                        .on('click',
                            '#btnQuery',
                            function (e) {
                                e.preventDefault();
                                var id = this.id;
                                table.ajax.reload();

                            });
                    // Click event to put row into edit mode - minus action column
    $('#restaurant-table tbody').on('dblclick', 'td', function () {
        try {
            console.log('edit click');
                settingsEditColumns = $(this).GetSettingsColumns();
                // check for existing edit row controls, only showedit controls if these don't already exist
                var $row = table.row($(this).parent('tr')).nodes().to$(),
                    currentInput = $row.find('td:eq(settingsEditColumns[0]) input').length;
                //console.log(""currentinput:");
            WriteLiteral(@" "" + currentInput);
                if (settingsEditColumns.contains(table.cell(this).index().columnVisible) && currentInput == 0) {
                    var rowId = table.row(this).data().Id;
                    var index = $.inArray(rowId, selected);
                    if (index === -1) {
                        selected.push(rowId);
                    } else {
                        selected.splice(index, 1);
                    }
                    $(this).ShowEditRow($(this).parent('tr'));
                    $(this).parent('tr').addClass('selected');
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
   ");
            WriteLiteral(@"             if (selectedRestaurants.length == 0)
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
                BootstrapDialog.show({
                    size: BootstrapDialog.SIZE_SMALL,
                    //closable: false,
                    type: BootstrapDialog.TYPE_DANGER,
                    title: ""Save Confirmation"",
                    message: ""Are you sure you wish to update ALL of the selected Rows?"",
                    buttons: [{
                            label: ""Confirm"",
                            cssClass: 'btn-primary',");
            WriteLiteral(@"
                            action: function (dialog) {
                                dialog.close();
                                //$(this).updateEditableCells(e);
                                $.ajax({
                                    type: 'POST',
                                    url: '");
            EndContext();
            BeginContext(14553, 40, false);
#line 281 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Home\Grid.cshtml"
                                     Write(Url.Action("UpdateSelectedRows", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(14593, 1863, true);
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
 </script>
");
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
