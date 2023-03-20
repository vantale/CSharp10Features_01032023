namespace IDisposableExampleConsoleApp
{
    public class ScopedBrush
    {
        public void Paint() => Console.Write("Painting with a ScopedBrush");

        public IDisposable BeginScope(string colour)
        {
            Console.WriteLine("Setting up the scope with the colour: " + colour);
            return new BrushScope();
        }
    }

    public class BrushScope : IDisposable
    {
        public void Dispose() => Console.WriteLine("Disposing the BrushScope");
    }
}
