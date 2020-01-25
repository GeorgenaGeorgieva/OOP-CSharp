namespace StreamProgress.Clases
{
    using Interfaces;

    public class StreamProgressInfo
    {
        private IInformative currentFile;

        public StreamProgressInfo(IInformative currentFile)
        {
            this.currentFile = currentFile;
        }

        public int CalculateCurrentPercent()
        {
            return (this.currentFile.BytesSent * 100) / this.currentFile.Length;
        }
    }
}
