#pragma checksum "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\HelloWorld\ShowObject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659318c638ac765f897d747ff4d097e3a1f172c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_ShowObject), @"mvc.1.0.view", @"/Views/HelloWorld/ShowObject.cshtml")]
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
#line 1 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\_ViewImports.cshtml"
using HelloMvcCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\_ViewImports.cshtml"
using HelloMvcCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659318c638ac765f897d747ff4d097e3a1f172c2", @"/Views/HelloWorld/ShowObject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47270b715b5929068c11c2036c95b0522daafe13", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_ShowObject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloMvcCore.Models.ClassA>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\HelloWorld\ShowObject.cshtml"
  
    ViewData["Title"] = "ShowObject";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>ShowObject</h2>\r\n\r\n<p>\r\n    Typ des Models: ");
#nullable restore
#line 10 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\HelloWorld\ShowObject.cshtml"
               Write(Model.GetType().FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\nDaten von ClassA: StringVal ");
#nullable restore
#line 12 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\HelloWorld\ShowObject.cshtml"
                       Write(Model.StringVal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" IntVal ");
#nullable restore
#line 12 "F:\Documents\School\4.Klasse\POS\HelloMvcCore\HelloMvcCore\Views\HelloWorld\ShowObject.cshtml"
                                               Write(Model.IntVal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloMvcCore.Models.ClassA> Html { get; private set; }
    }
}
#pragma warning restore 1591