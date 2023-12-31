#pragma checksum "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ac25d398a67f18b3bf631687157fabe4dff9b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ac25d398a67f18b3bf631687157fabe4dff9b0", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About | Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""flex-right"">
    <div class=""image-right"">
        <img src=""../images/rsz_painting1_1.jpg"" alt=""arts, art student painting"">
    </div>
    <div class=""image-right"">
        <img src=""../images/rsz_festrep19.jpg"" alt=""theater"">
    </div>
    <div class=""image-right"">
        <img src=""../images/rsz_singing_girl.jpg"" alt=""group of students singing"">
    </div>
    <div class=""image-right"">
        <img src=""../images/rsz_film.jpg"" alt=""film students"">
    </div>

</div>

<h2>About Us</h2>
<p>
    Resembool Valley University was founded in 1895 by the famously gifted Elric brothers that believed
    that knowledge is a treasure beyond compare. Our university is located in the middle of a beautiful grove in
    Rogue River, and our faculty and staff is wholeheartedly dedicated to help students achieve their dreams and
    to serve others.
</p>

<br />

<h3>Location</h3>
<p>
    Resembool Valley University is located in a beatiful country-side. Not far from the 
    un");
            WriteLiteral(@"iversity, there are nice shops and a famous bakery shop that's been recently opened
    by Winry Rockbell, one of our top Automail Mechanics alumni graduates. 25 miles from here,
    you can visit the ocean and enjoy a relaxing get-away there.
</p>
<hr />

<h2>Student Body Statistics</h2>
<div");
            BeginWriteAttribute("class", " class=\"", 1477, "\"", 1485, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n<table class=\"table-bordered\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\tayde\source\repos\UniversityProject\ContosoUniversity\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>
</div>
<br />
<br />
<div class=""row"">
    <div class=""col-md-2 text-center grey""><h3>22:1</h3>Student to Faculty Ratio</div>
    <div class=""col-md-2 text-center grey""><h3>84%</h3>Admission Rate</div>
    <div class=""col-md-2 text-center grey""><h3>81%</h3>Receive Financial Aid</div>
    <div class=""col-md-2 text-center grey""><h3>59%</h3> First Generation College Students</div>
</div>
<br />
<br />
<br />
<div class=""row"">
    <div class=""col-12 contact"">
        <h2>Contact Information</h2>
        <p><b>RVU President:</b> Tayde A. Luevano</p>
        <p><b>Phone:</b> (805) 302-XXXX</p>
        <p><b>Email:</b> tayde_luevano@yahoo.com</p>
        <p><b>Address:</b> 615 Lior Street, Resembool, CA 93021</p>

    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
