namespace IDisposableExampleConsoleApp
{
    public class Brush : IAsyncDisposable
    {
        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            Console.WriteLine("Disposing connections to DB");
            await Task.Delay(TimeSpan.FromSeconds(2));

            Console.WriteLine("Disposing C++ drawing dlls");
            await Task.Delay(TimeSpan.FromSeconds(3));

            Console.WriteLine("Closing connection to authentication server C++");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        public async Task PaintAsync()
        {
            Console.WriteLine(TextRepository.Text1);
            await Task.Delay(TimeSpan.FromSeconds(2));

            Console.WriteLine(TextRepository.Text2);
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}
