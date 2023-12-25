using Microsoft.EntityFrameworkCore;

namespace TicketInvoiceWebApp.Models
{
    public class TicketContext:DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<TicketInfo> TicketInfo { get; set; }


        public TicketContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
