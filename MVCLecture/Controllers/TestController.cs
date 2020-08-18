
using Microsoft.AspNetCore.Mvc;

namespace MVCLecture.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Greeting()
        {
            return Content("Howdy! Welcome to the greeting page");
        }
    }
}