#pragma checksum "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d49bb87fe74de8849a8c41e3a5686eb817c1ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonaFisica_PersonaFisica), @"mvc.1.0.view", @"/Views/PersonaFisica/PersonaFisica.cshtml")]
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
#nullable restore
#line 1 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\_ViewImports.cshtml"
using Front_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\_ViewImports.cshtml"
using Front_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d49bb87fe74de8849a8c41e3a5686eb817c1ac1", @"/Views/PersonaFisica/PersonaFisica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360f650f0415e049a55b71fbed6b4acfad19e9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonaFisica_PersonaFisica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Front_Control.Models.PersonaFisica>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PersonaFisica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
  
    ViewData["Title"] = "Persona Fisica";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
     if (TempData["mensaje"] != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n             ");
#nullable restore
#line 13 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
        Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                 <span aria-hidden=\"true\">&times;</span>\r\n             </button>\r\n         </div>\r\n");
#nullable restore
#line 18 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-6\">\r\n        <h3>Lista de personas fisicas</h3>\r\n    </div>\r\n\r\n    <div class=\"col-sm-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d49bb87fe74de8849a8c41e3a5686eb817c1ac17083", async() => {
                WriteLiteral("Agregar Nueva Persona Fisica");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
         if(Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"               <table class=""table table-bordered table-striped"">
                   <thead>
                       <tr>
                           <td>ID</td>
                           <td>Nombre</td>
                           <td>Apellido Paterno</td>
                           <td>Apellido Materno</td>
                           <td>RFC</td>
                           <td>Fecha de Nacimiento</td>
                           <td>Usuario Agrega</td>
                           <td>Acciones</td>
                       </tr>
                   </thead>
                   <tbody>
");
#nullable restore
#line 45 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                        foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <tr>\r\n                           <td>");
#nullable restore
#line 48 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.idPersonaFisica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 49 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 50 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.apellidoPaterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 51 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.apellidoMaterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 52 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.rfc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 53 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.fechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 54 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                          Write(item.usuarioAgrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>\r\n                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d49bb87fe74de8849a8c41e3a5686eb817c1ac112086", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                                                                                    WriteLiteral(item.idPersonaFisica);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d49bb87fe74de8849a8c41e3a5686eb817c1ac114646", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                                                                                      WriteLiteral(item.idPersonaFisica);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                           </td>\r\n                       </tr>\r\n");
#nullable restore
#line 61 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   </tbody>\r\n               </table> \r\n");
#nullable restore
#line 64 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No existen registros</p>\r\n");
#nullable restore
#line 68 "C:\Users\juanm\Documents\GitHub\TEST_DEV_JMEM_31-05-2021\Front_Control\Views\PersonaFisica\PersonaFisica.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Front_Control.Models.PersonaFisica>> Html { get; private set; }
    }
}
#pragma warning restore 1591
