using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Gerdt.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is Gerdt default action)";
        }
     
        public string Welcome(string name, int ID = 1)
        {
             return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
