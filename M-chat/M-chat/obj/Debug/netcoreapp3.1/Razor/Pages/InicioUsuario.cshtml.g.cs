#pragma checksum "C:\Users\CASA\Documents\M-chat\M-chatProyecto4\M-chat\M-chat\Pages\InicioUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05cc322bc6905fc134b0b33e7cb4b82e805238f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(M_chat.Pages.Pages_InicioUsuario), @"mvc.1.0.razor-page", @"/Pages/InicioUsuario.cshtml")]
namespace M_chat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\CASA\Documents\M-chat\M-chatProyecto4\M-chat\M-chat\Pages\_ViewImports.cshtml"
using M_chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASA\Documents\M-chat\M-chatProyecto4\M-chat\M-chat\Pages\InicioUsuario.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cc322bc6905fc134b0b33e7cb4b82e805238f4", @"/Pages/InicioUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6984a4e3c8b039771a34024114ea8661c8f7fa0d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_InicioUsuario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("trigger-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\CASA\Documents\M-chat\M-chatProyecto4\M-chat\M-chat\Pages\InicioUsuario.cshtml"
  
    ViewData["Title"] = "InicioUsuario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bienvenido ");
#nullable restore
#line 8 "C:\Users\CASA\Documents\M-chat\M-chatProyecto4\M-chat\M-chat\Pages\InicioUsuario.cshtml"
          Write(HttpContext.Session.GetString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"text-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f45000", async() => {
                WriteLiteral("Cerrar Seción");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f46484", async() => {
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <title>Bootstrap Elegant Table Design</title>
        <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
        <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
        <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
        <style type=""text/css"">
            body {
                color: #566787;
                background: #f5f5f5;
                font-family: 'Roboto', sans-seri");
                WriteLiteral(@"f;
            }

            .table-wrapper {
                background: #fff;
                padding: 20px;
                margin: 30px 0;
                box-shadow: 0 1px 1px rgba(0,0,0,.05);
            }

            .table-title {
                font-size: 15px;
                padding-bottom: 10px;
                margin: 0 0 10px;
                min-height: 45px;
            }

                .table-title h2 {
                    margin: 5px 0 0;
                    font-size: 24px;
                }

                .table-title select {
                    border-color: #ddd;
                    border-width: 0 0 1px 0;
                    padding: 3px 10px 3px 5px;
                    margin: 0 5px;
                }

                .table-title .show-entries {
                    margin-top: 7px;
                }

            .search-box {
                position: relative;
                float: right;
            }

                .search-box .inp");
                WriteLiteral(@"ut-group {
                    min-width: 200px;
                    position: absolute;
                    right: 0;
                }

                .search-box .input-group-addon, .search-box input {
                    border-color: #ddd;
                    border-radius: 0;
                }

                .search-box .input-group-addon {
                    border: none;
                    border: none;
                    background: transparent;
                    position: absolute;
                    z-index: 9;
                }

                .search-box input {
                    height: 34px;
                    padding-left: 28px;
                    box-shadow: none !important;
                    border-width: 0 0 1px 0;
                }

                    .search-box input:focus {
                        border-color: #3FBAE4;
                    }

                .search-box i {
                    color: #a0a5b1;
                    font-size");
                WriteLiteral(@": 19px;
                    position: relative;
                    top: 2px;
                    left: -10px;
                }

            table.table tr th, table.table tr td {
                border-color: #e9e9e9;
            }

            table.table th i {
                font-size: 13px;
                margin: 0 5px;
                cursor: pointer;
            }

            table.table td:last-child {
                width: 130px;
            }

            table.table td a {
                color: #a0a5b1;
                display: inline-block;
                margin: 0 5px;
            }

                table.table td a.view {
                    color: #03A9F4;
                }

                table.table td a.edit {
                    color: #FFC107;
                }

                table.table td a.delete {
                    color: #E34724;
                }

            table.table td i {
                font-size: 19px;
            }

     ");
                WriteLiteral(@"       .pagination {
                float: right;
                margin: 0 0 5px;
            }

                .pagination li a {
                    border: none;
                    font-size: 13px;
                    min-width: 30px;
                    min-height: 30px;
                    padding: 0 10px;
                    color: #999;
                    margin: 0 2px;
                    line-height: 30px;
                    border-radius: 30px !important;
                    text-align: center;
                }

                    .pagination li a:hover {
                        color: #666;
                    }

                .pagination li.active a {
                    background: #03A9F4;
                }

                    .pagination li.active a:hover {
                        background: #0397d6;
                    }

                .pagination li.disabled i {
                    color: #ccc;
                }

                .pagination li i");
                WriteLiteral(@" {
                    font-size: 16px;
                    padding-top: 6px
                }

            .hint-text {
                float: left;
                margin-top: 10px;
                font-size: 13px;
            }
        </style>
        <script type=""text/javascript"">
            $(document).ready(function () {
                $('[data-toggle=""tooltip""]').tooltip();
                // Animate select box length
                var searchInput = $("".search-box input"");
                var inputGroup = $("".search-box .input-group"");
                var boxWidth = inputGroup.width();
                searchInput.focus(function () {
                    inputGroup.animate({
                        width: ""300""
                    });
                }).blur(function () {
                    inputGroup.animate({
                        width: boxWidth
                    });
                });
            });
        </script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f413779", async() => {
                WriteLiteral(@"
        <div class=""container"">
            <div class=""table-wrapper"">
                <div class=""table-title"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""show-entries"">
                                <span>Numero</span>
                                <select>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f414440", async() => {
                    WriteLiteral("5");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f415486", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f416533", async() => {
                    WriteLiteral("15");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05cc322bc6905fc134b0b33e7cb4b82e805238f417580", async() => {
                    WriteLiteral("20");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                                <span>Personas</span>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <h2 class=""text-center""><b>Registros de niño(s)</b></h2>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""search-box"">
                                <div class=""input-group"">
                                    <span class=""input-group-addon""><i class=""material-icons"">&#xE8B6;</i></span>
                                    <input type=""text"" class=""form-control"" placeholder=""Search&hellip;"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>#<");
                WriteLiteral(@"/th>
                            <th>Nombre <i class=""fa fa-sort""></i></th>
                            <th>Escuela</th>
                            <th>Fecha de Registro <i class=""fa fa-sort""></i></th>
                            <th>CURP</th>
                            <th>Nacionalidad <i class=""fa fa-sort""></i></th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Thomas Hardy</td>
                            <td>La Primavera</td>
                            <td>06-06-2020</td>
                            <td>97219</td>
                            <td>México</td>
                            <td>
                                <a href=""#"" class=""view"" title=""Ver"" data-toggle=""tooltip""><i class=""material-icons"">&#xE417;</i></a>
                                <a href=""#"" class=""edit"" title=""Contestar Encues");
                WriteLiteral(@"ta"" data-toggle=""tooltip""><i class=""material-icons"">&#xE254;</i></a>
                                <a href=""#"" class=""delete"" title=""Eliminar"" data-toggle=""tooltip""><i class=""material-icons"">&#xE872;</i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Maria Anders</td>
                            <td>Obere Str. 57</td>
                            <td>Berlin</td>
                            <td>12209</td>
                            <td>México</td>
                            <td>
                                <a href=""#"" class=""view"" title=""Ver"" data-toggle=""tooltip""><i class=""material-icons"">&#xE417;</i></a>
                                <a href=""#"" class=""edit"" title=""Contestar Encuesta"" data-toggle=""tooltip""><i class=""material-icons"">&#xE254;</i></a>
                                <a href=""#"" class=""delete"" title=""Eliminar"" data-toggle=""tooltip""><i class=""material-ico");
                WriteLiteral(@"ns"">&#xE872;</i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>Fran Wilson</td>
                            <td>C/ Araquil, 67</td>
                            <td>Madrid</td>
                            <td>28023</td>
                            <td>México</td>
                            <td>
                                <a href=""#"" class=""view"" title=""Ver"" data-toggle=""tooltip""><i class=""material-icons"">&#xE417;</i></a>
                                <a href=""#"" class=""edit"" title=""Contestar Encuesta"" data-toggle=""tooltip""><i class=""material-icons"">&#xE254;</i></a>
                                <a href=""#"" class=""delete"" title=""Eliminar"" data-toggle=""tooltip""><i class=""material-icons"">&#xE872;</i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>");
                WriteLiteral(@"Dominique Perrier</td>
                            <td>25, rue Lauriston</td>
                            <td>Paris</td>
                            <td>75016</td>
                            <td>México</td>
                            <td>
                                <a href=""#"" class=""view"" title=""Ver"" data-toggle=""tooltip""><i class=""material-icons"">&#xE417;</i></a>
                                <a href=""#"" class=""edit"" title=""Contestar Encuesta"" data-toggle=""tooltip""><i class=""material-icons"">&#xE254;</i></a>
                                <a href=""#"" class=""delete"" title=""Eliminar"" data-toggle=""tooltip""><i class=""material-icons"">&#xE872;</i></a>
                            </td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>Martin Blank</td>
                            <td>Via Monte Bianco 34</td>
                            <td>Turin</td>
                            <td>10100</td>
                 ");
                WriteLiteral(@"           <td>México</td>
                            <td>
                                <a href=""#"" class=""view"" title=""Ver"" data-toggle=""tooltip""><i class=""material-icons"">&#xE417;</i></a>
                                <a href=""#"" class=""edit"" title=""Contestar Encuesta"" data-toggle=""tooltip""><i class=""material-icons"">&#xE254;</i></a>
                                <a href=""#"" class=""delete"" title=""Eliminar"" data-toggle=""tooltip""><i class=""material-icons"">&#xE872;</i></a>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class=""clearfix"">
                    <div class=""hint-text"">Showing <b>5</b> out of <b>25</b> entries</div>
                    <ul class=""pagination"">
                        <li class=""page-item disabled""><a href=""#"">Previous</a></li>
                        <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                        <li class=""page-item""><a href=""#"" clas");
                WriteLiteral(@"s=""page-link"">2</a></li>
                        <li class=""page-item active""><a href=""#"" class=""page-link"">3</a></li>
                        <li class=""page-item""><a href=""#"" class=""page-link"">4</a></li>
                        <li class=""page-item""><a href=""#"" class=""page-link"">5</a></li>
                        <li class=""page-item""><a href=""#"" class=""page-link"">Next</a></li>
                    </ul>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<M_chat.Pages.InicioUsuarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<M_chat.Pages.InicioUsuarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<M_chat.Pages.InicioUsuarioModel>)PageContext?.ViewData;
        public M_chat.Pages.InicioUsuarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591