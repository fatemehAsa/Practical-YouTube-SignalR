#pragma checksum "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08885e8a2b2f29b38d625404610e3fedc32965d3"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<hr class=\"white-horizontal-line\">\r\n");
            __builder.AddMarkupContent(1, "<div class=\"col-12\"><h2 class=\"white-text\"><b>Login</b></h2></div>\r\n");
            __builder.OpenComponent<BlazorPro.Spinkit.SpinLoader>(2);
            __builder.AddAttribute(3, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                       IsLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "LoadingTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-12");
                __builder2.AddAttribute(7, "style", "background-color: lightgray; height:400px; vertical-align:middle");
                __builder2.AddMarkupContent(8, "<br><br>\r\n            ");
                __builder2.OpenComponent<BlazorPro.Spinkit.Chase>(9);
                __builder2.AddAttribute(10, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Color", "blue");
                __builder2.AddAttribute(12, "Size", "70px");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(13, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "<hr class=\"white-horizontal-line\">\r\n\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
                __builder2.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                          _loginViewModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                                                           AuthenticateJWT

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n\t\t\t");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\t\t\t");
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "col-xl-6 col-md-8 col-12");
                    __builder3.OpenElement(25, "input");
                    __builder3.AddAttribute(26, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                                    OnKeyPress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "type", "text");
                    __builder3.AddAttribute(28, "class", "form-control dark-theme-textbox");
                    __builder3.AddAttribute(29, "placeholder", "email address");
                    __builder3.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                                                                   _loginViewModel.EmailAddress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.EmailAddress = __value, _loginViewModel.EmailAddress));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n\t\t\t<br>\r\n\t\t\t");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "col-xl-6 col-md-8 col-12");
                    __builder3.OpenElement(35, "input");
                    __builder3.AddAttribute(36, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                                    OnKeyPress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "type", "password");
                    __builder3.AddAttribute(38, "class", "form-control dark-theme-textbox");
                    __builder3.AddAttribute(39, "placeholder", "password");
                    __builder3.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\Login.razor"
                                                                       _loginViewModel.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.Password = __value, _loginViewModel.Password));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n\t\t\t<br>\r\n\t\t\t");
                    __builder3.AddMarkupContent(43, @"<div class=""col-xl-6 col-md-8 col-12 row""><div class=""col-xl-2 col-lg-2 col-md-6 col-sm-3 col-3""><button type=""submit"" class=""btn btn-danger"">Login</button></div>
				<div class=""col-xl-5 col-lg-5 col-md-6 col-sm-9 col-9""><a style=""font-weight: bold;"" href=""/createaccount"">Create an account</a></div></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\t\t<hr class=\"white-horizontal-line\">\r\n\t\t");
                __builder2.OpenComponent<BlazingChat.Client.Pages.Authentication.ExternalLogins>(45);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n\t\t");
                __builder2.AddMarkupContent(47, "<div class=\"col-12\"><p style=\"font-size: larger;\" class=\"white-text\">\r\n\t\t\t\tBlazingChat is a sample Blazor WebAssembly app made for the community\r\n\t\t\t</p></div>");
            }
            ));
            __builder.CloseComponent();
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
