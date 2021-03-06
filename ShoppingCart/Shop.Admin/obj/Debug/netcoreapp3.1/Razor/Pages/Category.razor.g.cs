#pragma checksum "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9344bf7f949b2e6ab8dcb10cdfa7702e6e29fa1"
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
#line 1 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\_Imports.razor"
using Shop.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
using Shop.Admin.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Category</h3>\r\n\r\n");
#nullable restore
#line 34 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
 if (categoryModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 37 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 41 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
                          categoryModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 41 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
                                                         SaveCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-12 row");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label class=\"col-2 font-weight-bold\">Name :</label>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control col-3");
                __builder2.AddAttribute(20, "placeholder", "Product Name");
                __builder2.AddAttribute(21, "autocomplete", "off");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
                                                         categoryModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categoryModel.Name = __value, categoryModel.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, @"<div class=""col-12 row"">
                <span class=""col-2""></span>
                <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Save"">
                <span>&nbsp;</span>
                <input type=""submit"" class=""form-control col-1 btn btn-primary"" value=""Clear"">
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 55 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n<hr>\r\n\r\n");
#nullable restore
#line 59 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
 if (categoryList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "    ");
            __builder.AddMarkupContent(31, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 62 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(37, "tbody");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 72 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
             foreach (var cat in categoryList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 75 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
                         cat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 77 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 80 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projects\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Category.razor"
       

    public CategoryModel categoryModel { get; set; }
    public List<CategoryModel> categoryList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        categoryModel = new CategoryModel();
        await GetCatgories();
    }

    private async Task GetCatgories()
    {
        categoryList = await adminPanelService.GetCategories();
    }

    private async Task SaveCategory()
    {
        await adminPanelService.SaveCategory(categoryModel);
        await GetCatgories();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591
