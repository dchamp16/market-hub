namespace MarketHub.Api.Models.DTOs;

public class CreateEventRequest
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTime EventDate { get; set; }

    // Additional properties can be added as needed
}