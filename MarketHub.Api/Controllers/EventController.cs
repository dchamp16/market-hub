using MarketHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarketHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")] // This will make the route /api/events
public class EventsController : ControllerBase
{
    private readonly IEventService _eventService;

    // The interface is "injected" into the controller's constructor.
    // This is a core concept called Dependency Injection.
    public EventsController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEvents()
    {
        //will implement this later
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetEvent(Guid id)
    {
        //will implement this later
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateEvent() // We'll add the [FromBody] later
    {
        //will implement this later
        throw new NotImplementedException();
    }
}