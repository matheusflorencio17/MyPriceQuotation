using Microsoft.AspNetCore.Mvc;
using MyPriceQuotationWebsite.Models;
using MyPriceQuotationWebsite.Repository;

namespace MyPriceQuotationWebsite.Controllers
{
    public class ActionsController : Controller
    {
        private readonly IQuotationRepository _quotationRepository;
        public ActionsController(IQuotationRepository quotationRepository) 
        {
            _quotationRepository = quotationRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Include()
        {
            return View();
        }
        public IActionResult DeleteConfirmation()
        {          
            return View();           
        }
        public IActionResult Update()
        {
            List<QuotationModel> quotation = _quotationRepository.SearchAll();
            return View(quotation);
        }

        public IActionResult Updating(int id)
        {
            QuotationModel quotation = _quotationRepository.SearchForId(id);
            return View(quotation);
        }

        [HttpGet]
        public IActionResult DeleteConfirmation(int id)
        {
            _quotationRepository.DeleteConfirmation(id);
            return RedirectToAction("Update");
        }

        [HttpPost]
        public IActionResult Include(QuotationModel quotation) 
        {
            _quotationRepository.Addi(quotation);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Updating(QuotationModel quotation)
        {
            _quotationRepository.Alter(quotation);
            return RedirectToAction("Update");
        }
    }
}
