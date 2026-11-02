namespace Jellyfin.Plugin.SeerrFin.Configuration;

public class SeerrFinTabConfig
{
    public string Id { get; set; } = string.Empty;

    public bool Enabled { get; set; } = true;

    public string Title { get; set; } = string.Empty;

    public static List<SeerrFinTabConfig> CreateDefaults() =>
    [
        new() { Id = "movies", Title = "Filmes" },
        new() { Id = "tv", Title = "Séries" },
        new() { Id = "discover", Enabled = false, Title = "Descobrir" },
        new() { Id = "requests", Title = "Solicitações" },
        new() { Id = "watchlist", Title = "Minha lista" },
        new() { Id = "letterboxd", Title = "Letterboxd" }
    ];
}
