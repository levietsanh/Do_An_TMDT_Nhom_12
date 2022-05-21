#pragma checksum "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5e177264b13b6b9fd39444e0457f67fe4e73fa"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
using Shop.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
using Shop.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mycart")]
    public partial class MyCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .small-container {
        max-width: 1080px;
        margin: auto;
        padding-left: 10px;
        padding-right: 10px;
    }

    .cart-page {
        margin: 20px auto;
    }

    table {
        width: 100%;
        border-collapse: collapse;
    }

    .cart-info {
        display: flex;
        flex-wrap: wrap;
    }

    th {
        text-align: left;
        padding: 5px;
        color: #ffffff;
        background: #808080;
        font-weight: normal;
    }

    td {
        padding: 10px 5px;
    }

        td input {
            width: 40px;
            height: 30px;
            padding: 5px;
        }

        td a {
            color: #ff523b;
            font-size: 12px;
        }

        td img {
            width: 80px;
            height: 80px;
            margin-right: 10px;
        }

    .total-price {
        display: flex;
        justify-content: flex-end;
    }

        .total-price table {
            border-top: 3px solid #ff523b;
            width: 100%;
            max-width: 400px;
        }

    td:last-child {
        text-align: right;
    }

    th:last-child {
        text-align: right;
    }
</style>

");
            __builder.AddMarkupContent(1, "<style>\r\n\r\n    input[type=radio] {\r\n        border: 0px;\r\n        width: 20%;\r\n        height: 1em;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "padding:10px 0px 0px 10px; text-align:right;");
#nullable restore
#line 91 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
     if (@userName != null && @userEmail != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "span");
            __builder.AddMarkupContent(5, "<span style=\"border:1px ridge #ff523b;background-color:#ff6a00;border-radius:10px;color:#ffffff;padding:3px;\">My Cart</span>\r\n            &nbsp;&nbsp;\r\n            ");
            __builder.OpenElement(6, "b");
            __builder.AddMarkupContent(7, "\r\n                Name : ");
#nullable restore
#line 97 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(8, userName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "\r\n                &nbsp;&nbsp;\r\n                Email : ");
#nullable restore
#line 99 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(10, userEmail);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "\r\n                &nbsp;&nbsp;\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
     if (@myCart != null && @myCart.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "value", "Clear");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                               Clear_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Clear");
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "small-container cart-page");
#nullable restore
#line 112 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
     if (@myCart != null && @myCart.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddMarkupContent(22, "<tr><th>Product</th>\r\n                <th>Remove</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n                <th>Subtotal</th></tr>");
#nullable restore
#line 122 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
             foreach (var cart in myCart)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "cart-info");
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", "http://localhost:57478/" + (
#nullable restore
#line 127 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                              cart.ProductImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "alt", "Product Photo");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.OpenElement(32, "p");
#nullable restore
#line 129 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(33, cart.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                     (() => RemoveFromCart_Click(cart))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "style", "cursor:pointer; color: red;");
            __builder.AddContent(39, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, "$");
#nullable restore
#line 134 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(43, cart.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "number");
            __builder.AddAttribute(48, "min", "1");
            __builder.AddAttribute(49, "max", 
#nullable restore
#line 135 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                 cart.AvailableStock

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                                                 onQuantityChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "style", "width:60px;");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                    cart.Quantity

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cart.Quantity = __value, cart.Quantity, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, "$");
#nullable restore
#line 136 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(57, cart.Price*cart.Quantity);

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, ".00");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 138 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "total-price");
            __builder.OpenElement(61, "table");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "<td>Subtotal</td>\r\n                    ");
            __builder.OpenElement(64, "td");
            __builder.AddMarkupContent(65, "\r\n                        $");
#nullable restore
#line 146 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(66, subTotal);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, ".00\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "<td>Shipping Charges</td>\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, "$");
#nullable restore
#line 151 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(73, shippingCharges);

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, ".00");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "<td>Total</td>\r\n                    ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, "$");
#nullable restore
#line 155 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder.AddContent(80, finalTotal);

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, ".00");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "tr");
            __builder.AddMarkupContent(84, "<td>Shipping Address</td>\r\n                    ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "textarea");
            __builder.AddAttribute(87, "rows", "3");
            __builder.AddAttribute(88, "cols", "30");
            __builder.AddAttribute(89, "name", "shippingaddress");
            __builder.AddAttribute(90, "placeholder", "Shipping Address");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 160 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                                                  shippingAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shippingAddress = __value, shippingAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "tr");
            __builder.AddMarkupContent(95, "<td style=\"vertical-align:top;\">PaymentMode  </td>\r\n                    ");
            __builder.OpenElement(96, "td");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "style", "text-align:left;margin:0px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(99);
            __builder.AddAttribute(100, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 168 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                             paymentModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.Shopping.Web.Pages.MyCart.TypeInference.CreateInputRadioGroup_0(__builder2, 102, 103, 
#nullable restore
#line 169 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                              paymentModel.Name

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => paymentModel.Name = __value, paymentModel.Name)), 105, () => paymentModel.Name, 106, (__builder3) => {
#nullable restore
#line 170 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                     foreach (var option in rdOptions)
                                        {

#line default
#line hidden
#nullable disable
                    __Blazor.Shopping.Web.Pages.MyCart.TypeInference.CreateInputRadio_1(__builder3, 107, 108, 
#nullable restore
#line 172 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                           option

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 172 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
__builder3.AddContent(109, option);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(110, " <br>");
#nullable restore
#line 173 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                        }

#line default
#line hidden
#nullable disable
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "tr");
            __builder.AddMarkupContent(113, "<td></td>\r\n                    ");
            __builder.OpenElement(114, "td");
#nullable restore
#line 184 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                         if (@paymentModel.Name == "Stripe")
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(115, "div");
            __builder.OpenElement(116, "table");
            __builder.OpenElement(117, "tr");
            __builder.AddMarkupContent(118, "<td>\r\n                                            Card Number\r\n                                        </td>\r\n                                        ");
            __builder.OpenElement(119, "td");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "type", "email");
            __builder.AddAttribute(122, "name", "email");
            __builder.AddAttribute(123, "placeholder", "CardNumber");
            __builder.AddAttribute(124, "autocomplete", "off");
            __builder.AddAttribute(125, "style", "width: 150px;");
            __builder.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 193 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                                             Stripecard_Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Stripecard_Number = __value, Stripecard_Number));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                                    ");
            __builder.OpenElement(129, "tr");
            __builder.AddMarkupContent(130, "<td>\r\n                                            Exp Month\r\n                                        </td>\r\n                                        ");
            __builder.OpenElement(131, "td");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "type", "number");
            __builder.AddAttribute(134, "name", "txtExpMonth");
            __builder.AddAttribute(135, "min", "0");
            __builder.AddAttribute(136, "placeholder", "ExpMonth");
            __builder.AddAttribute(137, "autocomplete", "off");
            __builder.AddAttribute(138, "style", "width:150px;");
            __builder.AddAttribute(139, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 201 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                           Stripeexp_Month

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Stripeexp_Month = __value, Stripeexp_Month, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                                    ");
            __builder.OpenElement(142, "tr");
            __builder.AddMarkupContent(143, "<td>\r\n                                            Exp Year\r\n                                        </td>\r\n                                        ");
            __builder.OpenElement(144, "td");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "number");
            __builder.AddAttribute(147, "name", "txtExpYear");
            __builder.AddAttribute(148, "min", "0");
            __builder.AddAttribute(149, "placeholder", "ExpYear");
            __builder.AddAttribute(150, "autocomplete", "off");
            __builder.AddAttribute(151, "style", "width: 150px;");
            __builder.AddAttribute(152, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 209 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                          Stripeexp_Year

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(153, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Stripeexp_Year = __value, Stripeexp_Year, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                                    ");
            __builder.OpenElement(155, "tr");
            __builder.AddMarkupContent(156, "<td>\r\n                                            CVC\r\n                                        </td>\r\n                                        ");
            __builder.OpenElement(157, "td");
            __builder.OpenElement(158, "input");
            __builder.AddAttribute(159, "type", "email");
            __builder.AddAttribute(160, "name", "email");
            __builder.AddAttribute(161, "placeholder", "CVC");
            __builder.AddAttribute(162, "autocomplete", "off");
            __builder.AddAttribute(163, "style", "width: 150px;");
            __builder.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 217 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                                      Stripe_Cvc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Stripe_Cvc = __value, Stripe_Cvc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 222 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                ");
            __builder.OpenElement(167, "tr");
            __builder.AddMarkupContent(168, "<td></td>\r\n                    ");
            __builder.OpenElement(169, "td");
            __builder.OpenElement(170, "button");
            __builder.AddAttribute(171, "type", "button");
            __builder.AddAttribute(172, "value", "Checkout");
            __builder.AddAttribute(173, "class", "btn btn-primary");
            __builder.AddAttribute(174, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 228 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
                                                                                                  Checkout_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(175, "Checkout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 233 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(176, "<hr>\r\n        ");
            __builder.AddMarkupContent(177, "<div style=\"text-align:center;\"><img src=\"./images/empty_cart.jpg\"></div>");
#nullable restore
#line 240 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 244 "C:\Users\levie\source\repos\ShoppingApp\ShoppingApp\ShoppingCart\Shopping.Web\Pages\MyCart.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }

    public List<CartModel> myCart { get; set; }
    public string shippingAddress { get; set; }
    public string paymentMode { get; set; }
    public string userName { get; set; }
    public string userEmail { get; set; }
    public int subTotal { get; set; }
    public int shippingCharges { get; set; }
    public int finalTotal { get; set; }
    public bool IsUserLoggedIn = false;
    public string Stripecard_Number { get; set; }
    public int Stripeexp_Month { get; set; }
    public int Stripeexp_Year { get; set; }
    public string Stripe_Cvc { get; set; }

    PaymentModeModel paymentModel = new PaymentModeModel()
    {
        Name = "CashOnDelivery" // default value
    };

    List<string> rdOptions = new List<string> { "CashOnDelivery", "PayPal", "Stripe"};

    protected override Task OnInitializedAsync()
    {
        shippingCharges = 25;
        subTotal = 0;
        paymentMode = "Cash on Delivery";

        return base.OnInitializedAsync();
    }

    private async Task RemoveFromCart_Click(CartModel cartItem)
    {
        myCart.Remove(cartItem);
        await sessionStorage.SetAsync("myCart", myCart);
        onQuantityChange();

        await notify.InvokeAsync();
    }
    private async Task Clear_Click()
    {
        myCart = new List<CartModel>();
        await sessionStorage.DeleteAsync("myCart");
        await notify.InvokeAsync();
    }

    private async Task Checkout_Click()
    {
        if (myCart != null && myCart.Count > 0)
        {
            myCart.FirstOrDefault().ShippingAddress = shippingAddress;
            myCart.FirstOrDefault().ShippingCharges = shippingCharges;
            myCart.FirstOrDefault().SubTotal = subTotal;
            myCart.FirstOrDefault().PaymentMode = paymentModel.Name;

            if (paymentModel.Name== "PayPal")
            {
                myCart.FirstOrDefault().PayPalPayment = finalTotal;
                myCart.FirstOrDefault().PaymentMode = paymentModel.Name;
            }
            if (paymentModel.Name == "Stripe")
            {
                myCart.FirstOrDefault().Stripecard_Number = Stripecard_Number;
                myCart.FirstOrDefault().Stripeexp_Month = Stripeexp_Month;
                myCart.FirstOrDefault().Stripeexp_Year = Stripeexp_Year;
                myCart.FirstOrDefault().Stripe_Cvc = Stripe_Cvc;
                myCart.FirstOrDefault().Stripe_Value = finalTotal;
                myCart.FirstOrDefault().PaymentMode = paymentModel.Name;
            }


            var session_userKey = await sessionStorage.GetAsync<string>("userKey");
            if (session_userKey.Success)
            {
                myCart.FirstOrDefault().UserId = Convert.ToInt32(session_userKey.Value);
            }

            await sessionStorage.SetAsync("myCart", myCart);

            IsUserLoggedIn = await userPanelService.IsUserLoggedIn();
            if (IsUserLoggedIn)
            {
                var response = await userPanelService.Checkout(myCart);
                if (response != null)
                {
                    myCart.Clear();
                    await sessionStorage.SetAsync("myCart", myCart);
                    await sessionStorage.SetAsync("latestOrder", response.Message);
                    await notify.InvokeAsync();
                    navManager.NavigateTo("myaccount");
                }
            }
            else
            {
                await sessionStorage.SetAsync("checkoutAlert", "** Note : Login / Register to place your order !!");
                navManager.NavigateTo("login");
            }
        }
    }

    private void onQuantityChange()
    {
        finalTotal = 0;
        subTotal = 0;
        foreach (var cart_item in myCart)
        {
            subTotal = subTotal + (cart_item.Price * cart_item.Quantity);
        }
        finalTotal = subTotal + shippingCharges;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");
            if (result.Success)
            {
                myCart = result.Value;
                foreach (var cart_item in myCart)
                {
                    subTotal = subTotal + (cart_item.Price * cart_item.Quantity);
                }

                if (myCart != null && myCart.Count > 0)
                {
                    shippingAddress = myCart.FirstOrDefault().ShippingAddress;
                }
            }

            finalTotal = subTotal + shippingCharges;

            var session_userName = await sessionStorage.GetAsync<string>("userName");
            var session_userEmail = await sessionStorage.GetAsync<string>("userEmail");
            if (session_userName.Success && session_userEmail.Success)
            {
                userName = session_userName.Value;
                userEmail = session_userEmail.Value;
            }

            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
    }
}
namespace __Blazor.Shopping.Web.Pages.MyCart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591