#pragma checksum "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52bece50d6490ca370187e5443f7986ef1e3d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetAllEvents), @"mvc.1.0.view", @"/Views/Event/GetAllEvents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52bece50d6490ca370187e5443f7986ef1e3d45", @"/Views/Event/GetAllEvents.cshtml")]
    public class Views_Event_GetAllEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web_app1.Models.EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"display-4\">All Events</h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
         foreach (var count in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/1999/xhtml""></svg>
                    <div class=""card-body"">
                        <h3 class=""card-title"">");
#nullable restore
#line 15 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
                                          Write(count.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
                                        Write(count.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"d-flex justify-content-between align-items-center\">\r\n                            <div class=\"btn-group\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 831, 2);
            WriteAttributeValue("", 808, "/book/GetBook/", 808, 14, true);
#nullable restore
#line 19 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
WriteAttributeValue("", 822, count.Id, 822, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">View details</a>\r\n                            </div>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 21 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
                                                 Write(count.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\avnishkumar\Documents\assignment\web_app1\web_app1\Views\Event\GetAllEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web_app1.Models.EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
