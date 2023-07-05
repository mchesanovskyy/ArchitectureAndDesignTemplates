using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsApp.Core
{
    public class TicketManager
    {
        private List<Ticket> _ticketList;

        public TicketManager()
        {
            _ticketList = new List<Ticket>();
        }

        public Ticket CreateTicket(string name, decimal amount, int qty)
        {
            var id = _ticketList.Any() ? _ticketList.Max(x => x.Id) + 1 : 100;

            var ticket = new Ticket()
            {
                Id = id,
                Name = name,
                Amount = amount,
                Qty = qty,
            };
            _ticketList.Add(ticket);
            return ticket;
        }
    }
}
