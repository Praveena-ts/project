#pragma checksum "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42318f61041709def838c8da09176934822464c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectGroup11.Pages.Buyers.Pages_Buyers_Details), @"mvc.1.0.razor-page", @"/Pages/Buyers/Details.cshtml")]
namespace FinalProjectGroup11.Pages.Buyers
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42318f61041709def838c8da09176934822464c3", @"/Pages/Buyers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb6946855439bf69962152857f8595a12b70d9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buyers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Buyer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Buyer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Buyer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Buyer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Buyer.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Buyer.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Buyer.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Buyer.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Buyer.Budget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h2> Assigned Dwellings</h2>\r\n    <table class=\"table table-info\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 45 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Buyer.Dwellings[0].DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 46 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Buyer.Dwellings[0].TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 47 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Buyer.Dwellings[0].NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 48 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Buyer.Dwellings[0].NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
         foreach (var item in Model.Buyer.Dwellings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42318f61041709def838c8da09176934822464c310285", async() => {
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
#line 66 "C:\Users\janmejlk\Documents\GitHub\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Buyers\Details.cshtml"
                           WriteLiteral(Model.Buyer.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42318f61041709def838c8da09176934822464c312463", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectGroup11.Pages.Buyers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Buyers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Buyers.DetailsModel>)PageContext?.ViewData;
        public FinalProjectGroup11.Pages.Buyers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
