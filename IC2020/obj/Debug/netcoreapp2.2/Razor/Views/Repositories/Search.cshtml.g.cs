#pragma checksum "D:\repos\repos\IC2020\IC2020\Views\Repositories\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8f02e62296a8ebba1f8446ac038ed00f1e68f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositories_Search), @"mvc.1.0.view", @"/Views/Repositories/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Repositories/Search.cshtml", typeof(AspNetCore.Views_Repositories_Search))]
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
#line 1 "D:\repos\repos\IC2020\IC2020\Views\_ViewImports.cshtml"
using IC2020;

#line default
#line hidden
#line 1 "D:\repos\repos\IC2020\IC2020\Views\Repositories\Search.cshtml"
using IC2020.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8f02e62296a8ebba1f8446ac038ed00f1e68f6", @"/Views/Repositories/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0cdb9692461173cc7dbac5cbca5fe6befa101e", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositories_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\repos\repos\IC2020\IC2020\Views\Repositories\Search.cshtml"
   ViewData["Title"] = "Pesquisa";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
            BeginContext(128, 78, true);
            WriteLiteral("\n<h1>Pesquisar repositórios</h1>\n<br />\n<div class=\"body-content panel-body\">\n");
            EndContext();
#line 9 "D:\repos\repos\IC2020\IC2020\Views\Repositories\Search.cshtml"
     using (Html.BeginForm("SearchResult", "Repositories", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(289, 186, true);
            WriteLiteral("<input type=\"text\" class=\"input-group-sm\" name=\"key\" placeholder=\"Busca por repositórios\" />\n                <input type=\"submit\" class=\"btn btn-sm  btn-outline-info\" value=\"Procurar\" />");
            EndContext();
#line 12 "D:\repos\repos\IC2020\IC2020\Views\Repositories\Search.cshtml"
                                                                                             }

#line default
#line hidden
            BeginContext(477, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
