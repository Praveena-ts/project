#pragma checksum "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47c893b255716e850c6f358bacdb80beed2c4caf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectGroup11.Pages.Dwellings.Pages_Dwellings_Search), @"mvc.1.0.razor-page", @"/Pages/Dwellings/Search.cshtml")]
namespace FinalProjectGroup11.Pages.Dwellings
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
#line 1 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\_ViewImports.cshtml"
using FinalProjectGroup11;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c893b255716e850c6f358bacdb80beed2c4caf", @"/Pages/Dwellings/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb6946855439bf69962152857f8595a12b70d9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dwellings_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mr-sm-2 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Dwelling Address..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Maximum Price"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search Dwellings</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47c893b255716e850c6f358bacdb80beed2c4caf5739", async() => {
                WriteLiteral("\r\n            <span><strong>Address Keyword: </strong></span>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47c893b255716e850c6f358bacdb80beed2c4caf6056", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 13 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Query);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <span><strong>Maximum Price: </strong></span>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47c893b255716e850c6f358bacdb80beed2c4caf7804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 14 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaxPrice);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary mb-2\">Search</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
 if (Model.SearchCompleted)
{
    if (Model.Dwelling.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].DwellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].NumberFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].Agent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Dwelling[0].City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
         foreach (var item in Model.Dwelling)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.DwellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Agent.AgentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.City.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                \r\n            </tr>\r\n");
#nullable restore
#line 98 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 101 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"alert alert-info\">\r\n                    Oops.. No Dwelling matches your search criteria!\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 111 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Dwellings\Search.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectGroup11.Pages.Dwellings.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Dwellings.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Dwellings.SearchModel>)PageContext?.ViewData;
        public FinalProjectGroup11.Pages.Dwellings.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
