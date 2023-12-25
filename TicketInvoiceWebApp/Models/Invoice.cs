using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketInvoiceWebApp.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set;}= DateTime.Now;
        [Required]
        public string PassengerName { get; set; }
        public string? Address {  get; set; }
        public string? ContactNo { get; set; }

        public List<TicketInfo> TicketInfos { get; set; } = new List<TicketInfo>();



        
    }
}
