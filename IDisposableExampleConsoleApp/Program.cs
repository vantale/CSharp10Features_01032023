// See https://aka.ms/new-console-template for more information
using IDisposableExampleConsoleApp;

Console.WriteLine("Hello, World!");
await Run();

async Task Run()
{
    await using var brush = new Brush();
    await brush.PaintAsync();
}


var scopedBrush = new ScopedBrush();

using (scopedBrush.BeginScope("orange"))
{
    Console.WriteLine("Inside the scope!");
}

using var _ = scopedBrush.BeginScope("orange");
Console.WriteLine("Inside the scope!");

