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
#nullable restore
#line 2 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Index - Copy.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Index - Copy.razor"
using Shop.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\Projects\ShoppingApp\ShoppingCart\Shopping.Web\Pages\Index - Copy.razor"
      

    public List<CategoryModel> categories { get; set; }
    public List<ProductModel> products { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetCatgories();
        await GetProducts();
    }

    private async Task GetCatgories()
    {
        categories = await userPanelService.GetCategories();
    }

    private async Task GetProducts()
    {
        products = await userPanelService.GetProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
#pragma warning restore 1591
