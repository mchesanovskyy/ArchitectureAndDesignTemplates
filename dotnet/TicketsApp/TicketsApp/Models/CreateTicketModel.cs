using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsApp.Infrastructure.Interfaces;

namespace TicketsApp.Models
{
    public class CreateTicketModelIn : IViewModel
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Qty { get; set; }
    }
}
