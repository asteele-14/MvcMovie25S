// This is the generic controller for Part 2 of the tutorial
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    // GET: /HelloWorld/
    // commented this out for the IActionResult exercise
    //public string Index()
    //{
    //    return "This is my default action...";
    //}

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome (string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    //
    // GET: /HelloWorld/Welcome
    // Requires this using statement Encodings.Web
    /*public string Welcome(string name, int numTimes = 1)
    {
        //return "This is the Welcome action method...";
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    public string Welcome (string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }*/

}