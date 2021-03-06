#pragma checksum "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f206cd6f1bb5188b288a15c754fd3188787037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedor_Index), @"mvc.1.0.view", @"/Views/Vendedor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendedor/Index.cshtml", typeof(AspNetCore.Views_Vendedor_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f206cd6f1bb5188b288a15c754fd3188787037", @"/Views/Vendedor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendedor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 373, true);
            WriteLiteral(@"<button class=""btn btn-danger "" type=""button"" onclick=""Voltar()"">Voltar</button>
<br />
<br />

<h3>Lista de Vendedores</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>

            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
        </tr>
    </thead>

    <tbody>

");
            EndContext();
#line 21 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
          
            foreach (var item in (List<VendedorModel>)ViewBag.ListaVendedores)
            {

#line default
#line hidden
            BeginContext(480, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 571, "\"", 597, 3);
            WriteAttributeValue("", 581, "Editar(", 581, 7, true);
#line 25 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 588, item.Id, 588, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 596, ")", 596, 1, true);
            EndWriteAttribute();
            BeginContext(598, 92, true);
            WriteLiteral("> Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 690, "\"", 717, 3);
            WriteAttributeValue("", 700, "Excluir(", 700, 8, true);
#line 26 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 708, item.Id, 708, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 716, ")", 716, 1, true);
            EndWriteAttribute();
            BeginContext(718, 50, true);
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(769, 7, false);
#line 28 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(776, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(808, 9, false);
#line 29 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(817, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(849, 10, false);
#line 30 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(859, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 32 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Vendedor\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(915, 539, true);
            WriteLiteral(@"
    </tbody>
</table>
<br />

<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Cadastar()"">Cadastrar Vendedor</button>




<script>
    function Cadastar() {
        window.location.href = ""../Vendedor/Cadastro"";
    }

    function Voltar() {
        window.location.href = ""../Home/Menu"";
    }

    function Editar(id) {
        window.location.href = ""../Vendedor/Cadastro/"" + id;
    }

    function Excluir(id) {
        window.location.href = ""../Vendedor/Excluir/"" + id;
    }

</script>");
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
