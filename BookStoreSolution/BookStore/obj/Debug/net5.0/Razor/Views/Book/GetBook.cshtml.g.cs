#pragma checksum "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b669ca4d5b2af9ccbe264ed4b66e8114d29bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
#line 1 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b669ca4d5b2af9ccbe264ed4b66e8114d29bd3", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e642c3ed4135eb1d77d6c3e8901b96893c43e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
  
    //Layout = "_Layout";  defined in _viewstart.cshtml
    ViewData["Title"] = "Book Details " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Book Details</h3>
    <div class=""row"">
        <div class=""col-md-6"">

            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-bs-ride=""carousel"">
                <ol class=""carousel-indicators"">
");
#nullable restore
#line 14 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 16 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 594, "\"", 625, 2);
#nullable restore
#line 16 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 602, i==0 ? "active" :"", 602, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 624, "", 625, 1, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 17 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 20 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 847, "\"", 904, 2);
#nullable restore
#line 22 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 855, i==0 ? "carousel-item active":"carousel-item", 855, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 903, "", 904, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37b669ca4d5b2af9ccbe264ed4b66e8114d29bd36388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                          WriteLiteral(Model.Gallery[i].URl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
AddHtmlAttributeValue("", 1022, Model.Gallery[i].Name, 1022, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 25 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>

");
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h1>");
#nullable restore
#line 49 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"label label-primary\">By: </span>\r\n                    <span class=\"monospaced\">");
#nullable restore
#line 56 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                                        Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n                    <a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 3187, "\"", 3211, 1);
#nullable restore
#line 70 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 3194, Model.BookPdfUrl, 3194, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                        Read now
                    </a>
                </div>
            </div>

            <hr />

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span> ");
#nullable restore
#line 79 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                                                                                         Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages - </span> ");
#nullable restore
#line 80 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                                                                                            Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language - </span> ");
#nullable restore
#line 81 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
                                                                                         Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"py-5 bg-light\">\r\n        <h3 class=\"h3\">Similar books</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 89 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
             for (int i = 0; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4"">
                    <div class=""card mb-4 shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                        <div class=""card-body"">
                            <h3 class=""card-title"">book.Title</h3>
                            <p class=""card-text"">book.Description</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                                </div>
                                <small class=""text-muted"">bo");
            WriteLiteral("ok.Author</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 106 "C:\Users\tarun\Desktop\AspNetCoreMVC-BookStore\BookStoreSolution\BookStore\Views\Book\GetBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
