#pragma checksum "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e047b98e586c50ef13b3dee0d2f9f923017d859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Index.cshtml", typeof(AspNetCore.Views_Clientes_Index))]
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
#line 1 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\_ViewImports.cshtml"
using OctoProva;

#line default
#line hidden
#line 2 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\_ViewImports.cshtml"
using OctoProva.Models;

#line default
#line hidden
#line 3 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#line 5 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e047b98e586c50ef13b3dee0d2f9f923017d859", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b181896b1ba1272003cf11dca446f865939922b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<OctoProva.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarClientePessoaJuridica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarClientePessoaFisica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 46, true);
            WriteLiteral("<!--Importando Bibliotecas para paginação-->\r\n");
            EndContext();
            BeginContext(186, 30, true);
            WriteLiteral("\r\n<!--Chamada para a View-->\r\n");
            EndContext();
#line 8 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(257, 41, true);
            WriteLiteral("\r\n<h2>Lista de Clientes</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(298, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e047b98e586c50ef13b3dee0d2f9f923017d8595663", async() => {
                BeginContext(327, 21, true);
                WriteLiteral("Criar um novo Cliente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(352, 1156, true);
            WriteLiteral(@"
</p>
    <!--Mostrando o título das colunas-->
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nome
            </th>
            <th>
                Documento
            </th>
            <th>
                Email
            </th>
            <th>
                Tipo 1°Telefone
            </th>
            <th>
                1°Telefone
            </th>
            <th>
                Tipo 2°Telefone
            </th>
            <th>
                2°Telefone
            </th>
            <th>
                Tipo Endereço
            </th>
            <th>
                Endereço
            </th>
            <th>
                CEP
            </th>
            <th>
                Número
            </th>
            <th>
                Complemento
            </th>
            <th>
                Bairro
            </th>
            <th>
                Cidade
            </th>
            <th>
              ");
            WriteLiteral("  UF\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n<!--Retornando os valores das colunas-->\r\n");
            EndContext();
#line 71 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1540, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1589, 39, false);
#line 74 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 54, true);
            WriteLiteral("\r\n            </td>\r\n           <td>\r\n                ");
            EndContext();
            BeginContext(1683, 44, false);
#line 77 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 56, true);
            WriteLiteral(" \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1784, 40, false);
#line 80 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1880, 48, false);
#line 83 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoTelefone1));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1984, 44, false);
#line 86 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone1));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2084, 48, false);
#line 89 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoTelefone2));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2188, 44, false);
#line 92 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone2));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2288, 47, false);
#line 95 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoEndereco));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2391, 43, false);
#line 98 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2490, 38, false);
#line 101 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2584, 41, false);
#line 104 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2681, 46, false);
#line 107 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2783, 41, false);
#line 110 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(2824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2880, 41, false);
#line 113 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2977, 37, false);
#line 116 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UF));

#line default
#line hidden
            EndContext();
            BeginContext(3014, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 119 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                     if(item.Documento.Length > 16) {

#line default
#line hidden
            BeginContext(3106, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3107, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e047b98e586c50ef13b3dee0d2f9f923017d85915534", async() => {
                BeginContext(3175, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 119 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                                                                                                                                    }

#line default
#line hidden
#line 120 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                     if(item.Documento.Length < 16) {

#line default
#line hidden
            BeginContext(3241, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3242, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e047b98e586c50ef13b3dee0d2f9f923017d85918432", async() => {
                BeginContext(3308, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 120 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                                                                                                                                  }

#line default
#line hidden
            BeginContext(3321, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3341, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e047b98e586c50ef13b3dee0d2f9f923017d85921143", async() => {
                BeginContext(3396, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3407, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 124 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3446, 62, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<!--Páginas para a lista-->\r\nPágina ");
            EndContext();
            BeginContext(3509, 16, false);
#line 129 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
  Write(Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3525, 4, true);
            WriteLiteral(" de ");
            EndContext();
            BeginContext(3530, 15, false);
#line 129 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
                       Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3545, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3550, 76, false);
#line 131 "C:\Users\Raphael Scursoni\Desktop\Restaurando OctoProva\OctoTeste\OctoProva\Views\Clientes\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new {pagina = page})));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<OctoProva.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
