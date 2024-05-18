using MyPriceQuotationWebsite.Data;
using MyPriceQuotationWebsite.Models;

namespace MyPriceQuotationWebsite.Repository
{
    public class QuotationRepository : IQuotationRepository
    {
        private readonly ApplicationDbContext _quotation;
        public QuotationRepository(ApplicationDbContext quotation) 
        {
            _quotation = quotation;
        }
        public QuotationModel SearchForId(int id)
        {
            return _quotation.quotation.FirstOrDefault(x => x.Id == id);
        }

        public List<QuotationModel> SearchAll()
        {
           return _quotation.quotation.ToList();
        }

        public QuotationModel Addi(QuotationModel quotation)
        {
            //INSERT 
            _quotation.quotation.Add(quotation);
            _quotation.SaveChanges();

            return quotation;

        }

        public QuotationModel Alter(QuotationModel quotation)
        {
            //UPDATE
           QuotationModel quotationDB = SearchForId(quotation.Id);

            if(quotationDB == null) {
                throw new System.Exception("We identified an error updating the data, make sure everything is correct!");
            }
            quotationDB.Currency = quotation.Currency;
            quotationDB.Symbol = quotation.Symbol;
            quotationDB.Value = quotation.Value;

            _quotation.quotation.Update(quotationDB);
            _quotation.SaveChanges();

            return quotationDB;
        }

        public bool DeleteConfirmation(int id)
        {
            QuotationModel quotationDB = SearchForId(id);

            if (quotationDB == null)
            {
                throw new System.Exception("We identified an error delete the data, make sure everything is correct!");
            }
            _quotation.quotation.Remove(quotationDB);
            _quotation.SaveChanges();
            return true;
            }
        }
}
