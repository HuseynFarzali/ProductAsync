#pragma checksum "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Pages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a375a5f9f878777de3d91a5c2b2211a25f7c83a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplicationExample.Pages.Pages_Test), @"mvc.1.0.razor-page", @"/Pages/Test.cshtml")]
namespace WebApplicationExample.Pages
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
#line 1 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Pages\_ViewImports.cshtml"
using WebApplicationExample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a375a5f9f878777de3d91a5c2b2211a25f7c83a5", @"/Pages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cfad69211d94da6141b323dbe5a92ec6f653489", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Pages\Test.cshtml"
 if (String.IsNullOrEmpty(Model.ConnectionString))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Null.</p>\r\n");
#nullable restore
#line 9 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Pages\Test.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 10 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Pages\Test.cshtml"
Write(Model.ConnectionString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationExample.Pages.TestModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationExample.Pages.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationExample.Pages.TestModel>)PageContext?.ViewData;
        public WebApplicationExample.Pages.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591