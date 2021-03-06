﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentenShow.Domain.Business.Contracts.Business;
using TalentenShow.Domain.Business.Contracts.Repository;
using TalentenShow.Domain.Models.Events;

namespace TalentenShow.Domain.Business.Events
{
    public class EventService : IEventService
    {

        private IEventRepository _repository;

        public EventService(IEventRepository repository)
        {
            _repository = repository;
        }

        public int DeleteEvent(Event eventObj)
        {
            return _repository.DeleteEvent(eventObj);
        }

        public List<Event> GetAllActiveEvents()
        {
            return _repository.GetAllActiveEvents();
        }

        public List<Event> GetAllEvents()
        {
            return _repository.GetAllEvents();
        }

        public Event GetEventById(int eventId)
        {
            return _repository.GetEventById(eventId);
        }

        public int SaveEvent(Event eventObj)
        {
            eventObj.Location = null;
            eventObj.Theme = null;
            return _repository.SaveEvent(eventObj);
        }
    }
}
