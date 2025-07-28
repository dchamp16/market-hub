using MarketHub.Api.Models;
using MarketHub.Api.Services;

namespace MarketHub.Api.Services;

public class DummyEventService : IEventService
{
    // Temporary in-memory storage
    private readonly List<Event> _events = new();

    public Task<IEnumerable<Event>> GetAllEventsAsync()
    {
        return Task.FromResult<IEnumerable<Event>>(_events);
    }

    public Task<Event?> GetEventByIdAsync(Guid id)
    {
        var ev = _events.FirstOrDefault(e => e.Id == id);
        return Task.FromResult(ev);
    }

    public Task<Event> CreateEventAsync(Event newEvent)
    {
        newEvent.Id = Guid.NewGuid();
        newEvent.CreatedAt = DateTimeOffset.UtcNow;
        _events.Add(newEvent);
        return Task.FromResult(newEvent);
    }
}