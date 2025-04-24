namespace Reservations;

public sealed record AmadeusCredentials(string CliendId, string ClientSecret)
{
    public static string ConfigSectionName => "Amadeus";
}
