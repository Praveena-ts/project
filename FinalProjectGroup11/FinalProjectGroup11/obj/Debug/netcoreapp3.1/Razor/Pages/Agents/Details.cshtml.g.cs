#pragma checksum "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce8e69d7b745d5be76d40f8105e906eca607b586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectGroup11.Pages.Agents.Pages_Agents_Details), @"mvc.1.0.razor-page", @"/Pages/Agents/Details.cshtml")]
namespace FinalProjectGroup11.Pages.Agents
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce8e69d7b745d5be76d40f8105e906eca607b586", @"/Pages/Agents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb6946855439bf69962152857f8595a12b70d9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Agents_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
  
    ViewData["Title"] = "Agent Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Agent Details</h2>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.AgentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.AgentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.LicenseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.LicenseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agent.SalesOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agent.SalesOffice.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h2> Listed dwellings</h2>\r\n    <table class=\"table table-info\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 69 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agent.Dwellings[0].DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 70 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agent.Dwellings[0].TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 71 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agent.Dwellings[0].NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 72 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agent.Dwellings[0].NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 73 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agent.Dwellings[0].DaysListed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n\r\n");
#nullable restore
#line 77 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
         foreach (var item in Model.Agent.Dwellings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 80 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.DwellingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 81 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.TotalArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 82 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.NumberBed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 83 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.NumberBath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 84 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.DaysListed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\itsme\Desktop\Web_dev\project\FinalProjectGroup11\FinalProjectGroup11\Pages\Agents\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n<div>\r\n    \r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectGroup11.Pages.Agents.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Agents.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProjectGroup11.Pages.Agents.DetailsModel>)PageContext?.ViewData;
        public FinalProjectGroup11.Pages.Agents.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
