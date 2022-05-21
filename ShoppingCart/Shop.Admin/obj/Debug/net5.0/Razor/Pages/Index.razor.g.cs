#pragma checksum "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c800eedce4ef13dbd8771b69a37022449f1fae5f"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Index.razor"
using Shop.Admin.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Index.razor"
 if (IsAdminLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Hello! Welcome to Admin Panel</h1>");
            __builder.AddMarkupContent(1, @"<div class=""container""><div class=""row""><div class=""col-md-4""><div class=""card card-inverse card-warning p-1""><div class=""card-block bg-warning p-2""><h6 class=""text-uppercase"">Products</h6>
                        <h1 class=""display-1"">13</h1></div></div></div>
            <div class=""col-md-4""><div class=""card card-inverse card-warning p-1""><div class=""card-block bg-info p-2""><h6 class=""text-uppercase"">Category</h6>
                        <h1 class=""display-1"">3</h1></div></div></div>
            <div class=""col-md-4""><div class=""card card-inverse card-warning p-1""><div class=""card-block bg-primary p-2""><h6 class=""text-uppercase"">Manage Customers</h6>
                        <h1 class=""display-1"">3</h1></div></div></div></div></div>");
#nullable restore
#line 47 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Index.razor"
      

    [CascadingParameter]
    public EventCallback notify { get; set; }
    public bool IsAdminLoggedIn = false;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();

            var adminSession = await sessionStorage.GetAsync<string>("adminKey");
            if (adminSession.Success)
            {
                IsAdminLoggedIn = true;
                StateHasChanged();
            }
            else
            {
                navManager.NavigateTo("/login");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591