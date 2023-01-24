using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Web.Contollers;

public class TarefasController : Controller
{
    public IActionResult Create() 
    {
        return View();
    }
}