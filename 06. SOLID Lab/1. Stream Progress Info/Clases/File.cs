namespace StreamProgress.Clases
{
    using Interfaces;

    public class File : IInformative
    {
        public File(string name, int length, int bytesSent)
        {
            this.Name = name;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public string Name { get; set; }
        public int Length { get; set; }
        public int BytesSent { get; set; }
    }
}
