#pragma checksum "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1bb2f6d61960005254297ba44903c6b1ecd55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1bb2f6d61960005254297ba44903c6b1ecd55e", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0450f18fa0634f63993e1b9802e173cbc65ef672", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SliderItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"carousel-home\">  \r\n    <div class=\"owl-carousel owl-theme\"> \r\n       \r\n");
#nullable restore
#line 5 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
         foreach (var item in Model)
        {
            string positionClass = "justify-content-md-end";
            string textClass = "text-right";


            if (item.Position==Repository.Enums.SliderPosition.Left)
            {
                positionClass= "justify-content-md-start";
                textClass = "text-left";
            }
            if (item.Position== Repository.Enums.SliderPosition.Center)
            {
                positionClass = "justify-content-md-center";
                textClass = "text-center";
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"owl-slide cover\"");
            BeginWriteAttribute("style", " style=\"", 735, "\"", 785, 4);
            WriteAttributeValue("", 743, "background-image:", 743, 17, true);
            WriteAttributeValue(" ", 760, "url(uploads/", 761, 13, true);
#nullable restore
#line 22 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 773, item.Image, 773, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 784, ")", 784, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"opacity-mask d-flex align-items-center\" data-opacity-mask=\"rgba(0, 0, 0, 0.5)\">\r\n                    <div class=\"container\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 971, "\"", 1021, 4);
            WriteAttributeValue("", 979, "row", 979, 3, true);
            WriteAttributeValue(" ", 982, "justify-content-center", 983, 23, true);
#nullable restore
#line 25 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue(" ", 1005, positionClass, 1006, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1020, "", 1021, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"col-lg-6 static\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 1120, "\"", 1155, 3);
            WriteAttributeValue("", 1128, "slide-text", 1128, 10, true);
#nullable restore
#line 27 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue(" ", 1138, textClass, 1139, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1149, "white", 1150, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h2 class=\"owl-slide-animated owl-slide-title\">");
#nullable restore
#line 28 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
                                                                              Write(Html.Raw(@item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <p class=\"owl-slide-animated owl-slide-subtitle\">\r\n                                        ");
#nullable restore
#line 30 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
                                   Write(item.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                                    </p>\r\n");
#nullable restore
#line 32 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
                                     if (!string.IsNullOrEmpty(item.EndPoint))
                                    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"owl-slide-animated owl-slide-cta\">\r\n                                            <a class=\"btn_1\"");
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1748, 1);
#nullable restore
#line 35 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1734, item.EndPoint, 1734, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\"> ");
#nullable restore
#line 35 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
                                                                                             Write(item.ActionTest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div> \r\n");
#nullable restore
#line 37 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
                                    }  

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\Professional\source\repos\Albina\Albina\Views\Shared\Components\Slider\Default.cshtml"
            
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div id=\"icon_drag_mobile\"></div>\r\n</div>\r\n<!--/carousel-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SliderItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
