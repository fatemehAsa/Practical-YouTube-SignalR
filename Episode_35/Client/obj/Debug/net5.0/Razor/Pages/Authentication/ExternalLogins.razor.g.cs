#pragma checksum "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6dfb2c8723406d307c57f64375703a94dc9b726"
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
#line 1 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
using BlazingChat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
using BlazingChat.Shared;

#line default
#line hidden
#nullable disable
    public partial class ExternalLogins : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "btn btn-block btn-social btn-twitter");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
                                                              TwitterJWT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "href", "");
            __builder.AddMarkupContent(6, "<span class=\"fa fa-twitter\"></span> ");
            __builder.AddMarkupContent(7, "<b>Sign in with Twitter</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n<br>\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-xl-6 col-md-8 col-12");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "btn btn-block btn-social btn-facebook");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
                                                               FacebookJWT

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "href", "");
            __builder.AddMarkupContent(15, "<span class=\"fa fa-facebook\"></span> ");
            __builder.AddMarkupContent(16, "<b>Sign in with Facebook</b>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<hr class=\"white-horizontal-line\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Authentication\ExternalLogins.razor"
       

    protected override async Task OnInitializedAsync()
    {
        if (QueryHelpers.ParseQuery(_navigationManager.Uri).TryGetValue("oauth_verifier", out var _oAuthVerifier))
        {
            var twitterRequestTokenResponse = await _localStorageService.GetItemAsync<TwitterRequestTokenResponse>("twitterRequestTokenResponse");
            twitterRequestTokenResponse.OAuthVerifier = _oAuthVerifier;

            string token = await _loginViewModel.GetTwitterJWTAsync(twitterRequestTokenResponse);
            await _localStorageService.SetItemAsync<string>("jwt_token", token);

            await _localStorageService.RemoveItemAsync("twitterRequestTokenResponse");

            _navigationManager.NavigateTo("/", true);
        }

        var facebookUri = _navigationManager.Uri.Split('#');
        if (facebookUri.Length > 1 && QueryHelpers.ParseQuery(facebookUri[1]).TryGetValue("access_token", out var _accessToken))
        {
            string token = await _loginViewModel.GetFacebookJWTAsync(_accessToken);
            await _localStorageService.SetItemAsync<string>("jwt_token", token);

            _navigationManager.NavigateTo("/", true);
        }
    }

    public async Task FacebookJWT()
    {
        var appIdAndRedirectUri = (await _loginViewModel.GetFacebookAppIDAndRedirectUriAsync()).Split('&');

        var accessTokenRequest = $"https://www.facebook.com/v11.0/dialog/oauth";
        accessTokenRequest += "?response_type=token";
        accessTokenRequest += $"&client_id={appIdAndRedirectUri[0]}";
        accessTokenRequest += $"&redirect_uri={appIdAndRedirectUri[1]}";

        _navigationManager.NavigateTo(accessTokenRequest, true);
    }

    public async Task TwitterJWT()
    {
        var twitterRequestTokenResponse = await _loginViewModel.GetTwitterOAuthTokenAsync();
        await _localStorageService.SetItemAsync("twitterRequestTokenResponse", twitterRequestTokenResponse);

        _navigationManager.NavigateTo("https://api.twitter.com/oauth/authorize?oauth_token=" + twitterRequestTokenResponse.OAuthToken);
    }

    public async Task GoogleJWT()
    {
        var appIdAndRedirectUri = (await _loginViewModel.GetGoogleClientIDAndRedirectUriAsync()).Split('&');

        var accessTokenRequest = "https://accounts.google.com/o/oauth2/v2/auth?";
        accessTokenRequest += $"scope=https%3A//www.googleapis.com/auth/drive.metadata.readonly&";
        accessTokenRequest += $"access_type=offline&";
        accessTokenRequest += $"include_granted_scopes=true&";
        accessTokenRequest += $"response_type=code&";
        accessTokenRequest += $"state=state_parameter_passthrough_value&";
        accessTokenRequest += $"client_id={appIdAndRedirectUri[0]}&";
        accessTokenRequest += $"redirect_uri={appIdAndRedirectUri[1]}";

        _navigationManager.NavigateTo(accessTokenRequest, true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginViewModel _loginViewModel { get; set; }
    }
}
#pragma warning restore 1591
