using BlazorTodo.Client.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorTodo.Client;

internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        //Add to DI
        builder.Services.AddScoped<TodoState>();

        await builder.Build().RunAsync();
    }
}
