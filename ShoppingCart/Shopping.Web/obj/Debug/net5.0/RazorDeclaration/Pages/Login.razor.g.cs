// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Shopping.Web.Pages
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
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Login.razor"
using Shop.Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Login.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Login.razor"
       
    [CascadingParameter]
    public EventCallback notify { get; set; }

    public LoginModel loginModel { get; set; }
    public string alertMessage { get; set; }

    protected override Task OnInitializedAsync()
    {
        loginModel = new LoginModel();
        return base.OnInitializedAsync();
    }

    private async Task Login_Click()
    {
        var response = await userPanelService.LoginUser(loginModel);
        if (response.Status)
        {
            var user_response = response.Message.Split("|");
            await sessionStorage.SetAsync("userKey", user_response[0]);
            await sessionStorage.SetAsync("userName", user_response[1]);
            await sessionStorage.SetAsync("userEmail", user_response[2]);
            await notify.InvokeAsync();
            navManager.NavigateTo("/");
        }
        else
        {
            alertMessage = response.Message;
        }
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var login_session = await userPanelService.IsUserLoggedIn();
            if (login_session)
            {
                navManager.NavigateTo("/");
            }

            var checkout_session = await sessionStorage.GetAsync<string>("checkoutAlert");
            if (checkout_session.Success)
            {
                this.alertMessage = checkout_session.Value;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
#pragma warning restore 1591
