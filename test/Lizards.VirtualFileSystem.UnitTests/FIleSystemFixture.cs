namespace Lizzards.VirtualFileSystem.UnitTests {
    using Xunit;
    using FluentAssertions;
    using Lizards.VirtualFileSystem;

    public sealed class FileSystemFixture {

        private readonly FileSystem fileSystem;

        public FileSystemFixture () {
            this.fileSystem = new FileSystem (new InMemoryStrage ());
        }

        [Fact]
        public void CanCreateFile () {
            var file = this.fileSystem.CreateFile ("example.file");

            file.Should().BeNotNull ();
        }
    }
}