#pragma checksum "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplicationExample.Pages.Partials.ProductModal.Views_Partials_ProductModal__ProductDetailsModalPartial), @"mvc.1.0.view", @"/Views/Partials/ProductModal/_ProductDetailsModalPartial.cshtml")]
namespace WebApplicationExample.Pages.Partials.ProductModal
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
#line 1 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\_ViewImports.cshtml"
using WebApplicationExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
using WebApplicationExample.Models.View_Models.ProductModalViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf0", @"/Views/Partials/ProductModal/_ProductDetailsModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cfad69211d94da6141b323dbe5a92ec6f653489", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Partials_ProductModal__ProductDetailsModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailedModalViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Product Details</h2>\r\n\r\n<div class=\"px-2 py-1 border rounded-md shadow-sm\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf03689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 9 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span>");
#nullable restore
#line 10 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n<div class=\"px-2 py-1 border rounded-md shadow-sm\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf05586", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span>");
#nullable restore
#line 15 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n<div class=\"px-2 py-1 border rounded-md shadow-sm\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf07488", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 19 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductPrice);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span>");
#nullable restore
#line 20 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     Write(Model.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n<div class=\"px-2 py-1 border rounded-md shadow-sm\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf09392", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductRating);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span>");
#nullable restore
#line 25 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     Write(Model.ProductRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n<div class=\"px-2 py-1 border rounded-md shadow-sm\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf011298", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 29 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductUsedCategories);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     foreach (var categoryViewModel in Model.ProductUsedCategories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <label for=\"category-id\">Category ID</label>\r\n            <span>");
#nullable restore
#line 34 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
             Write(categoryViewModel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label for=\"category-name\">Category Name</label>\r\n            <span>");
#nullable restore
#line 38 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
             Write(categoryViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf014326", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 44 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductUsedColors);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     foreach (var colorViewModel in Model.ProductUsedColors)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <label for=\"color-id\">Color ID</label>\r\n            <p>");
#nullable restore
#line 49 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
          Write(colorViewModel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <label for=\"color-name\">Color Name</label>\r\n            <p>");
#nullable restore
#line 53 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
          Write(colorViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 55 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c3d588ed8e45443c6f1427c6b6d2dd2d19c4bf017307", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 59 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductUsedSizes);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
     foreach (var sizeViewModel in Model.ProductUsedSizes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <label for=\"size-id\">Size ID</label>\r\n            <p>");
#nullable restore
#line 64 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
          Write(sizeViewModel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <label for=\"size-name\">Size Name</label>\r\n            <p>");
#nullable restore
#line 68 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
          Write(sizeViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\99450\Desktop\BackEnd_Code_Academy\WebApplicationExample\WebApplicationExample\Views\Partials\ProductModal\_ProductDetailsModalPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailedModalViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591