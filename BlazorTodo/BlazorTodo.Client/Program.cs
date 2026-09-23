using BlazorTodo.Client.Components;
using BlazorTodo.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorTodo.Client;

internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        //Add to DI
        builder.Services.AddScoped<ITodoState, TodoState>();
        builder.Services.AddScoped<ITodoService, InMemoryTodoService>();

        await builder.Build().RunAsync();
    }
}
