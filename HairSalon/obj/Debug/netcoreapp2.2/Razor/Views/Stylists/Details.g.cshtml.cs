#pragma checksum "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc7805e2ff735c136011ce6d83a2b2c482a01ef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
#line 5 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc7805e2ff735c136011ce6d83a2b2c482a01ef9", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 31, true);
            WriteLiteral("\n<h2>Stylist Details:</h2>\n<h3>");
            EndContext();
            BeginContext(118, 40, false);
#line 9 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(158, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(161, 36, false);
#line 9 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(197, 12, true);
            WriteLiteral("</h3>\n\n<ul>\n");
            EndContext();
#line 12 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
   if (@Model.Clients.Count == 0)
  {

#line default
#line hidden
            BeginContext(247, 28, true);
            WriteLiteral("    <p>no clients found</p>\n");
            EndContext();
#line 15 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(279, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 17 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
   foreach(Client client in @Model.Clients)
  {

#line default
#line hidden
            BeginContext(328, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(337, 11, false);
#line 19 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
   Write(client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(348, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 20 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(358, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(369, 53, false);
#line 23 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Add new client", "Create","Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(422, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(431, 44, false);
#line 24 "/Users/kailasprague/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Back to stylists", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(475, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
