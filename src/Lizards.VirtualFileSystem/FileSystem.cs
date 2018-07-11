namespace Lizards.VirtualFileSystem {
    public sealed class FileSystem
    {
        private readonly IFilesStorage storage;
        public FileSystem(IFilesStorage storage)
        {
            this.storage =storage;
        }
    }
}