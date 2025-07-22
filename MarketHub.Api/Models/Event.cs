namespace MarketHub.Api.Models;

public class Event
{
    public Guid Id { get; set; } // Using Guid for unique IDs
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTimeOffset EventDate { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    // We'll add relationships to a User model later
}