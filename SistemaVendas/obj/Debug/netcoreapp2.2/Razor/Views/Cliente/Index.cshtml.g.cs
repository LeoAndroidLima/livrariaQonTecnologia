#pragma checksum "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d78d4acb49ed9b47d2cf090e1bce8078e4e0c5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d78d4acb49ed9b47d2cf090e1bce8078e4e0c5c", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 397, true);
            WriteLiteral(@"<button class=""btn btn-danger "" type=""button"" onclick=""Voltar()"">Voltar</button>
<br />
<br />

<h3>Lista de Clientes</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>

            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Email</th>
        </tr>
    </thead>

    <tbody>

");
            EndContext();
#line 22 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
          
            foreach (var item in (List<ClienteModal>)ViewBag.ListaClientes)
            {

#line default
#line hidden
            BeginContext(501, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 592, "\"", 618, 3);
            WriteAttributeValue("", 602, "Editar(", 602, 7, true);
#line 26 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 609, item.Id, 609, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 617, ")", 617, 1, true);
            EndWriteAttribute();
            BeginContext(619, 92, true);
            WriteLiteral("> Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 711, "\"", 738, 3);
            WriteAttributeValue("", 721, "Excluir(", 721, 8, true);
#line 27 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 729, item.Id, 729, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 737, ")", 737, 1, true);
            EndWriteAttribute();
            BeginContext(739, 50, true);
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(790, 7, false);
#line 29 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(797, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(829, 9, false);
#line 30 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(838, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(870, 8, false);
#line 31 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(878, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(910, 10, false);
#line 32 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(920, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\leona\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(976, 535, true);
            WriteLiteral(@"
    </tbody>
</table>
<br />

<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Cadastar()"">Cadastrar Cliente</button>




<script>
    function Cadastar() {
        window.location.href = ""../Cliente/Cadastro"";
    }

    function Voltar() {
        window.location.href = ""../Home/Menu"";
    }

    function Editar(id) {
        window.location.href = ""../Cliente/Cadastro/"" + id;
    }

    function Excluir(id) {
        window.location.href = ""../Cliente/Excluir/"" + id;
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
