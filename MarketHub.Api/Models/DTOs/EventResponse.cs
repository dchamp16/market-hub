namespace MarketHub.Api.Models.DTOs;

public class EventResponse
{
    public Guid Id { get; set; } // Unique identifier for the event
    public string Title { get; set; } = string.Empty; // Title of the event
    public string? Description { get; set; } // Optional description of the event
    public string Category { get; set; } = string.Empty; // Category of the event
    public string Address { get; set; } = string.Empty; // Address where the event will take place
    public double Latitude { get; set; } // Latitude for the event location
    public double Longitude { get; set; } // Longitude for the event location
    public DateTime EventDate { get; set; } // Date and time of the event
    public DateTime CreatedAt { get; set; } // Timestamp when the event was created
    public int ViewCount { get; set; } // Number of times the event has been vieweds

    // Additional properties can be added as needed, such as user relationships or status
}