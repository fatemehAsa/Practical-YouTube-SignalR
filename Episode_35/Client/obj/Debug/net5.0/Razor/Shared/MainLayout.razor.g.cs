#pragma checksum "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cdb71bfaa51da559e00c573baadcdadd6cbed9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingChat.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using BlazingChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using BlazingChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
using BlazingChat.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
using BlazingChat.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-2ppgf111ss");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-2ppgf111ss");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazingChat.Client.Shared.NavMenu>(8);
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(9, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<p style=\"font-size: large; font-weight: bolder; color: white;\" b-2ppgf111ss>\r\n\t\t\t\t\tThe app is getting authorized...\r\n\t\t\t\t</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\t");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(12);
            __builder.AddAttribute(13, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 22 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
                              ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
                             3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 24 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
                              IconType.FontAwesome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "SuccessClass", "success-toast-override");
            __builder.AddAttribute(17, "SuccessIcon", "fa fa-thumbs-up");
            __builder.AddAttribute(18, "ErrorIcon", "fa fa-bug");
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\t");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "main");
            __builder.AddAttribute(22, "b-2ppgf111ss");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "top-row px-4");
            __builder.AddAttribute(25, "b-2ppgf111ss");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(26);
            __builder.AddAttribute(27, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "h4");
                __builder2.AddAttribute(29, "b-2ppgf111ss");
                __builder2.OpenElement(30, "b");
                __builder2.AddAttribute(31, "b-2ppgf111ss");
                __builder2.AddContent(32, "Hello, ");
                __builder2.AddContent(33, 
#nullable restore
#line 32 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
                                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, " &nbsp; &nbsp;\r\n\t\t\t\t\t");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-danger");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
                                                             LogoutUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "b-2ppgf111ss");
                __builder2.AddContent(39, "Logout");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\t\t");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "content px-4");
            __builder.AddAttribute(43, "b-2ppgf111ss");
            __builder.AddContent(44, 
#nullable restore
#line 38 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Shared\MainLayout.razor"
       

	protected override async Task OnInitializedAsync()
	{
		//getting the current authenticated user for the app
		var jwtToken = await _localStorageService.GetItemAsStringAsync("jwt_token");
		if (jwtToken == null) return;

		User currentUser = await _loginViewModel.GetUserByJWTAsync(jwtToken);

		if (currentUser != null)
		{
			//setting the themeName parameter for JS function
			var themeName = currentUser.DarkTheme == 1 ? "dark" : "light";
			//calling the JS function
			var module = await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "./js/site.js");
			await module.InvokeVoidAsync("setTheme", themeName);
		}
		await base.OnInitializedAsync();
	}

	private async Task LogoutUser()
	{
		//await _httpClient.GetAsync("user/logoutuser");
		await _localStorageService.RemoveItemAsync("jwt_token");
		_navigationManager.NavigateTo("/", true);
	}

	private void LoginUser()
	{
		_navigationManager.NavigateTo("/", true);
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginViewModel _loginViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
