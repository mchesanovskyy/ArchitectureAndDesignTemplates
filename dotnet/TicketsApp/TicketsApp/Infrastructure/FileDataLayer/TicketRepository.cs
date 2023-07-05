using TicketsApp.Core.Entities;
using TicketsApp.Core.Interfaces;
using TicketsApp.Infrastructure.Extensions;

namespace TicketsApp.Infrastructure.FileDataLayer;

public class TicketRepository : ITicketRepository
{
    private const string FileName = "tickets.json";

    private FileData<Ticket>? _fileData;

    public TicketRepository()
    {
    }

    protected FileData<Ticket> FileData => _fileData ??= ReadFileData();

    public Ticket Add(Ticket ticket)
    {
        ticket.Id = ++FileData.LastUsedId;
        FileData.Records.Add(ticket);
        SaveChanges();
        return ticket;
    }

    private void SaveChanges()
    {
        File.WriteAllText(FileName, FileData.ToJsonString());
        _fileData = null;
    }

    private static FileData<Ticket> ReadFileData()
    {
        if (File.Exists(FileName))
        {
            return File.ReadAllText(FileName).TryParseString<FileData<Ticket>>()
                   ?? new FileData<Ticket>();
        }
        return new FileData<Ticket>();
    }
}