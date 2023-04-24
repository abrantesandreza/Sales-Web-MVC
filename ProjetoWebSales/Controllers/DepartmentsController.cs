using Microsoft.AspNetCore.Mvc;
using ProjetoWebSales.Models;
using System.Collections.Generic;
using ProjetoWebSales.Models;

namespace ProjetoWebSales.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departmentList = new List<Department>();

            //Adicionando novos departamentos, instanciando automaticamente
            departmentList.Add(new Department { Id = 1, Name = "Eletronics" });
            departmentList.Add(new Department { Id = 2, Name = "Fashion" });

            return View(departmentList);
        }
    }
}
