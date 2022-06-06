namespace WhatsNew.UsingDeclarations.SeasonTicketService;

internal class SeasonTicketService : ISeasonTicketService, IDisposable
{
    public async IAsyncEnumerable<Guid> GetSeasonTicketIds()
    {
        for(var i = 0; i < 10; i++)
        {
            yield return Guid.NewGuid();
        }
    }

    public void Dispose()
    {
    }
}
