using System.Diagnostics;
using Data;
using Microsoft.AspNetCore.Mvc;
using PC_Parts_Picker.Models;

namespace PC_Parts_Picker.Controllers;

public class HomeController : Controller
{
    private PcPartsPickerContext context;

    public HomeController(PcPartsPickerContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Components()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
