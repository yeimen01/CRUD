#pragma checksum "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1872a4435ad761a669164e55f5974ed2209454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CRUD_Clientes.Pages.Pages_Detalle_Cliente), @"mvc.1.0.razor-page", @"/Pages/Detalle_Cliente.cshtml")]
namespace CRUD_Clientes.Pages
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
#line 1 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\_ViewImports.cshtml"
using CRUD_Clientes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1872a4435ad761a669164e55f5974ed2209454", @"/Pages/Detalle_Cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b571486f2c08dc0064104155945aac4ac72cd9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Detalle_Cliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
  
    ViewData["Title"] = "Detalle Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
 if (!string.IsNullOrEmpty(Model.Mensaje))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
   Write(Model.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 13 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 15 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
Write(Model.cCliente.StrNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                         Write(Model.cCliente.StrApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n\r\n<div class=\"card\" style=\"width: 25rem;\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                          Write(Model.cCliente.StrNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                                                    Write(Model.cCliente.StrApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5>Id</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                        Write(Model.cCliente.IntIdCliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Fecha de Nacimiento</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                        Write(Model.cCliente.DtFechaNacimineto.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Sexo</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                        Write(Model.cCliente.ESexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Edad</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 27 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                        Write(Model.cCliente.IntEdad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h5>Dirección</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\Dell\source\repos\CRUD_Clientes\CRUD_Clientes\Pages\Detalle_Cliente.cshtml"
                        Write(Model.cCliente.StrDirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1872a4435ad761a669164e55f5974ed22094547509", async() => {
                WriteLiteral("Volver al registro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUD_Clientes.Pages.Detalle_ClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CRUD_Clientes.Pages.Detalle_ClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CRUD_Clientes.Pages.Detalle_ClienteModel>)PageContext?.ViewData;
        public CRUD_Clientes.Pages.Detalle_ClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
