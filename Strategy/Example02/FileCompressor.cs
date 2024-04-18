namespace Strategy.Example02
{
    public class FileCompressor
    {
        private IFileCompressionStrategy _compressionStrategy;
        public FileCompressor(IFileCompressionStrategy compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void SetCompressorStrategy(IFileCompressionStrategy compressionStrategy)
        {
            _compressionStrategy = compressionStrategy;
        }

        public void CompressFile(string file)
        {
            _compressionStrategy.CompressFile(file);
        }
    }
}
