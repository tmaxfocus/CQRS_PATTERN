﻿using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(GloboTicketDbContext globoTicketDbContext):base(globoTicketDbContext)
        {
                
        }
        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbcontext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
