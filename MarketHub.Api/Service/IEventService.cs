using MarketHub.Api.Models;

namespace MarketHub.Api.Services;

public interface IEventService
{
    // We use Task for asynchronous operations
    Task<IEnumerable<Event>> GetAllEventsAsync();
    Task<Event?> GetEventByIdAsync(Guid id);
    Task<Event> CreateEventAsync(Event newEvent);
    // We can add UpdateEventAsync and DeleteEventAsync later
}