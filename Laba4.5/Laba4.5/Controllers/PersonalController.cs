using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers;
using Laba4._5.Managers.Personals;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace Laba4._5.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalsManager _manager;

        public PersonalController(IPersonalsManager manager)
        {
            _manager = manager;
        }

        [HttpGet]

        public async Task<ViewResult> ShowPersonals(Guid Id)
        {
            Perenos perenos = new Perenos();
            Perenos.Guid = Id;
            Perenos.personals = (List<Personal>)await _manager.GetAll();
            return View(perenos);
        }
        public async Task<ViewResult> AfterShowPersonals()
        {
            Perenos perenos = new Perenos();
            Perenos.personals= (List<Personal>)await _manager.GetAll();
            return View(perenos);
        }
        public ViewResult CreatePersonal()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdatePersonals request)
        {
            request.HotelId = Perenos.Guid;
            await _manager.AddPersonal(request);
            return RedirectToAction(nameof(AfterShowPersonals));
        }
        public async Task<ViewResult>  EditPersonal(Guid Id)
        {
            var entity = await _manager.GetById(Id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid PersonalId, CreateOrUpdatePersonals request)
        {
            await _manager.EditPersonal(PersonalId, request);
            return RedirectToAction(nameof(AfterShowPersonals));
        }

        public async Task<ActionResult> Kick(Personal entity)
        {
            await _manager.Delete(entity);
            return RedirectToAction(nameof(AfterShowPersonals));
        }

        public async Task<ViewResult> ShowAllPersonals()
        {
            Perenos perenos = new Perenos();
            Perenos.personals = (List<Personal>)await _manager.GetAll();
            return View(perenos);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
