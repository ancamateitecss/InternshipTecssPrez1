using InternshipApp.Core.Common.Interfaces;
using InternshipApp.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace InternshipApp.Controllers
{
    [ApiController]
    [Route("api/Intership")]
    public class IntershipEventController : ControllerBase
    {
        private readonly ILogger<IntershipEventController> _logger;
        private IEventService _eventService;

        public IntershipEventController(IEventService eventService, ILogger<IntershipEventController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetEvents")]
        public IActionResult GetEvents()
        {
            try
            {
                var results = _eventService.GetEvents();
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddEvent")]
        public IActionResult AddEvent([FromBody] SingleEventViewModel newEvent)
        {
            try
            {
                var results = _eventService.AddEvent(newEvent);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdatateEntireEvent")]
        public IActionResult UpdatateEntireEvent([FromBody] SingleEventViewModel updatedEvent)
        {
            try
            {
                var results = _eventService.UpdatateEntireEvent(updatedEvent);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch]
        [Route("UpdatateEventsNames")]
        public IActionResult UpdatateEventsNames([FromBody] Dictionary<int, string> eventNamesForUpdate)
        {
            try
            {
                var results = _eventService.UpdatateEventsNames(eventNamesForUpdate);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteEvent")]
        public IActionResult DeleteEvent(int idToDelete)
        {
            try
            {
                var results = _eventService.DeleteEvent(idToDelete);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
