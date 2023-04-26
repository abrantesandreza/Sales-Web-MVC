using Microsoft.AspNetCore.Mvc;

namespace ProjetoWebSales.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
