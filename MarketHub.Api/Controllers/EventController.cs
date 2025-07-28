using MarketHub.Api.Models;
using MarketHub.Api.Models.DTOs;
using MarketHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarketHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly ILogger<EventsController> _logger;

    public EventsController(IEventService eventService, ILogger<EventsController> logger)
    {
        _eventService = eventService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetEvents()
    {
        try
        {
            var events = await _eventService.GetAllEventsAsync();
            var response = events.Select(e => new EventResponse
            {
                Id = e.Id,
                Title = e.Title,
                Description = e.Description,
                Category = e.Category,
                Address = e.Address,
                Latitude = e.Latitude,
                Longitude = e.Longitude,
                EventDate = e.EventDate.DateTime,
                CreatedAt = e.CreatedAt.DateTime,
                ViewCount = 0 // TODO: Implement view tracking
            });

            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting events");
            return StatusCode(500, "An error occurred");
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newEvent = new Event
        {
            Title = request.Title,
            Description = request.Description,
            Category = request.Category,
            Address = request.Address,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            EventDate = request.EventDate
        };

        var created = await _eventService.CreateEventAsync(newEvent);

        var response = new EventResponse
        {
            Id = created.Id,
            Title = created.Title,
            Description = created.Description,
            Category = created.Category,
            Address = created.Address,
            Latitude = created.Latitude,
            Longitude = created.Longitude,
            EventDate = created.EventDate.DateTime,
            CreatedAt = created.CreatedAt.DateTime,
            ViewCount = 0
        };

        return CreatedAtAction(nameof(GetEvent), new { id = created.Id }, response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetEvent(Guid id)
    {
        var eventItem = await _eventService.GetEventByIdAsync(id);
        if (eventItem == null)
        {
            return NotFound();
        }

        var response = new EventResponse
        {
            Id = eventItem.Id,
            Title = eventItem.Title,
            Description = eventItem.Description,
            Category = eventItem.Category,
            Address = eventItem.Address,
            Latitude = eventItem.Latitude,
            Longitude = eventItem.Longitude,
            EventDate = eventItem.EventDate.DateTime,
            CreatedAt = eventItem.CreatedAt.DateTime,
            ViewCount = 0
        };

        return Ok(response);
    }
}