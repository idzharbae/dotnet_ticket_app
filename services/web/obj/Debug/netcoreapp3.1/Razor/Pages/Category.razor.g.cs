#pragma checksum "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3ef9b10307a2456d7a5fc97c4420958473e0d4f"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
using StateManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
using web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
using TicketGrpc=TicketApp.Internal.Delivery.Grpc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Categories</h1>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                     category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                             ValidFormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                  InvalidFormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-label-group");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "id", "inputName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Category Name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                            category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Name = __value, category.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.AddMarkupContent(24, "<label for=\"inputName\">Category Name</label>\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n\n            ");
                __builder2.AddMarkupContent(26, "<button class=\"btn btn-lg btn-primary btn-block text-uppercase\" type=\"submit\">Add Category</button>\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal" + " " + (
#nullable restore
#line 27 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                   createdModal.ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "tabindex", "-1");
            __builder.AddAttribute(33, "role", "dialog");
            __builder.AddAttribute(34, "style", "display:" + (
#nullable restore
#line 27 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                        createdModal.ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-dialog");
            __builder.AddAttribute(38, "role", "document");
            __builder.AddMarkupContent(39, "\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-content");
            __builder.AddMarkupContent(42, "\n            ");
            __builder.AddMarkupContent(43, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Added Category</h5>
                <button type=""button"" class=""ModalClose"" data-dismiss=""modal"" aria-label=""ModalClose"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-body");
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, "Created category: ");
            __builder.AddContent(49, 
#nullable restore
#line 37 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                      createdModal.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-footer");
            __builder.AddMarkupContent(54, "\n                ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-secondary");
            __builder.AddAttribute(58, "data-dismiss", "modal");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                               () => ModalCreatedClose()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "ModalClose");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal" + " " + (
#nullable restore
#line 45 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                   deletedModal.ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "tabindex", "-1");
            __builder.AddAttribute(69, "role", "dialog");
            __builder.AddAttribute(70, "style", "display:" + (
#nullable restore
#line 45 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                        deletedModal.ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-dialog");
            __builder.AddAttribute(74, "role", "document");
            __builder.AddMarkupContent(75, "\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-content");
            __builder.AddMarkupContent(78, "\n            ");
            __builder.AddMarkupContent(79, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Deleted Category</h5>
                <button type=""button"" class=""ModalClose"" data-dismiss=""modal"" aria-label=""ModalClose"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "modal-body");
            __builder.AddMarkupContent(82, "\n                ");
            __builder.OpenElement(83, "p");
            __builder.AddContent(84, "Deleted category: ");
            __builder.AddContent(85, 
#nullable restore
#line 55 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                      deletedModal.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-footer");
            __builder.AddMarkupContent(90, "\n                ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-secondary");
            __builder.AddAttribute(94, "data-dismiss", "modal");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                               () => ModalDeletedClose()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(96, "ModalClose");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "modal" + " " + (
#nullable restore
#line 63 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                   updatedModal.ModalClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "tabindex", "-1");
            __builder.AddAttribute(105, "role", "dialog");
            __builder.AddAttribute(106, "style", "display:" + (
#nullable restore
#line 63 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                        updatedModal.ModalDisplay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(107, "\n    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal-dialog");
            __builder.AddAttribute(110, "role", "document");
            __builder.AddMarkupContent(111, "\n        ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "modal-content");
            __builder.AddMarkupContent(114, "\n            ");
            __builder.AddMarkupContent(115, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Updated Category</h5>
                <button type=""button"" class=""ModalClose"" data-dismiss=""modal"" aria-label=""ModalClose"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "modal-body");
            __builder.AddMarkupContent(118, "\n                ");
            __builder.OpenElement(119, "p");
            __builder.AddContent(120, "Updated category: ");
            __builder.AddContent(121, 
#nullable restore
#line 73 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                      updatedModal.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-footer");
            __builder.AddMarkupContent(126, "\n                ");
            __builder.OpenElement(127, "button");
            __builder.AddAttribute(128, "type", "button");
            __builder.AddAttribute(129, "class", "btn btn-secondary");
            __builder.AddAttribute(130, "data-dismiss", "modal");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                                               () => ModalUpdatedClose()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(132, "ModalClose");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\n\n\n");
#nullable restore
#line 83 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
 if (categoryList.categories != null && categoryList.categories.Length >0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(138, "    ");
            __builder.OpenElement(139, "table");
            __builder.AddAttribute(140, "class", "table");
            __builder.AddMarkupContent(141, "\n        ");
            __builder.AddMarkupContent(142, "<thead>\n            <tr>\n                <th>Id</th>\n                <th>Name</th>\n                <th>Created At</th>\n                <th>Action</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(143, "tbody");
            __builder.AddMarkupContent(144, "\n");
#nullable restore
#line 95 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
             foreach (var c in categoryList.categories) {            

#line default
#line hidden
#nullable disable
            __builder.AddContent(145, "            ");
            __builder.OpenElement(146, "tr");
            __builder.AddMarkupContent(147, "\n                ");
            __builder.OpenElement(148, "td");
            __builder.AddContent(149, 
#nullable restore
#line 97 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                     c.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n                ");
            __builder.OpenElement(151, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(152);
            __builder.AddAttribute(153, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 98 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                     c

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(154, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 98 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                      () => UpdateCategory(c)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(155, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(156, "\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(157);
                __builder2.AddAttribute(158, "type", "text");
                __builder2.AddAttribute(159, "class", "form-control");
                __builder2.AddAttribute(160, "placeholder", "Category Name");
                __builder2.AddAttribute(161, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                            c.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => c.Name = __value, c.Name))));
                __builder2.AddAttribute(163, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => c.Name));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\n                ");
            __builder.OpenElement(165, "td");
            __builder.AddContent(166, 
#nullable restore
#line 101 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                     c.CreatedAt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\n                ");
            __builder.OpenElement(168, "td");
            __builder.AddMarkupContent(169, "\n                    ");
            __builder.OpenElement(170, "button");
            __builder.AddAttribute(171, "class", "btn btn-danger");
            __builder.AddAttribute(172, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                             () => DeleteCategory(c.Id, c.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(173, "delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\n                    ");
            __builder.OpenElement(175, "button");
            __builder.AddAttribute(176, "class", "btn btn-secondary");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
                                                                () => UpdateCategory(c)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(178, "update");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\n");
#nullable restore
#line 107 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(182, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\n");
#nullable restore
#line 110 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(185, "    ");
            __builder.AddMarkupContent(186, "<h1>Data empty</h1>\n");
#nullable restore
#line 112 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "/home/idzhar/Documents/jobseek/xtremax/ticketing/services/web/Pages/Category.razor"
       
    web.Data.Category category = new web.Data.Category();
    CategoryList categoryList;
    CategoryModal createdModal = new CategoryModal();
    CategoryModal updatedModal = new CategoryModal();
    CategoryModal deletedModal = new CategoryModal();
    long totalTickets;
    protected override void OnInitialized() {
        if(string.IsNullOrEmpty(JwtState.Jwt))
            NavigationManager.NavigateTo("login");
        FetchCategories();
    }
    void ValidFormSubmitted() {
        var result = TicketService.CreateCategory(new TicketGrpc.Category{
            Name = category.Name
        }, JwtState.Jwt);
        FetchCategories();
        ModalCreatedOpen();
    }
    void InvalidFormSubmitted(EditContext editContext) {
        
    }
    void FetchCategories() {
        categoryList = TicketService.ListCategory(new TicketGrpc.ListCategoryReq{
            Page = 1,
            Limit = 10
        });
    }

    void DeleteCategory(string categoryId, string categoryName) {
        TicketService.DeleteCategory(categoryId, JwtState.Jwt);
        FetchCategories();
        ModalDeletedOpen(categoryName);
    }
    public void ModalCreatedOpen() {
        createdModal.Open(category.Name);
        StateHasChanged();
    }

    public void ModalCreatedClose() {
        createdModal.Close();
        StateHasChanged();
    }
    public void ModalDeletedOpen(string categoryName) {
        deletedModal.Open(categoryName);
        StateHasChanged();
    }

    public void ModalDeletedClose() {
        deletedModal.Close();
        StateHasChanged();
    }
    public void ModalUpdatedOpen(string categoryName) {
        updatedModal.Open(categoryName);
        StateHasChanged();
    }

    public void ModalUpdatedClose() {
        updatedModal.Close();
        StateHasChanged();
    }
    public void UpdateCategory(web.Data.Category category) {
        TicketService.UpdateCategory(new TicketGrpc.Category{
            Id = category.Id,
            Name = category.Name
        }, JwtState.Jwt);
        FetchCategories();
        ModalUpdatedOpen(category.Name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TicketService TicketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JwtState JwtState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591