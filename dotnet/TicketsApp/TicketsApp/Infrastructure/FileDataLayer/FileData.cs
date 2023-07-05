namespace TicketsApp.Infrastructure.FileDataLayer;

public class FileData<T>
{
    public FileData()
    {
        Records = new List<T>(0);
    }

    public int LastUsedId { get; set; }
    public ICollection<T> Records { get; set; }
}