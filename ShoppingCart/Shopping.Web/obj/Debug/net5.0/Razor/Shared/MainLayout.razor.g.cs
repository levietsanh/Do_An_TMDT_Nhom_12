#pragma checksum "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84e98e4d1ab69788dda6231c17fe95077cf7ae9"
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
#line 1 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Shopping.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Shopping.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
using Shop.Web.Services;

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
        color: white;
        padding: 5px;
        border: 1px groove #808080;
        border-radius: 14px;
        background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);
        background-size: 400% 400%;
    }

    .footer {
        color: white;
        padding: 5px;
        border: 1px groove #808080;
        border-radius: 7px;
        background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);
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
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "padding-bottom:25px;");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "divleft");
            __builder.AddAttribute(8, "style", "padding-right: 15px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "href", "/");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "divleft");
#nullable restore
#line 69 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
             if (IsUserLoggedIn)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<i class=\"fa fa-user\"></i>");
            __builder.OpenElement(17, "span");
            __builder.AddContent(18, "Welcome, ");
#nullable restore
#line 71 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
__builder.AddContent(19, LoggedInUserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<i class=\"fa fa-user\"></i>");
            __builder.AddMarkupContent(21, "<span>Welcome,</span>");
#nullable restore
#line 76 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "divright");
#nullable restore
#line 79 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
             if (IsUserLoggedIn)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "padding-left:15px;");
            __builder.AddMarkupContent(27, "<i class=\"fa fa-sign-out\"></i> ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
                                                                 Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "href", "#");
            __builder.AddContent(31, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "divright");
            __builder.AddAttribute(35, "style", "padding-left:15px;");
#nullable restore
#line 87 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
             if (IsUserLoggedIn)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", "myaccount");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                    MyAccount\r\n                ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 92 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "divright");
            __builder.AddAttribute(43, "style", "padding-left:15px;");
#nullable restore
#line 95 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
             if (!IsUserLoggedIn)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "href", "login");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                    Login\r\n                ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 100 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "divright");
            __builder.AddAttribute(51, "style", "padding-left:15px;");
#nullable restore
#line 103 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
             if (!IsUserLoggedIn)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "href", "register");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                    Register\r\n                ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 108 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "header");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-container");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col");
            __builder.AddAttribute(63, "style", "border-radius: 25px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "href", "/");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(67, "<h4 style=\"text-decoration:none; color:white;\">Hill Top Watch</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "col");
#nullable restore
#line 120 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
                 if (cartCount > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "a");
            __builder.AddAttribute(72, "href", "/mycart");
            __builder.OpenElement(73, "i");
            __builder.AddAttribute(74, "class", "fa fa-shopping-cart");
            __builder.AddAttribute(75, "style", "font-size:48px;color:white");
            __builder.OpenElement(76, "span");
            __builder.AddAttribute(77, "style", "font-size:35px;vertical-align:top;padding:7px;color:white;border-radius:50%;padding-top:10px;font-weight:bold;");
            __builder.OpenElement(78, "sup");
#nullable restore
#line 124 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
__builder.AddContent(79, cartCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 127 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "href", "/mycart");
            __builder.OpenElement(82, "i");
            __builder.AddAttribute(83, "class", "fa fa-shopping-cart");
            __builder.AddAttribute(84, "style", "font-size:48px;color:white");
            __builder.OpenElement(85, "span");
            __builder.AddAttribute(86, "style", "font-size:35px;vertical-align:top;padding:7px;color:white;border-radius:50%;padding-top:10px;font-weight:bold;");
            __builder.OpenElement(87, "sup");
#nullable restore
#line 132 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
__builder.AddContent(88, cartCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 135 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "clearfix");
            __Blazor.Shopping.Web.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 92, 93, 
#nullable restore
#line 142 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
                              event_notify

#line default
#line hidden
#nullable disable
            , 94, (__builder2) => {
#nullable restore
#line 143 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
__builder2.AddContent(95, Body);

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n    ");
            __builder.AddMarkupContent(97, "<div class=\"footer\">\r\n        &copy; Hill Top Watch 2022\r\n    </div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 153 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Shared\MainLayout.razor"
      

    public List<CartModel> myCart { get; set; }
    public List<CartModel> myCartClone { get; set; }
    public int cartCount = 0;
    public int oldCartCount = 0;
    public bool IsUserLoggedIn = false;
    public string LoggedInUserName = "User";
    public int layoutState = 0;

    EventCallback event_notify => EventCallback.Factory.Create(this, NotifyLayout);

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    private async Task NotifyLayout()
    {
        IsUserLoggedIn = await userPanelService.IsUserLoggedIn();

        if (IsUserLoggedIn && layoutState == 0)
        {
            var userNameSession = await sessionStorage.GetAsync<string>("userName");
            LoggedInUserName = userNameSession.Value;

            var checkoutSession = await sessionStorage.GetAsync<string>("checkoutAlert");
            if (checkoutSession.Success)
            {
                await sessionStorage.DeleteAsync("checkoutAlert");
                navManager.NavigateTo("/mycart");
            }

            StateHasChanged();
            layoutState++;
        }

        if (layoutState == -1)
        {
            StateHasChanged();
        }

        var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");

        if (result.Success)
        {
            myCart = result.Value;
            cartCount = myCart.Count;
            await sessionStorage.DeleteAsync("updateCartFlag");
            StateHasChanged();
        }
        else
        {
            cartCount = 0;
        }
    }

    private async void Logout()
    {
        await sessionStorage.DeleteAsync("userKey");
        await sessionStorage.DeleteAsync("userName");
        await sessionStorage.DeleteAsync("userEmail");
        await NotifyLayout();
        navManager.NavigateTo("/");
        layoutState = -1;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await NotifyLayout();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
namespace __Blazor.Shopping.Web.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
