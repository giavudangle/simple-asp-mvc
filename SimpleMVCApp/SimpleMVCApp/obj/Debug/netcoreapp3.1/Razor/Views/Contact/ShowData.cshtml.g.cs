#pragma checksum "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7927ebe1b17176b489df38cd94a764edf968aec7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ShowData), @"mvc.1.0.view", @"/Views/Contact/ShowData.cshtml")]
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
#line 1 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\_ViewImports.cshtml"
using SimpleMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\_ViewImports.cshtml"
using SimpleMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7927ebe1b17176b489df38cd94a764edf968aec7", @"/Views/Contact/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519ba7a8d069e055bb19a2cd5b9e602720f6aef5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleMVCApp.Models.ContactViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"list-group\">\r\n\r\n        <span class=\"list-group-item-primary\">Topic : ");
#nullable restore
#line 10 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                                 Write(Model.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n        <span class=\"list-group-item-action\">Title : ");
#nullable restore
#line 12 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n\r\n        <span class=\"list-group-item-danger\">Content : ");
#nullable restore
#line 15 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                                  Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n\r\n        <span class=\"list-group-item-info\">Fullname : ");
#nullable restore
#line 18 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                                 Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n\r\n        <span class=\"list-group-item-light\">Email : ");
#nullable restore
#line 21 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n\r\n        <span class=\"list-group-item-success\">Phone : ");
#nullable restore
#line 24 "D:\ASP\SimpleMVCApp\SimpleMVCApp\Views\Contact\ShowData.cshtml"
                                                 Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <hr />\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleMVCApp.Models.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
