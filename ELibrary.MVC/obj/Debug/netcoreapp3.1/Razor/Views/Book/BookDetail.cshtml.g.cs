#pragma checksum "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8743e8f34f9861aebd1d6eb29c07d74a8af93a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookDetail), @"mvc.1.0.view", @"/Views/Book/BookDetail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\_ViewImports.cshtml"
using ELibrary.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8743e8f34f9861aebd1d6eb29c07d74a8af93a5", @"/Views/Book/BookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dac1f4a4d3a5ac89da0c11a4abf18ee31cc95c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookDetailAndReviewViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddREview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
  
    Layout = "_HomeLayout";
    ViewBag.Title = "Book Detail";

    var book = Model.BookDetailViewModel;
    var review = Model.ReviewViewModel;
    var addBook = Model.AddReviewModel;
    addBook.BookId = book.Id;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container px-6 py-10 mx-auto md:py-16 font-sans ..."">
    <div>
        <div class=""grid gap-8 grid-cols-4"">
            <div class=""col-span-1 ml-0"">
                <div class=""aspect-h-12 aspect-w-8 z-0 w-full"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 527, "\"", 568, 1);
#nullable restore
#line 18 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
WriteAttributeValue("", 533, Model.BookDetailViewModel.PhotoUrl, 533, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         alt=\"car photo\" class=\"object-center object-cover\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-span-3\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 753, "\"", 761, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h1 class=\"text-2xl text-md tracking-wide text-gray-900 md:text-4xl\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                   Write(Model.BookDetailViewModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h1>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 965, "\"", 973, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""mt-2 text-sm"">
                            <span class=""text-gray-400"">
                                Available Copies
                            </span>
                            <span class=""text-g-900 mr-5 text-lg font-bold"">
                                ");
#nullable restore
#line 33 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                           Write(Model.BookDetailViewModel.AvailableCopies);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                            <span class=""text-gray-400"">
                                Copies in Library
                            </span>
                            <span class=""text-g-900 mr-5 text-lg font-bold"">
                                ");
#nullable restore
#line 39 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                           Write(Model.BookDetailViewModel.Copies);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                            <span class=""text-gray-400"">
                                Copies Taken out
                            </span>
                            <span class=""text-g-900 mr-5 text-lg font-bold"">
                                5
                            </span>

                        </div>

                        <div class=""mt-2"">
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Genre: </span>
                                <span class=""font-semibold"">Business & Economics</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Arthor: </span>
                                <span class=""font-semibold"">Nitin Seth</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text");
            WriteLiteral(@"-gray-400"">Language: </span>
                                <span class=""font-semibold"">English</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Publisher: </span>
                                <span class=""font-semibold"">Penguin Random House India Pvt. Ltd</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Published Date: </span>
                                <span class=""font-semibold"">24 June 2020</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Added to Library: </span>
                                <span class=""font-semibold"">10 July 2020</span>
                            </div>
                            <div class=""mb-4"">
                                <span cl");
            WriteLiteral(@"ass=""text-sm text-gray-400"">ISBN : </span>
                                <span class=""font-semibold"">234567543576546</span>
                            </div>
                            <div class=""mb-4"">
                                <span class=""text-sm text-gray-400"">Pages: </span>
                                <span class=""font-semibold"">544</span>
                            </div>

                        </div>

                        <div class=""mt-2"">
                            <div class=""grid gap-2 grid-cols-8"">
                                <div class=""col-span-1"">Description: </div>
                                <div class=""col-span-7"">
                                    <div class=""mb-9"">
                                        <p class=""overflow-ellipsis overflow-hidden ... leading-7"">
                                            ");
#nullable restore
#line 92 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                       Write(Model.BookDetailViewModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <div class=""mt-2"">
                                        <button class=""btn btn-primary"">Read Now</button>
                                        <button class=""btn btn-secondary"">
                                            <svg class=""fill-current w-4 h-4 mr-2"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20""><path d=""M13 8V2H7v6H2l8 8 8-8h-5zM0 18h20v2H0v-2z"" /></svg>
                                            <span>Download</span>
                                        </button>

                                    </div>
                                    <div class=""p-4 flex text-sm text-blue-600"">

");
#nullable restore
#line 105 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                         foreach (var rate in @Model.BookDetailViewModel.Rate)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <svg viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg"" class=""h-8 w-8 fill-current text-blue-600"">
                                                <path d=""M8.128 19.825a1.586 1.586 0 0 1-1.643-.117 1.543 1.543 0 0 1-.53-.662 1.515 1.515 0 0 1-.096-.837l.736-4.247-3.13-3a1.514 1.514 0 0 1-.39-1.569c.09-.271.254-.513.475-.698.22-.185.49-.306.776-.35L8.66 7.73l1.925-3.862c.128-.26.328-.48.577-.633a1.584 1.584 0 0 1 1.662 0c.25.153.45.373.577.633l1.925 3.847 4.334.615c.29.042.562.162.785.348.224.186.39.43.48.704a1.514 1.514 0 0 1-.404 1.58l-3.13 3 .736 4.247c.047.282.014.572-.096.837-.111.265-.294.494-.53.662a1.582 1.582 0 0 1-1.643.117l-3.865-2-3.865 2z"">
                                                </path>
                                            </svg>
");
#nullable restore
#line 111 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <span class=""ml-2 text-gray-800 text-2xl"">Rating</span>
                                    </div>


                                    <div>
                                        <h3 class=""mb-10 text-2xl font-bold"">Reviews</h3>
                                    </div>

");
#nullable restore
#line 121 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                     foreach (var item in @Model.BookDetailViewModel.Reviews)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div>\r\n                                            <h5 class=\"mb-2  text-lg font-bold\">");
#nullable restore
#line 124 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                                                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>");
#nullable restore
#line 125 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                          Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n");
#nullable restore
#line 127 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <button class=""mt-3 modal-open bg-transparent border border-gray-500 hover:border-indigo-500 text-gray-500 hover:text-indigo-500 font-bold py-2 px-4 rounded-full"">Make Review</button>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>


            </div>
        </div>


    </div>


    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8743e8f34f9861aebd1d6eb29c07d74a8af93a514891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 146 "C:\Users\hp\Desktop\Apps\ElibraryApp\week-10-group-d-online-book-library\ELibrary.MVC\Views\Book\BookDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = addBook;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookDetailAndReviewViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
