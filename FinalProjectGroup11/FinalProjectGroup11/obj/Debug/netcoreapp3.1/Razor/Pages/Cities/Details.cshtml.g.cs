#pragma checksum "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628dd415689d2302989339ab3e14c1928007ba95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectGroup11.Pages.Cities.Pages_Cities_Details), @"mvc.1.0.razor-page", @"/Pages/Cities/Details.cshtml")]
namespace FinalProjectGroup11.Pages.Cities
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
#line 1 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\_ViewImports.cshtml"
using FinalProjectGroup11;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628dd415689d2302989339ab3e14c1928007ba95", @"/Pages/Cities/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb6946855439bf69962152857f8595a12b70d9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cities_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>City</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(model => model.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(model => model.City.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City.CountyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(model => model.City.CountyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h2> Available Dwellings</h2>\r\n    <table class=\"table table-info\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 39 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City.Dwellings[0].DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 40 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City.Dwellings[0].TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 41 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City.Dwellings[0].NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 42 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City.Dwellings[0].NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 43 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City.Dwellings[0].DaysListed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n\r\n");
#nullable restore
#line 47 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
         foreach (var item in Model.City.Dwellings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 50 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 51 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 52 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 53 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 54 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.DaysListed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "628dd415689d2302989339ab3e14c1928007ba9510030", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Cities\Details.cshtml"
                           WriteLiteral(Model.City.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "628dd415689d2302989339ab3e14c1928007ba9512203", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectGroup11.Pages.Cities.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Cities.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Cities.DetailsModel>)PageContext?.ViewData;
        public FinalProjectGroup11.Pages.Cities.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
