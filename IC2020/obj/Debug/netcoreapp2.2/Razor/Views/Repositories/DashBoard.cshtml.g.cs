#pragma checksum "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c2543db5e0c63b284fb11c8cae293a7b41c5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositories_DashBoard), @"mvc.1.0.view", @"/Views/Repositories/DashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Repositories/DashBoard.cshtml", typeof(AspNetCore.Views_Repositories_DashBoard))]
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
#line 1 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\_ViewImports.cshtml"
using IC2020;

#line default
#line hidden
#line 2 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\_ViewImports.cshtml"
using IC2020.Models;

#line default
#line hidden
#line 6 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c2543db5e0c63b284fb11c8cae293a7b41c5de", @"/Views/Repositories/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0cdb9692461173cc7dbac5cbca5fe6befa101e", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositories_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IC2020.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables-responsive/css/responsive.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/chart/Chart.PieceLabel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
  
    ViewBag.Title = "DashBoard";

#line default
#line hidden
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85c2543db5e0c63b284fb11c8cae293a7b41c5de5605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(201, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85c2543db5e0c63b284fb11c8cae293a7b41c5de6858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(297, 9, true);
            WriteLiteral("\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 306, "\"", 354, 1);
#line 10 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
WriteAttributeValue("", 312, Url.Content("~/Scripts/jquery-1.10.2.js"), 312, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(355, 42, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 397, "\"", 455, 1);
#line 11 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
WriteAttributeValue("", 403, Url.Content("~/Scripts/jquery.unobtrusive-ajax.js"), 403, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 37, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n");
            EndContext();
            BeginContext(493, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85c2543db5e0c63b284fb11c8cae293a7b41c5de9079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(567, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(952, 463, true);
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""info-box bg-danger"">
                    <span class=""info-box-icon""><i class=""far fa-flag""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">USUÁRIO/REPOSITÓRIO</span>
                        <span class=""info-box-text"" id=""valueDateC"">
");
            EndContext();
#line 38 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                             foreach (var item in Model)
                            {
                                

#line default
#line hidden
            BeginContext(1537, 22, false);
#line 40 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                           Write(item.url.Split('/')[4]);

#line default
#line hidden
            EndContext();
            BeginContext(1594, 22, false);
#line 41 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                           Write(item.url.Split('/')[5]);

#line default
#line hidden
            EndContext();
#line 41 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                                       
                                break;
                            }

#line default
#line hidden
            BeginContext(1689, 1201, true);
            WriteLiteral(@"                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">

                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            DESENVOLVEDORES DE CADA VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
              ");
            WriteLiteral("      <div class=\"card-body\">\r\n                        <div class=\"table-responsive\">\r\n                            <table id=\"example1\" class=\"table table-hover\" height=\"100\">\r\n");
            EndContext();
#line 71 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                 if (Model.Count() == 0)
                                {

#line default
#line hidden
            BeginContext(2983, 177, true);
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"10\">Não foram encontrados dados.</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 76 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3270, 454, true);
            WriteLiteral(@"                                    <thead>
                                        <tr style=""background-color:#DE022A; color:white"">
                                            <th scope=""col"">Desenvolvedor</th>
                                            <th scope=""col"">Versão</th>
                                            <th scope=""col"">Data</th>
                                        </tr>
                                    </thead>
");
            EndContext();
#line 87 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"



                                    foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(3834, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(3929, 17, false);
#line 93 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.author.login);

#line default
#line hidden
            EndContext();
            BeginContext(3946, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4002, 13, false);
#line 94 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.tag_name);

#line default
#line hidden
            EndContext();
            BeginContext(4015, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4071, 17, false);
#line 95 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                           Write(item.published_at);

#line default
#line hidden
            EndContext();
            BeginContext(4088, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 97 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(4216, 3410, true);
            WriteLiteral(@"                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            TOTAL DE COMMITS DE CADA VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                   ");
            WriteLiteral(@" <div class=""card-body"">
                        <div class=""wrapper"">
                            <canvas id=""totalChart"" height=""303""></canvas>
                            <script>
                                //fetch('/Home/GetChart')
                                //    .then(res => res.json())
                                //    .then(data => {
                                //        console.log(data)
                                //        const name = data.map(x => x.name)
                                //        const total = data.map(x => parseInt(x.total))
                                var ctx = document.getElementById(""totalChart"");
                                var chart = new Chart(ctx, {
                                    type: 'pie',
                                    data: {
                                        datasets: [{ backgroundColor: ['rgb(255, 99, 132)', 'rgb(255, 199, 132)', 'rgb(55, 99, 132)', 'rgba(0, 255, 0, 0.3)', ""#8e5ea2""], data: [10, 5, 3, 15, ");
            WriteLiteral(@"1] }], labels: [""v14.11.0"", ""v14.10.1"", ""v14.10.0"", ""v12.18.4"", ""v10.22.1"",]
                                    },
                                    options: {
                                        responsive: true,
                                        title: {
                                            display: true,
                                            responsive: true
                                        },
                                        pieceLabel: {
                                            render: 'value',
                                            position: 'outside',
                                            segment: true,
                                            fontSize: 14,
                                            fontStyle: 'bold',
                                            fontColor: '#000',
                                            //fontFamily: '""Lucida Console"", Monaco, monospace'
                                        }
             ");
            WriteLiteral(@"                       }
                                });
                                //})
                                //.catch(err => console.log('err =>', err));
                            </script>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(8315, 1136, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-12"">
                <div class=""card card-danger card-outline"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">
                            <i class=""far fa-chart-bar""></i>
                            DATA x VERSÃO
                        </h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""wrapper"">
                            <canvas id=""mixed-chart"" width=""800""");
            WriteLiteral(" height=\"400\"></canvas>\r\n\r\n                            <script>\r\n                                  var events = ");
            EndContext();
            BeginContext(9452, 44, false);
#line 197 "C:\Users\Gerim\Desktop\AnalisedeRepositorioGitHub\IC2020\Views\Repositories\DashBoard.cshtml"
                                          Write(Html.Raw(JsonConvert.SerializeObject(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(9496, 1782, true);
            WriteLiteral(@"
                                     console.log(events)
                                const tag = events.map(x => x.tag_name)
                                const datetag = events.map(x => x.published_at)
                                var x = [""X2019"",""X2020"",""X2021"",""X2022""];
var y = tag.map(s => parseFloat(s.slice(1)));
            console.log(y)
                                    new Chart(document.getElementById(""mixed-chart""), {
                                        type: 'line',
                                        data: {
                                            labels: datetag,
                                            datasets: [{
                                                data: y,
                                                label: ""Versão"",
                                                borderColor: ""#8e5ea2"",
                                                fill: false
                                            },
                                        ");
            WriteLiteral(@"    ]
                                        },
                                        options: {
                                            responsive: true,
                                            title: {
                                                display: true,
                                                text: 'INTERVALO DE TEMPO ENTRE AS VERSÕES',
                                                responsive: true
                                            }
                                        }
                                    });
                            </script>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IC2020.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
