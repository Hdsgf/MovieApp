using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller 
{

    // GET: /HelloWorld/
    public string Index()
    {
        return "this is my default action...";
    }

    //GET: /HelloWorld/Welcome/
    public string Welcome(string name, int numTimes = 1)
    {
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}