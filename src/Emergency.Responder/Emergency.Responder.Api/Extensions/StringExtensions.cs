namespace Emergency.Responder.Api.Extensions;

public static class StringExtensions
{
    public static bool HasOverTwelveCharacters(this string value)
    {
        return value.AsSpan(0, value.Length).Length >= 11;
    }
}