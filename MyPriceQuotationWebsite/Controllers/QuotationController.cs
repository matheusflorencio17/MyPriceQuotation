using Microsoft.AspNetCore.Mvc;
using MyPriceQuotationWebsite.Models;
using MyPriceQuotationWebsite.Repository;

namespace MyPriceQuotationWebsite.Controllers
{
    public class QuotationController : Controller
    {
        private readonly IQuotationRepository _quotationRepository;
        public QuotationController(IQuotationRepository quotationRepository)
        {
            _quotationRepository = quotationRepository;
        }
        public IActionResult Index()
        {
            List<QuotationModel> quotation = _quotationRepository.SearchAll();
            return View(quotation);
        }
    }
}
