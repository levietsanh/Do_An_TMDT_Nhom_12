#pragma checksum "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94876aef5d57ca39f5838ca3de62b9c308c6ec7a"
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
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
using Shop.DataModels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
using Shop.Admin.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public partial class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .modal {
        position: fixed;
        z-index: 1;
        padding-top: 100px;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        overflow: hidden;
        background-color: rgb(0,0,0);
        background-color: rgba(0,0,0,0.4);
        display: block;
    }

    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 20px;
        border: 1px solid #888;
        width: 50%;
        overflow: hidden;
    }

    .close {
        color: #aaaaaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
        .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Orders</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body bg-dark");
#nullable restore
#line 51 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
         if (customerOrders == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 54 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-striped table-bordered bg-light");
            __builder.AddMarkupContent(9, @"<thead><tr><th>Order #</th>
                        <th>Total #</th>
                        <th>Order Date #</th>
                        <th style=""width:80px;"">Track?</th>
                        <th style=""width:80px;"">Details?</th></tr></thead>
                ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 68 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                     foreach (var odr in customerOrders)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line 71 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(13, odr.OrderId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                            ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 72 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(16, odr.Total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 73 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(19, odr.CreatedOn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "value", "Track");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                                     (() => Track_Click(odr.OrderId))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "btn btn-secondary");
            __builder.AddAttribute(32, "value", "Detail");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                                        (() => Detail_Click(odr.OrderId))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
 if (showOrderDetail == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-content");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-header");
            __builder.AddMarkupContent(40, "<h5> Order Details  </h5>\r\n                ");
            __builder.OpenElement(41, "span");
            __builder.AddAttribute(42, "class", "close");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                              ToggleOrderDetailPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-body");
#nullable restore
#line 99 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                 if (@myCart != null && @myCart.Count > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "table");
            __builder.AddAttribute(49, "class", "table table-bordered");
#nullable restore
#line 102 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                         foreach (var cart in myCart)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "style", "padding:0px;");
            __builder.OpenElement(53, "img");
            __builder.AddAttribute(54, "src", "http://localhost:57478/" + (
#nullable restore
#line 106 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                      cart.ProductImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "alt", "Product Photo");
            __builder.AddAttribute(56, "style", "width:50px;height:50px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    ");
            __builder.OpenElement(58, "div");
            __builder.OpenElement(59, "p");
#nullable restore
#line 108 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(60, cart.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "style", "padding:0px;");
#nullable restore
#line 111 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(64, cart.Quantity);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, " X ???");
#nullable restore
#line 111 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(66, cart.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "style", "padding:0px;");
            __builder.AddMarkupContent(70, "???");
#nullable restore
#line 112 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(71, cart.Price*cart.Quantity);

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, ".00");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 114 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(73, "table");
            __builder.AddAttribute(74, "style", "width:550px;border:1px ridge #f5750d;");
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, "Subtotal - $");
#nullable restore
#line 119 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(78, subTotal);

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, ".00");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, "Shipping Charges - $");
#nullable restore
#line 120 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(83, shippingCharges);

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, ".00");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "tr");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, "Total - $");
#nullable restore
#line 123 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(89, finalTotal);

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, ".00");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                            ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, "Shipping Address - ");
#nullable restore
#line 124 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(94, shippingAddress);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "tr");
            __builder.OpenElement(97, "td");
            __builder.AddMarkupContent(98, "\r\n                                Payment Mode- ");
#nullable restore
#line 128 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(99, paymentMode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 132 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "modal-footer");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "button");
            __builder.AddAttribute(105, "class", "btn btn-secondary");
            __builder.AddAttribute(106, "value", "Close");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                       ToggleOrderDetailPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
 if (showTrackOrder == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "modal-content");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "modal-header");
            __builder.AddMarkupContent(114, "<h5>Track Order  </h5>\r\n                ");
            __builder.OpenElement(115, "span");
            __builder.AddAttribute(116, "class", "close");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 147 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                              ToggleTrackOrderPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(118, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "modal-body");
            __builder.OpenElement(122, "div");
            __builder.AddMarkupContent(123, "<label>Select Status :</label>");
#nullable restore
#line 152 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                     if (shippingList != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(124, "select");
            __builder.AddAttribute(125, "class", "form-control");
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 154 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                 ShippingStatusClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(127, "option");
            __builder.AddAttribute(128, "value");
            __builder.AddContent(129, "-- Select--");
            __builder.CloseElement();
#nullable restore
#line 156 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                             foreach (var cat in shippingList)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(130, "option");
            __builder.AddAttribute(131, "value", 
#nullable restore
#line 158 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                cat.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 158 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(132, cat.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 159 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 161 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(133, "div");
            __builder.AddMarkupContent(134, "<label>Comment :</label>\r\n                        ");
            __builder.OpenElement(135, "input");
            __builder.AddAttribute(136, "type", "text");
            __builder.AddAttribute(137, "class", "form-control");
            __builder.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 164 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                  shippingComments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shippingComments = __value, shippingComments));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n                ");
            __builder.OpenElement(141, "span");
            __builder.AddAttribute(142, "style", "background-color:yellow;");
#nullable restore
#line 168 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(143, shippingText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "button");
            __builder.AddAttribute(147, "class", "btn btn-primary");
            __builder.AddAttribute(148, "value", "Update");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 169 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                      UpdateShippingStatusForOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                <hr>");
#nullable restore
#line 171 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                 if (shippingUpdates != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(151, "table");
            __builder.OpenElement(152, "tbody");
#nullable restore
#line 175 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                             foreach (var odr in shippingUpdates)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(153, "tr");
            __builder.OpenElement(154, "td");
#nullable restore
#line 178 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(155, odr);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 180 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 183 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "modal-footer");
            __builder.OpenElement(159, "input");
            __builder.AddAttribute(160, "type", "button");
            __builder.AddAttribute(161, "class", "btn btn-primary");
            __builder.AddAttribute(162, "value", "Close");
            __builder.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 187 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                     ToggleTrackOrderPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 191 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
 if (successPoupup == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "modal");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "modal-content");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "modal-header");
            __builder.AddMarkupContent(170, "\r\n                Alert  ");
            __builder.OpenElement(171, "span");
            __builder.AddAttribute(172, "class", "close");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 198 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                     ToggleSuccessPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(174, "??");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n            ");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "modal-body");
#nullable restore
#line 201 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
__builder.AddContent(178, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n            ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "modal-footer");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "button");
            __builder.AddAttribute(184, "class", "btn btn-primary");
            __builder.AddAttribute(185, "value", "Close");
            __builder.AddAttribute(186, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 204 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
                                                                                     ToggleSuccessPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 208 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 211 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shop.Admin\Pages\Orders.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }

    public List<ShippingModel> shippingList { get; set; }
    public List<string> shippingUpdates { get; set; }
    public string shippingText { get; set; }
    public string shippingComments { get; set; } = string.Empty;
    public string orderNumber { get; set; }

    private List<CustomerOrder> customerOrders;
    public List<CartModel> myCart { get; set; }
    public string shippingAddress { get; set; }
    public int subTotal { get; set; }
    public int shippingCharges { get; set; }
    public int finalTotal { get; set; }
    public string paymentMode { get; set; }

    IReadOnlyList<IBrowserFile> selectedFiles;
    List<string> imageUrls = new List<string>();
    public bool showOrderDetail = false;
    public bool successPoupup = false;
    public bool showTrackOrder = false;
    string Message = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await GetOrders();
        await GetShippingStatus();
    }

    private async Task GetShippingStatus()
    {
        shippingList = await adminPanelService.GetShippingStatus();
    }

    private void ShippingStatusClicked(ChangeEventArgs shippingEvent)
    {
        shippingText = string.Empty;

        int sid = Convert.ToInt32(shippingEvent.Value);
        foreach (var item in shippingList)
        {
            if (item.Id == sid)
            {
                shippingText = item.Name;
                break;
            }
        }

        shippingText = shippingText + "-" + shippingComments;
    }

    private async Task UpdateShippingStatusForOrder()
    {
        shippingUpdates= await adminPanelService.UpdateShippingStatusForOrder(orderNumber, shippingText);
    }

    private async Task GetShippingStatusForOrder()
    {
        shippingUpdates= await adminPanelService.GetShippingStatusForOrder(orderNumber);
        await GetShippingStatus();
    }

    private async Task GetOrders()
    {
        customerOrders = await adminPanelService.GetOrders();
    }

    private void ToggleOrderDetailPopup()
    {
        showOrderDetail = showOrderDetail == true ? false : true;
    }

    private void ToggleSuccessPopup()
    {
        successPoupup = successPoupup == true ? false : true;
    }

    private async Task Detail_Click(string order_number)
    {
        myCart = await adminPanelService.GetOrderDetails(order_number);
        if (myCart != null && myCart.Count > 0)
        {
            shippingAddress = myCart.FirstOrDefault().ShippingAddress;
            shippingCharges = myCart.FirstOrDefault().ShippingCharges;
            subTotal = myCart.FirstOrDefault().SubTotal;
            finalTotal = myCart.FirstOrDefault().Total;
            paymentMode = myCart.FirstOrDefault().PaymentMode;
        }

        ToggleOrderDetailPopup();
    }

    private void Track_Click(string order_number)
    {
        orderNumber = order_number;
        shippingText = string.Empty;
        GetShippingStatusForOrder();
        ToggleTrackOrderPopup();
    }

    private void ToggleTrackOrderPopup()
    {
        showTrackOrder = showTrackOrder == true ? false : true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591
