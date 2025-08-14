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
        return View("LogIn");
    }

    public IActionResult LogInGuardar(string username, string password){
        int id = BD.Login(username, password);
        if(id == 0){
            return View("ErrorLogIn");
        }else{
            HttpContext.Session.SetString("idUser", id.ToString());
            
            return View("Personal");
        }
    }
}
