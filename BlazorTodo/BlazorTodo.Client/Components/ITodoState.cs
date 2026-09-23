namespace BlazorTodo.Client.Components;

public interface ITodoState
{
    int Count { get; }

    event Action? Onchange;

    void SetCount(int count);
}