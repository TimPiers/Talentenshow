﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TalentenShow.Domain.Business.Contracts.Business;
using TalentenShow.Domain.Business.Events;
using TalentenShow.Domain.Business.News;
using TalentenShow.Domain.Models.Events;
using TalentenShow.Domain.Models.News;
using TalentenShow.Repository.Events;
using TalentenShow.Repository.News;

namespace TalentenShow.WebApi.Controllers {
    public class EventController : ApiController
    {

        private IEventService _service;

        public EventController()
        {
            _service = new EventService(new EventRepository());
        }

        /// <summary>
        /// Get all active events.
        /// </summary>
        [Route("api/events/active")]
        [HttpGet]
        public List<Event> GetAllActiveEvents()
        {
            return _service.GetAllActiveEvents();
        }

        /// <summary>
        /// Get all active events.
        /// </summary>
        [Route("api/events/all")]
        [HttpGet]
        public List<Event> GetAllEvents()
        {
            return _service.GetAllEvents();
        }

        /// <summary>
        /// Get event by Id
        /// </summary>
        [Route("api/events/get/{eventId}")]
        [HttpGet]
        public Event GetNewsById(int eventId)
        {
            return _service.GetEventById(eventId);

        }

        /// <summary>
        /// Save a event
        /// </summary>
        [Route("api/events/save")]
        [HttpPost]
        public int SaveEvent(Event eventObj)
        {
            return _service.SaveEvent(eventObj);
        }

        /// <summary>
        /// Delete a event
        /// </summary>
        [Route("api/events/delete")]
        [HttpPost]
        public int DeleteEvent(Event eventObj)
        {
            return _service.DeleteEvent(eventObj);
        }
    }
}
