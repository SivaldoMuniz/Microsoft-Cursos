using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OlaMundo.Controllers
{
    public class OlaMundoController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requuires using System.Text.Encofing.Wb;
        public string Welcome( string name, int numTimes = 1)
        {
           return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}