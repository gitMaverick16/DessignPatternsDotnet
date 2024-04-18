namespace Strategy.Example02
{
    public class ZipFileCompressionStrategy : IFileCompressionStrategy
    {
        public void CompressFile(string file)
        {
            Console.WriteLine($"Compressing file: {file} into zip format");
        }
    }
}
