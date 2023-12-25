using Microsoft.AspNetCore.Mvc;
using TicketInvoiceWebApp.Models;

namespace TicketInvoiceWebApp.ViewComponents
{
    public class InfoList:ViewComponent
    {

        public IViewComponentResult Invoke(List<TicketInfo> data)
        {

            ViewBag.Count = data.Count;
            ViewBag.Total = data.Sum(i => i.TotalPrice);

            return View(data);
        }
    }
}
