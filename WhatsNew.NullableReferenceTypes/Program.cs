

string nonNullableString = null;

Console.WriteLine(nonNullableString);


WriteMessage(null);

void WriteMessage(string? message)
{
    if (IsNotNull(message))
        Console.WriteLine(message.Length);
}

bool IsNotNull(string? value)
{
    return value is not null;
}