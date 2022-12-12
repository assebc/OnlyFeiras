#pragma checksum "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd787652dd7d11879305fd5e8296e45827791cf4"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlyFeiras.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using OnlyFeiras;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\_Imports.razor"
using OnlyFeiras.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "topnav");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<a class=\"logo\" href><img src=\"assets/logo.svg\" alt=\"OnlyFeiras\" width=\"217\" height=\"63\"></a>\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n                ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "grid-container-authorized");
                __builder2.AddMarkupContent(9, "\r\n                    ");
                __builder2.AddMarkupContent(10, @"<div class=""navbar-icons"">

                        <a class=""icon"" href><img src=""assets/fav.svg"" alt=""Feiravoritos"" height=""25""></a>

                        <a class=""icon"" href><img src=""assets/stall-logo.svg"" alt=""Banca"" height=""25""></a>

                        <a class=""icon"" href><img src=""assets/shopping cart.svg"" alt=""Carrinho de Compras"" height=""25""></a>
                    </div>

                    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "user-info");
                __builder2.AddMarkupContent(13, "\r\n\r\n                        ");
                __builder2.OpenElement(14, "a");
                __builder2.AddAttribute(15, "class", "black txt-mid");
                __builder2.AddContent(16, 
#nullable restore
#line 18 "C:\Users\Nitro\dev\OnlyFeiras\OnlyFeiras\Shared\NavBar.razor"
                                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        \r\n                        ");
                __builder2.AddMarkupContent(18, @"<div class=""dropdown"">
                            <span class=""avatar""></span>
                            <div class=""dropdown-content"">
                                <a href=""Identity/Account/Manage"">Definições</a>
                                <form method=""post"" action=""Identity/Account/LogOut"">
                                    <button type=""submit"">Log out</button>
                                </form>
                            </div>
                        </div>
                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
            }
            ));
            __builder.AddAttribute(21, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.AddMarkupContent(23, "<div class=\"grid-container auth\">\r\n                    <a class=\"black txt-mid\" href=\"Identity/Account/Login\">Entrar</a>\r\n                    <a class=\"blue txt-smaller\" href=\"Identity/Account/Register\">Registar</a>\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
