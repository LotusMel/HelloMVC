using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        // Respond to query string. Pass string name to Index
        /*
        public IActionResult Index(string name)//Enables index to accept query
        {
            //Default for no name
            if (string.IsNullOrEmpty(name))
            {
                name = "World";
            }

            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        */

        //Or...
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Redirect("/Hello/Goodbye");
        }

        //***Post request*** Form
        // Change to display in various ways
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }


        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        

        // /Hello/Goodbye
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

        // alter the route to this controller to be: /Hello/Aloha
        /*
        // Using 'Route Atribute'
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
        */
    }
}
