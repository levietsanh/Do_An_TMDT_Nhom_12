#pragma checksum "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3365a9695e784f2f75123f2736dfbbc8c0609033"
// <auto-generated/>
#pragma warning disable 1591
namespace Shopping.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Shopping.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Shopping.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .mainlayout {
        max-width: 900px;
        margin: auto;
        background: white;
        padding: 10px;
    }

    * {
        box-sizing: border-box;
    }

    .header {
        color: black;
        padding: 5px;
        border: 1px groove #808080;
        border-radius: 25px;
        background: linear-gradient(-45deg, #ffd800, #808080, #23a6d5, #f5f542);
        background-size: 400% 400%;
    }

    .footer {
        color: black;
        padding: 15px;
        border: 1px groove #808080;
        border-radius: 25px;
        background: linear-gradient(-45deg, #ffd800, #808080, #23a6d5, #f5f542);
        background-size: 400% 400%;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<style>
    .col-container {
        display: table;
        width: 100%;
        border-radius: 25px;
    }

    .col {
        display: table-cell;
        padding: 16px;
    }

    .divleft {
        float: left;
    }

    .divright {
        float: right;
    }
</style>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mainlayout");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "padding-bottom:25px;");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"divleft\"><i class=\"fa fa-user\"></i> Welcome, Lily Scott</div>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "divright");
            __builder.AddMarkupContent(11, "\r\n\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(12);
            __builder.AddAttribute(13, "href", "/");
            __builder.AddAttribute(14, "style", "padding-left:15px;");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                <i class=\"fa fa-sign-out\"></i>  Logout\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "divright");
            __builder.AddAttribute(21, "style", "padding-left:15px;");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "href", "myaccount");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                MyAccount\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "divright");
            __builder.AddAttribute(31, "style", "padding-left:15px;");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", "register");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                Register\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "divright");
            __builder.AddAttribute(41, "style", "padding-left:15px;");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "href", "login");
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "\r\n                Login\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "header");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-container");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col");
            __builder.AddAttribute(58, "style", "border-radius: 25px;");
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "href", "/");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                    <img src=\"images/shoppingLogo.png\" style=\"cursor:pointer;\">\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n              \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n            ");
            __builder.AddMarkupContent(66, @"<div class=""col"">
                <i class=""fa fa-shopping-cart"" style=""font-size:48px;color:white""><span style=""font-size:20px;vertical-align:top;padding:7px;color:white;border-radius:50%;padding-top:10px;font-weight:bold;""><sup>23</sup></span> </i>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "clearfix");
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.AddContent(72, 
#nullable restore
#line 98 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n    ");
            __builder.AddMarkupContent(75, "<div class=\"footer\">\r\n        &copy; ShoppingCart 2021\r\n    </div>\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591