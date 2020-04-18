#pragma checksum "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f22dec6e80f516875567c54ac7f620422cf99c1"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fahod\Documents\Programas\C#\Blazor\_Imports.razor"
using Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "todo-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h1>Todo List</h1>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "todo-input");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                                    todoInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todoInput = __value, todoInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                          AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 9 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
     for (int i = 0; i < todos.Count; i++)
    {
        var index = i;
        var todo  = todos[i];

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "todo-item");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", 
#nullable restore
#line 15 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                         todo.IsComplete ? "todo-item__text complete" : "todo-item__text"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                            () => MarkAsComplete(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddContent(25, 
#nullable restore
#line 17 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                 todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "todo-item__close");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
                                                      () => RemoveTodo(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 21 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\fahod\Documents\Programas\C#\Blazor\Pages\Index.razor"
 
    public string todoInput { get; set; }
    List<Todo> todos = new List<Todo>();
    public void AddTodo()
    {
        Todo todo = new Todo();
        todo.Title = todoInput;
        todos.Add(todo);
        todoInput = "";
    }
    public void RemoveTodo(int index)
    {
        todos.RemoveAt(index);

    }
    public void MarkAsComplete(int index)
    {
        todos[index].IsComplete = !todos[index].IsComplete;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
