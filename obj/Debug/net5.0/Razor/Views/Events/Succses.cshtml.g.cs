#pragma checksum "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\Events\Succses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3307c4460f973bcf75ab53fc56d8ea9b3e52fc92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Succses), @"mvc.1.0.view", @"/Views/Events/Succses.cshtml")]
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
#line 1 "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\_ViewImports.cshtml"
using Katzavia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\_ViewImports.cshtml"
using Katzavia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3307c4460f973bcf75ab53fc56d8ea9b3e52fc92", @"/Views/Events/Succses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08baa0db379db1aae3f780f90786344478fecdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Succses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Katzavia.Models.Events>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\Events\Succses.cshtml"
  
    ViewData["Title"] = "Succses";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n<h1>\r\n    Thank you for your request <h1>\r\n\r\n    <h1>\r\n        We will contact with you soon<h1>\r\n\r\n        <script>\r\n  setTimeout(function () {\r\n        window.location.replace(\'");
#nullable restore
#line 16 "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\Events\Succses.cshtml"
                            Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n    }, 4000);\r\n\r\n        </script>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Eden Alon\Documents\GitHub\katzavia\Views\Events\Succses.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Katzavia.Models.Events> Html { get; private set; }
    }
}
#pragma warning restore 1591
