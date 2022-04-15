using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers;
using Laba4._5.Managers.Clients;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace Laba4._5.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientsManager _manager;

        public ClientController(IClientsManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowClients(Guid Id)
        {
            Perenos perenos = new Perenos();
            Perenos.clients = (List<Client>)await _manager.GetAll();
            Perenos.Guid = Id;
            return View(perenos);

        }
        public async Task<ViewResult> Answer(string InputStr)
        {

            Perenos perenos = new Perenos();
            Perenos.clients = (List<Client>)await _manager.GetAll();
            Perenos.poisk = InputStr;

            return View(perenos);

        }

        public async Task<ViewResult> AfterShowClients()
        {
            Perenos perenos = new Perenos();
            Perenos.clients = (List<Client>)await _manager.GetAll();
            return View(perenos);
        }

        public ViewResult CreateClient()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateClients request)
        {
            request.NumberId = Perenos.Guid;
            await _manager.AddClient(request);
            return RedirectToAction(nameof(AfterShowClients));
        }
        public async Task<ViewResult> EditClient(Guid Id)
        {
            var entity = await _manager.GetById(Id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid ClientId, CreateOrUpdateClients request)
        {
            await _manager.EditClient(ClientId, request);
            return RedirectToAction(nameof(AfterShowClients));
        }

        public async Task<ActionResult> Kick(Client entity)
        {
            await _manager.Delete(entity);
            return RedirectToAction(nameof(AfterShowClients));
        }

        public async Task<ViewResult> ShowAllClients()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
