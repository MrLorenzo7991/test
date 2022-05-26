using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            // Questa l'ho creata per fare un test e vedere cosa succede con un conflitto.
            string ciaoBryan = "mia varaibile";

            //Ritorno la vista
            return View();
        }
    }
}
