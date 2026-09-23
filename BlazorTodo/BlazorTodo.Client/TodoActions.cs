using Microsoft.AspNetCore.Components;

namespace BlazorTodo.Client;

public class TodoActions
{
    public EventCallback<Guid> OnDelete { get; init; }
    public EventCallback<Guid> OnComplette { get; init; }
}
