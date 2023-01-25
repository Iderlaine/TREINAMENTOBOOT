using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Contollers;

public class TarefasController : Controller
{
    public IActionResult Create() 
    {
        return View();
    }

    public IActionResult Index () {
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel() {Titulo= "Escovar os dentes", Descricao = "Usar o sensodine de manhã e não a noite"},
            new TarefaViewModel() { Titulo= "Arrumar a cama "},
            new TarefaViewModel() { Titulo="Por o lixo para fora", Descricao ="Somente às terças"}
        };
        return View(listaDeTarefas);
    }
}