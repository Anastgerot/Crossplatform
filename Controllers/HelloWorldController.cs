using Microsoft.AspNetCore.Mvc;

namespace Gerdt.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is Gerdt default action)";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
