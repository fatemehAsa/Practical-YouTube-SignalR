#pragma checksum "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea226b94ba2bff895e4cf105ef8ed87f6a1b7561"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingChat.Client.Pages
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
#line 2 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
using BlazingChat.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazingChat.Client.Pages.ActivateMessage>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<h2 class=\"white-text\" b-2kl44fr2k6><b b-2kl44fr2k6>Contacts</b></h2> \r\n<hr class=\"white-horizontal-line\" b-2kl44fr2k6>\r\n\r\n");
            __builder.AddMarkupContent(3, "<div class=\"col-12 row\" b-2kl44fr2k6><input type=\"text\" class=\"col-12 form-control dark-theme-textbox\" placeholder=\"search\" b-2kl44fr2k6></div>\r\n<br b-2kl44fr2k6>");
#nullable restore
#line 15 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
 if (_contactsViewModel.ContactsCount > 0)
{

#line default
#line hidden
#nullable disable
            __Blazor.BlazingChat.Client.Pages.Contacts.TypeInference.CreateVirtualize_0(__builder, 4, 5, 
#nullable restore
#line 17 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                               LoadOnlyVisibleContacts

#line default
#line hidden
#nullable disable
            , 6, (contact) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "style", "height: 50px");
                __builder2.AddAttribute(9, "b-2kl44fr2k6");
                __builder2.OpenElement(10, "a");
                __builder2.AddAttribute(11, "href", "/chat/" + (
#nullable restore
#line 20 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                                contact.ContactId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "class", "list-group-item list-group-item-action flex-column align-items-start contact-list-item");
                __builder2.AddAttribute(13, "b-2kl44fr2k6");
#nullable restore
#line 22 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                     if(contact.FirstName != null)
                    {
                        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, 
#nullable restore
#line 24 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                         contact.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(15, " <span b-2kl44fr2k6></span>");
                __builder2.AddContent(16, 
#nullable restore
#line 24 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                                                           contact.LastName

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 24 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                                                                           
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, 
#nullable restore
#line 28 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                         contact.EmailAddress

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 28 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
                                             
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            , 18, (contact) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<div style=\"height: 50px\" b-2kl44fr2k6><p b-2kl44fr2k6>Loading...</p></div>");
            }
            );
#nullable restore
#line 39 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<br b-2kl44fr2k6>");
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\User\Desktop\KharegiSignalR\BlazingChat\Source Code By Episodes\Episode_35\Client\Pages\Contacts.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }

    [CascadingParameter]
    public Error Error { get; set; }
 
    private async ValueTask<ItemsProviderResult<Contact>> LoadOnlyVisibleContacts(ItemsProviderRequest itemsProviderRequest)
    {
        await _contactsViewModel.LoadOnlyVisibleContactsDB(itemsProviderRequest.StartIndex,itemsProviderRequest.Count);
        return new ItemsProviderResult<Contact>(_contactsViewModel.Contacts, _contactsViewModel.ContactsCount);
    }

    protected override async Task OnInitializedAsync() 
    {
        try
        {
            var authState = await authenticationState;
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                //await _contactsViewModel.LoadAllContactsDemo();
                
                //throw new IndexOutOfRangeException();
                await _contactsViewModel.LoadContactsCountDB();
            }
            else _navigationManager.NavigateTo("/");
        }
        catch (System.Exception ex)
        {
            Error.ProcessError(ex);
        }
    }
    
    private void NavigateToChat()
    {
        _navigationManager.NavigateTo("/chat");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactsViewModel _contactsViewModel { get; set; }
    }
}
namespace __Blazor.BlazingChat.Client.Pages.Contacts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemsProvider", __arg0);
        __builder.AddAttribute(__seq1, "ItemContent", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
