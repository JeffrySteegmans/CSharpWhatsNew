namespace WhatsNew.UsingDeclarations.SeasonTicketService;

internal interface ISeasonTicketService
{
    IAsyncEnumerable<Guid> GetSeasonTicketIds();
}
