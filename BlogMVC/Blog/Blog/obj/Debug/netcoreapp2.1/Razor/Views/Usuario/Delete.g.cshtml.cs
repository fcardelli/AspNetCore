#pragma checksum "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "422238e2b0c7898c0176b433ce8615f8e2b6c8b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Delete), @"mvc.1.0.view", @"/Views/Usuario/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Delete.cshtml", typeof(AspNetCore.Views_Usuario_Delete))]
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
#line 1 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422238e2b0c7898c0176b433ce8615f8e2b6c8b5", @"/Views/Usuario/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Entidades.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 40, false);
#line 15 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 36, false);
#line 18 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(371, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(415, 45, false);
#line 21 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(504, 41, false);
#line 24 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(589, 41, false);
#line 27 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(630, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(674, 37, false);
#line 30 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 47, false);
#line 33 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(802, 33, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n\r\n");
            EndContext();
#line 38 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
             if (Model.TipoUsuario == 1)
            {

#line default
#line hidden
            BeginContext(953, 47, true);
            WriteLiteral("                <label> Administrador</label>\r\n");
            EndContext();
#line 41 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
            }
            else
            {
                

#line default
#line hidden
#line 44 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                 if (Model.TipoUsuario == 2)
                {

#line default
#line hidden
            BeginContext(1113, 44, true);
            WriteLiteral("                    <label>Técnico</label>\r\n");
            EndContext();
#line 47 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 50 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                     if (Model.TipoUsuario == 3)
                    {

#line default
#line hidden
            BeginContext(1290, 54, true);
            WriteLiteral("                        <label>Desenvolvedor</label>\r\n");
            EndContext();
#line 53 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1416, 48, true);
            WriteLiteral("                        <label>Usuário</label>\r\n");
            EndContext();
#line 57 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                    }

#line default
#line hidden
#line 57 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                     

                }

#line default
#line hidden
#line 59 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1523, 45, true);
            WriteLiteral("            </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1569, 43, false);
#line 63 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1656, 39, false);
#line 66 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1733, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e97a8a8ce3441aad3414a0c2b4d128", async() => {
                BeginContext(1759, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1769, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "270476f13d5c4a2d8251459c0395fe62", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\felip\OneDrive\Documents\Projetos\Csharp\BlogMVC\Blog\Blog\Views\Usuario\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UsuarioId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1812, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1896, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "643c0fdca4b94060b3424eda4669b2ed", async() => {
                    BeginContext(1918, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1934, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1947, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Entidades.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591