using ProjetoWebSales.Models;
using ProjetoWebSales.Data;
using System.Collections.Generic;

namespace ProjetoWebSales.Services
{
    public class DepartmentService
    {
        private readonly ProjetoWebSalesContext _context;

        public DepartmentService(ProjetoWebSalesContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
