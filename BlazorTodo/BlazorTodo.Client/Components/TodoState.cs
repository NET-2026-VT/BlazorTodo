namespace BlazorTodo.Client.Components;

public class TodoState
{
    public int Count { get; private set; }

    public event Action? Onchange;

    public void SetCount(int count)
    {
        Count = count;
        Onchange?.Invoke();
    }
}
