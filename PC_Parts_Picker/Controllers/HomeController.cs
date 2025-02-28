using System.Diagnostics;
using Data;
using Microsoft.AspNetCore.Mvc;
using PC_Parts_Picker.Models;
using Data.Data;
using System.Linq;

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

    public IActionResult Cpus()
    {
        var cpus = context.Cpus.ToList();
        return View(cpus);
    }

    public IActionResult Motherboards()
    {
        var motherboards = context.Motherboards.ToList();
        return View(motherboards);
    }

    public IActionResult Gpus()
    {
        var gpus = context.Gpus.ToList();
        return View(gpus);
    }

    public IActionResult Memory()
    {
        var rams = context.Rams.ToList();
        return View(rams);
    }

    public IActionResult Ssds()
    {
        var ssds = context.Ssds.ToList();
        return View(ssds);
    }

    public IActionResult Psus()
    {
        var psus = context.Psus.ToList();
        return View(psus);
    }

    public IActionResult Cases()
    {
        var cases = context.Cases.ToList();
        return View(cases);
    }

    public IActionResult Coolers()
    {
        var coolers = context.Coolers.ToList();
        return View(coolers);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}