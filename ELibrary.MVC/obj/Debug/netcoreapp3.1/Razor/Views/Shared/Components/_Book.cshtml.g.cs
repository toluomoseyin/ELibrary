#pragma checksum "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d03f4f9b6ca20ca4a18d3997a3e467c08d3d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Book), @"mvc.1.0.view", @"/Views/Shared/Components/_Book.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d03f4f9b6ca20ca4a18d3997a3e467c08d3d16", @"/Views/Shared/Components/_Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dac1f4a4d3a5ac89da0c11a4abf18ee31cc95c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inline-block mb-1 font-semibold leading-5 hover:underline hover:text-gray-900"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"w-52\">\r\n    <div class=\"mb-2 overflow-hidden\">\r\n        <div class=\"aspect-h-12 aspect-w-8 w-48\">\r\n            <img class=\"object-cover object-center\"");
            BeginWriteAttribute("src", " src=\"", 187, "\"", 208, 1);
#nullable restore
#line 6 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
WriteAttributeValue("", 193, Model.PhotoUrl, 193, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "  alt=\"", 209, "\"", 216, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d03f4f9b6ca20ca4a18d3997a3e467c08d3d165060", async() => {
#nullable restore
#line 10 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                                                                                                                                                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n        <span>\r\n            ");
#nullable restore
#line 12 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                         <span>\r\n");
#nullable restore
#line 14 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                              for (int i = 1; i <= Model.Rating; i++)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <i class=\"fas fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 17 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                              for (int j = Model.Rating + 1; j <= 5; j++)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <i class=\"fas fa-star\"></i>\r\n");
#nullable restore
#line 21 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            \r\n                   \r\n                          \r\n                         </span>\r\n            </span>\r\n");
#nullable restore
#line 28 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
          if (@Model.Availability)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Available</p>\r\n");
#nullable restore
#line 31 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Unavailable</p>\r\n");
#nullable restore
#line 35 "C:\Users\hp\Desktop\new\Elibrary\ELibrary\ELibrary.MVC\Views\Shared\Components\_Book.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
