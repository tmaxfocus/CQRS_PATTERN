

using GlobalTicket.TicketManagement.Domain.Common;

namespace GlobalTicket.TicketManagement.Domain.Entities
{
    public class Category: AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public ICollection<Event>? Events { get; set; }
    }
}
