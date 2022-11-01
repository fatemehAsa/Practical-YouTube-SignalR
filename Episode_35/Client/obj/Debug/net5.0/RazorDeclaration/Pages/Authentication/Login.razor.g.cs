// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingChat.Client.Pages.Authentication
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
#line 3 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
using BlazingChat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
using BlazingChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{RegisterRedirect:bool}")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
       

	[CascadingParameter]
	public Task<AuthenticationState> authenticationState { get; set; }
	[Parameter]
	public bool RegisterRedirect {get; set;}
	public bool IsLoading {get; set;} = false;

	protected override async Task OnInitializedAsync()
	{
		//Initializing the login details for John Smith

		if(!RegisterRedirect)
		{
			_loginViewModel.EmailAddress = "john.smith@gmail.com";
			_loginViewModel.Password = "john.smith";
		}

		var authState = await authenticationState;
		var user = authState.User;

		if (user.Identity.IsAuthenticated)
		{
			_navigationManager.NavigateTo("/profile");
		}
	}

	async Task OnKeyPress(KeyboardEventArgs args)
	{
		if (args.Key == "Enter")
			await AuthenticateJWT();
	}

	public async Task AuthenticateJWT()
	{
		IsLoading = true;
		AuthenticationResponse authenticationResponse = await _loginViewModel.AuthenticateJWT();
		if (authenticationResponse.Token != string.Empty)
		{
			await _localStorageService.SetItemAsync("jwt_token", authenticationResponse.Token);
			_navigationManager.NavigateTo("/", true);
		}
		else
		{
			_toastService.ShowError("Invalid username or password");
		}
		IsLoading = false;
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginViewModel _loginViewModel { get; set; }
    }
}
#pragma warning restore 1591
