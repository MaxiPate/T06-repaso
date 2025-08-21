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

    public IActionResult SignIn()
    {
        return View("SignIn");
    }

    public IActionResult SignInGuardar(string username, string password, string nombre, string apellido){
        int id = BD.VerificarUsuario(username);
        if(id != 0){
            return View("ErrorSignIn");
        }else{
            
            return View("Personal");
        }
    }
    public IActionResult CerrarSesion(){
        HttpContext.Session.Clear();
        return View("CerrarSesion");
    }
}
