namespace StreamProgress.Interfaces
{
    public interface IInformative
    {
        int Length { get; }

        int BytesSent { get; }
    }
}
