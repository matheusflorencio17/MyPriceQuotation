using MyPriceQuotationWebsite.Models;

namespace MyPriceQuotationWebsite.Repository
{
    public interface IQuotationRepository
    {
        QuotationModel SearchForId(int id);
        List<QuotationModel> SearchAll();
        QuotationModel Addi(QuotationModel quotation);
        QuotationModel Alter(QuotationModel quotation);
        bool DeleteConfirmation(int id);
    }
}
