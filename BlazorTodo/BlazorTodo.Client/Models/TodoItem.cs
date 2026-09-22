namespace BlazorTodo.Client.Models;

public class TodoItem
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Text { get; set; }
    public DateTime Created { get; init; } = DateTime.Now;
    public bool Completed { get; set; }
}
