#pragma checksum "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cafa2d6c11b334fdac37f162f209dcfae556db42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Excluir), @"mvc.1.0.view", @"/Views/Cliente/Excluir.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Excluir.cshtml", typeof(AspNetCore.Views_Cliente_Excluir))]
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
#line 1 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#line 2 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafa2d6c11b334fdac37f162f209dcfae556db42", @"/Views/Cliente/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 346, true);
            WriteLiteral(@"
<h2>Excluir Cliente?</h2>

<h3>Deseja realmente excluir o cliente selecionado???</h3>

<button type=""button"" class=""btn btn-danger"" onclick=""Nao()"">Não</button>
<button type=""button"" class=""btn btn-success"" onclick=""Sim()"">Sim</button>

<script>
    function Sim() {

        window.location.href = '../../Cliente/ExcluirCliente/' + '");
            EndContext();
            BeginContext(347, 32, false);
#line 12 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Excluir.cshtml"
                                                             Write(ViewData["IdExcluir"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(379, 112, true);
            WriteLiteral("\';\r\n\r\n    }\r\n\r\n    function Nao() {\r\n\r\n        window.location.href = \'../../Cliente/Index\';\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
