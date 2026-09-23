using BlazorTodo.Client.Components;

namespace BlazorTodo;

public class NoopTodoState : ITodoState
{
    public int Count { get; }

    public event Action? Onchange;

    public void SetCount(int count)
    {
        
    }
}
