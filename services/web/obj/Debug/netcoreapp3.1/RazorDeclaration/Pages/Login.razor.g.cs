#pragma checksum "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38fc9fc990b46c995d97c187076b5676a2306b5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/_Imports.razor"
using web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor"
using web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor"
using Grpc=AuthApp.Internal.Delivery.Grpc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor"
using StateManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor"
using Grpc.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Login.razor"
      
    User user = new User();
    ErrorModal errorModal = new ErrorModal();
    protected override void OnInitialized() {
        if(!string.IsNullOrEmpty(JwtState.Jwt))
            NavigationManager.NavigateTo("");
    }
    async void ValidFormSubmitted(EditContext editContext) {
        try{
            Grpc.LoginResp loginResponse = authService.Login(user);
            await JSRuntime.InvokeAsync<string>("blazorExtensions.WriteCookie", "jwt", loginResponse.Jwt, 1);
            JwtState.Jwt = loginResponse.Jwt;
            var grpcUser = authService.ValidateJwt(JwtState.Jwt);
            UserState.user = new User {
                Id = grpcUser.Id,
                Email = grpcUser.Email,
                FullName = grpcUser.FullName
            };

            NavigationManager.NavigateTo("");
        } catch(RpcException e) {
            ErrorModalOpen(e);
        }
    }
     public void ErrorModalClose() {
        errorModal.Close();
        StateHasChanged();
    }
    public void ErrorModalOpen(RpcException e) {
        errorModal.Open(e);
        StateHasChanged();
    }
    void InvalidFormSubmitted(EditContext editContext) {
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JwtState JwtState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService authService { get; set; }
    }
}
#pragma warning restore 1591
