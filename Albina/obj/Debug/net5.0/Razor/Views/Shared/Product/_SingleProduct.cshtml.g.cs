#pragma checksum "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a4c2d76d2887df1ecab3b8ede2cd7ba485a847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Product__SingleProduct), @"mvc.1.0.view", @"/Views/Shared/Product/_SingleProduct.cshtml")]
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
#line 1 "C:\Users\Professional\source\repos\Albina\Albina\Views\_ViewImports.cshtml"
using Albina;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Professional\source\repos\Albina\Albina\Views\_ViewImports.cshtml"
using Albina.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a4c2d76d2887df1ecab3b8ede2cd7ba485a847", @"/Views/Shared/Product/_SingleProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0450f18fa0634f63993e1b9802e173cbc65ef672", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Product__SingleProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"grid_item\">\r\n    <figure>\r\n");
#nullable restore
#line 4 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Discount != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ribbon off\">");
#nullable restore
#line 6 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                                Write(Model.Discount.Percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 7 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Discount==null && Model.Label!=null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ribbon new\"");
            BeginWriteAttribute("style", " style=\"", 304, "\"", 348, 3);
            WriteAttributeValue("", 312, "background-color:", 312, 17, true);
#nullable restore
#line 11 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
WriteAttributeValue("", 329, Model.Label.Color, 329, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 347, ";", 347, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                                                                             Write(Model.Label.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 12 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <a href=\"product-detail-1.html\">\r\n        <img class=\"img-fluid lazy\" src=\"img/products/product_placeholder_square_medium.jpg\" data-src=\"uploads/");
#nullable restore
#line 15 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                                                                                                          Write(Model.Photos[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 555, "\"", 572, 1);
#nullable restore
#line 15 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
WriteAttributeValue("", 561, Model.Name, 561, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 16 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Photos.Count > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"img-fluid lazy\" src=\"img/products/product_placeholder_square_medium.jpg\" data-src=\"uploads/");
#nullable restore
#line 18 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                                                                                                              Write(Model.Photos[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 757, "\"", 774, 1);
#nullable restore
#line 18 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
WriteAttributeValue("", 763, Model.Name, 763, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 19 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </a>\r\n");
#nullable restore
#line 22 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Discount != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div data-countdown=\"");
#nullable restore
#line 24 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                            Write(Model.Discount.EndDate.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"countdown\"></div>\r\n");
#nullable restore
#line 25 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </figure>\r\n    <div class=\"rating\"><i class=\"icon-star voted\"></i><i class=\"icon-star voted\"></i><i class=\"icon-star voted\"></i><i class=\"icon-star voted\"></i><i class=\"icon-star\"></i></div>\r\n    <a href=\"product-detail-1.html\">\r\n        <h3>");
#nullable restore
#line 30 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </a>\r\n    <div class=\"price_box\">\r\n");
#nullable restore
#line 33 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
         if (Model.Discount == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"new_price\">");
#nullable restore
#line 35 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                               Write(Model.Price.ToString("#.00 "));

#line default
#line hidden
#nullable disable
            WriteLiteral("???</span>\r\n");
#nullable restore
#line 36 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"new_price\">");
#nullable restore
#line 39 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                               Write(Model.Price.ToString("#.00 "));

#line default
#line hidden
#nullable disable
            WriteLiteral("???</span>\r\n            <span class=\"new_price\">");
#nullable restore
#line 40 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
                               Write(Model.Price.ToString("#.00 "));

#line default
#line hidden
#nullable disable
            WriteLiteral("???</span>\r\n");
#nullable restore
#line 41 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Product\_SingleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <ul>
        <li><a href=""#0"" class=""tooltip-1"" data-toggle=""tooltip"" data-placement=""left"" title=""Add to favorites""><i class=""ti-heart""></i><span>Add to favorites</span></a></li>
        <li><a href=""#0"" class=""tooltip-1"" data-toggle=""tooltip"" data-placement=""left"" title=""Add to compare""><i class=""ti-control-shuffle""></i><span>Add to compare</span></a></li>
        <li><a href=""#0"" class=""tooltip-1"" data-toggle=""tooltip"" data-placement=""left"" title=""Add to cart""><i class=""ti-shopping-cart""></i><span>Add to cart</span></a></li>
    </ul>
</div>
<!-- /grid_item -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
