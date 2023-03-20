namespace IDisposableExampleConsoleApp
{
    public class BothInterfacesExample : IDisposable, IAsyncDisposable
    {
        private readonly FileStream _fileStream;
        public BothInterfacesExample()
        {
            _fileStream = new("D:\\test.txt", FileMode.Create);
        }

        public void Dispose() => _fileStream.Dispose();

        public async ValueTask DisposeAsync() 
            => await _fileStream.DisposeAsync();
    }
}
