#pragma checksum "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe710d06e09de1d28a1560c23efd79673ddc883"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Interests), @"mvc.1.0.view", @"/Views/Menu/Interests.cshtml")]
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
#line 1 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\_ViewImports.cshtml"
using RestaurantMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\_ViewImports.cshtml"
using RestaurantMenu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe710d06e09de1d28a1560c23efd79673ddc883", @"/Views/Menu/Interests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6f3d97ddc868b82f8c190d482de1013e8ddc45", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Interests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RestaurantMenu.Models.AuditMealType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
  
    ViewData["Title"] = "Interests";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Interests</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        <div class=\"list-group\">\r\n");
#nullable restore
#line 11 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
             foreach (MealType t in MealType.ListAllActiveTypes())
            {
                if (t.IsActive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"list-group-item\"");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 488, 3);
            WriteAttributeValue("", 433, "/menu/", 433, 6, true);
#nullable restore
#line 15 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
WriteAttributeValue("", 439, MealType.GetTypeOfMeal(t.Id).ToLower(), 439, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 478, "/interests", 478, 10, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                                                                                                         Write(MealType.GetTypeOfMeal(t.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 16 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""col-md-9"">
        <p class=""col-md-12"" style=""margin-top:15px;"">
            <a class=""btn btn-primary float-left"" href=""/menu/meals"">Back to Menu</a>
        </p><br /><br /><br>

        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Type
                    </th>
                    <th>
                        Time
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 37 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                 foreach (var m in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                       Write(m.MealType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                           <span>");
#nullable restore
#line 44 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                            Write(m.Time.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 44 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                                           Write(m.Time.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 44 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                                                            Write(m.Time.Second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\abendovska\Downloads\Courses\Back-end\Homework\11. Restaurant menu - Homework\RestaurantMenu\RestaurantMenu\Views\Menu\Interests.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RestaurantMenu.Models.AuditMealType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
