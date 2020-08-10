using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListaClientes = new ClienteModal().ListarTodosClientes();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            if(id != null)
            {
                //Carregar o registro do clientre
                ViewBag.Cliente = new ClienteModal().RetornarCliente(id);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteModal cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Gravar();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Excluir(int id)
        {
            ViewData["IdExcluir"] = id;
            return View();
        }

        public IActionResult ExcluirCliente(int id)
        {
            new ClienteModal().Excluir(id);
            return View();
        }
    }
}
