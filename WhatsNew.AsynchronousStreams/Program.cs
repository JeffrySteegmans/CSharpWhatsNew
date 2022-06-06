await foreach (var seasonTicketId in GetSeasonTicketIds())
{
    Console.WriteLine(seasonTicketId);
}

static async IAsyncEnumerable<Guid> GetSeasonTicketIds()
{
    for (int i = 0; i < 20; i++)
    {
        await Task.Delay(1000);

        yield return Guid.NewGuid();
    }
}