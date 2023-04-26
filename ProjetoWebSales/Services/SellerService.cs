using ProjetoWebSales.Data;
using ProjetoWebSales.Models;

namespace ProjetoWebSales.Services
{
    public class SellerService
    {
        private readonly ProjetoWebSalesContext _context;

        public SellerService(ProjetoWebSalesContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
