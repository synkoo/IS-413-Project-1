#pragma checksum "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3b1afa7eace5c6d63c4b3ca79bcf20064c1842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AppointmentList), @"mvc.1.0.view", @"/Views/Home/AppointmentList.cshtml")]
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
#line 1 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/_ViewImports.cshtml"
using TempleTourScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/_ViewImports.cshtml"
using TempleTourScheduler.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/_ViewImports.cshtml"
using TempleTourScheduler.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3b1afa7eace5c6d63c4b3ca79bcf20064c1842", @"/Views/Home/AppointmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f36e938ffcaf0407232039fc2ed3e642f5e9f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AppointmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppointmentListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"container\">\n    <h3>Schedule</h3>\n\n    <div class=\"row\">\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Monday</h5>\n");
#nullable restore
#line 17 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Monday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 19 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 21 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Tuesday</h5>\n\n");
#nullable restore
#line 26 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Tuesday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 28 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 30 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Wednesday</h5>\n\n");
#nullable restore
#line 35 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Wednesday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 37 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 39 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Thursday</h5>\n\n");
#nullable restore
#line 44 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Thursday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 46 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 48 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Friday</h5>\n\n");
#nullable restore
#line 53 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Friday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 55 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 57 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Saturday</h5>\n\n");
#nullable restore
#line 62 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Saturday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 64 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 66 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <div class=\"card card-outline-primary m-1 p-1 shadow-sm fixed-width-item\">\n            <h5>Sunday</h5>\n\n");
#nullable restore
#line 71 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
             foreach (var x in Model.Sunday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-primary\">");
#nullable restore
#line 73 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                             Write(x.TimeSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
                                                         Write(x.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <br />\n");
#nullable restore
#line 75 "/Users/Sangyoon/Projects/TempleTourScheduler/TempleTourScheduler/Views/Home/AppointmentList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppointmentListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
