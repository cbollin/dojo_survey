using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dojosurvey2.Controllers
{
    public class DojoController : Controller
    {
        [HttpGet]
        [Route("/")] //A route of Route("template") will match the url localhost:5000/template.
        public IActionResult Index()
        {
            Console.WriteLine("Inside the index");
            return View("index");
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            Console.WriteLine("Inside the process route");

            // @ViewBag.user = new List<string>();

            name = Request.Form["name"];
            location = Request.Form["location"];
            language = Request.Form["language"];
            comment = Request.Form["comment"];

            @ViewBag.name = name;
            @ViewBag.location = location;
            @ViewBag.language = language;
            @ViewBag.comment = comment;

            Console.WriteLine(name + location + language + comment);
            Console.WriteLine(@ViewBag.name  + @ViewBag.location + "viewbags");

            return View("result");
        }

        // [HttpGet]
        // [Route("/result")] //A route of Route("template") will match the url localhost:5000/template.
        //     public IActionResult Result(string name)
        //     {
        //         // Console.WriteLine(@ViewBag.name);
        //         Console.WriteLine("Inside the result get method");
        //         return View("result"); //tell our controller to actually serve the view.
        //     }

        // [HttpGet]
        // [Route("template/{Name}")]
        // public IActionResult Method(string Name)
        // {
        //  return("hello", Name);
        // }

        // A POST method
        // [HttpPost]
        // [Route("")]
        // public IActionResult Other()
        // {
        //     return View();
        // }
    }
}
