using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;

namespace TP06.Controllers;


public class AcountController : Controller
{
    private readonly ILogger<AcountController> _logger;

    public AcountController(ILogger<AcountController> logger)
    {
        _logger = logger;
    }

    public IActionResult LogIn()
    {
        return View();
    }
}
