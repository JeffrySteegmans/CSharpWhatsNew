using WhatsNew.UsingDeclarations.SeasonTicketService;

await PrintSeasonTicketIds();

static async Task PrintSeasonTicketIds()
{
    using var seasonTicketService = new SeasonTicketService();

    await foreach (var seasonTicketId in seasonTicketService.GetSeasonTicketIds())
    {
        Console.WriteLine(seasonTicketId);
    }

    // seasonTicketService is disposed here
}