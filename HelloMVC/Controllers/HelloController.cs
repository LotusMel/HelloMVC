using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
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

        public IActionResult Index()//Enables index to accept query
        {
            string html = "<form method='post' action='/Hello/Display'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        //***Post request*** Form

        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        

        // /Hello/Goodbye
        // alter the route to this controller to be: /Hello/Aloha
        /*
        // Using 'Route Atribute'
        [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
        */
        // Change to display in various ways
        // Respond to query string. Pass string name to Index
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

    }
}
