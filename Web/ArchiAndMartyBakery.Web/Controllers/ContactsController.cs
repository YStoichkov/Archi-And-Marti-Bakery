namespace ArchiAndMartyBakery.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Аbout()
        {
            return this.View();
        }
    }
}
