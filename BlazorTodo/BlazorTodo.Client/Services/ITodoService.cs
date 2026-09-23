using BlazorTodo.Client.Models;

namespace BlazorTodo.Client.Services;

public interface ITodoService
{
    IReadOnlyList<TodoItem> GetAll();
    void Add(string text);
    void Delete(Guid id);
    void ToggleComplete(Guid id);
}
