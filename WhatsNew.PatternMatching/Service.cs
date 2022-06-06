namespace WhatsNew.PatternMatching;

internal class Service
{
    internal Response<Session> GetSessionTernaryReturn()
    {
        var result = new Result();

        return result.Success
            ? Response<Session>.WithResult(result.Value)
            : Response<Session>.WithError("Something went wrong");
    }

    internal Response<Session> GetSessionSwitchExpression()
    {
        var result = new Result();

        return result switch
        {
            { Success: true } => Response<Session>.WithResult(result.Value),
            { Success: false, Message: "No session found" } => Response<Session>.WithError("No session found"),
            _ => Response<Session>.WithError("Something went wrong"),
        };
    }
}

internal record Session
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

internal record Result
{
    internal bool Success { get; set; }

    internal string Message { get; set; }

    internal Session Value { get; set; } = new Session();
}

internal record Response<T>(T Result, string Error) where T : class
{
    public static Response<T> WithResult(T result)
    {
        return new Response<T>(result, null);
    }

    internal static Response<T> WithError(string error)
    {
        return new Response<T>(null, error);
    }
}
