using Microsoft.AspNetCore.Components;

namespace BlazorTodo.Client.Components;

public partial class NavBar
{
    [Parameter]
    public string NavTitle { get; set; } = "Default NavBar Title";

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
