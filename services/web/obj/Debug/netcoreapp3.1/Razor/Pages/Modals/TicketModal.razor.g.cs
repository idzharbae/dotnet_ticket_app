#pragma checksum "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f81d8b3120c8a486f63a9f8b0fba1765e9c26b2"
// <auto-generated/>
#pragma warning disable 1591
namespace Modals
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
#line 2 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
using web.Data.ComponentEntities;

#line default
#line hidden
#nullable disable
    public partial class TicketModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 4 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                   ticketModal.ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "style", "display:" + (
#nullable restore
#line 4 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                                                                                       ticketModal.ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddContent(18, 
#nullable restore
#line 8 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                                         ticketModal.ModalTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "ModalClose");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                                                                   () => ModalClose()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "aria-label", "ModalClose");
            __builder.AddMarkupContent(25, "\n                    ");
            __builder.AddMarkupContent(26, "<span aria-hidden=\"true\">&times;</span>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-body");
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 14 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                    ticketModal.ModalBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-footer");
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-secondary");
            __builder.AddAttribute(42, "data-dismiss", "modal");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
                                                                                               () => ModalClose()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "ModalClose");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Modals/TicketModal.razor"
       
    public ModalEntity ticketModal = new ModalEntity();
    public void ModalOpen(string title, string body) {
        ticketModal.Open(title, body);
        StateHasChanged();
    }

    public void ModalClose() {
        ticketModal.Close();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591