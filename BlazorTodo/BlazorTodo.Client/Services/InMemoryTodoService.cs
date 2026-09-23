using BlazorTodo.Client.Models;

namespace BlazorTodo.Client.Services;

public class InMemoryTodoService : ITodoService
{
    private List<TodoItem> _todoItems;

    public InMemoryTodoService()
    {
        _todoItems =
             [
                  new(){Text = "Buy bananas", Completed = true, Created = DateTime.Now.AddDays(-2)},
                  new(){Text = "Walk the dog"},
                  new(){Text = "Coffe",  Created = DateTime.Now.AddDays(-1).AddHours(5)},
             ];
    }

    public void Add(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return;

        _todoItems.Add(new TodoItem { Text = text.Trim() });
    }

    public void Delete(Guid id)
    {
        var item = _todoItems.FirstOrDefault(item => item.Id == id);

        if (item == null) return;

        _todoItems.Remove(item);
    }

    public IReadOnlyList<TodoItem> GetAll() => _todoItems.AsReadOnly();
   

    public void ToggleComplete(Guid id)
    {
        var item = _todoItems.FirstOrDefault(item => item.Id == id);

        if (item == null) return;

        item.Completed = !item.Completed;
    }
}
