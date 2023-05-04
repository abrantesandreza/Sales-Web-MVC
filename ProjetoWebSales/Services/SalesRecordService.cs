using ProjetoWebSales.Data;
using ProjetoWebSales.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWebSales.Services
{
    public class SalesRecordService
    {

        private readonly ProjetoWebSalesContext _context;

        public SalesRecordService(ProjetoWebSalesContext context)
        {
            _context = context;
        }

        public List<SalesRecord> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToList();
        }

        public List<IGrouping<Department, SalesRecord>> FindByDateGrouping(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .AsEnumerable()
                .GroupBy(x => x.Seller.Department)
                .ToList();
        }
    }
}

