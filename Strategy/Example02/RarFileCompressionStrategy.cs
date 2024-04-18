namespace Strategy.Example02
{
    public class RarFileCompressionStrategy : IFileCompressionStrategy
    {
        public void CompressFile(string file)
        {
            Console.WriteLine($"Compressing file: {file} into rar format");
        }
    }
}
