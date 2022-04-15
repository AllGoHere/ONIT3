using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers;
using Laba4._5.Managers.Numbers;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace Laba4._5.Controllers
{
    public class NumberController : Controller
    {
        private readonly INumbersManager _manager;

        public NumberController (INumbersManager manager )
        {
            _manager = manager;
        }

        [HttpGet]

        public async Task<ViewResult> ShowNumbers(Guid Id)
        {
            Perenos perenos = new Perenos();
            Perenos.Guid = Id;
            Perenos.number = (List<Number>)await _manager.GetAll();
            return View(perenos);
        }
        public async Task<ViewResult> AfterShowNumbers()
        {
            Perenos perenos = new Perenos();
            Perenos.number = (List<Number>)await _manager.GetAll();
            return View(perenos);
        }
        public ViewResult CreateNumber()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateNumbers request)
        {
            request.CHNumberId = Perenos.Guid;
            await _manager.AddNumber(request);
            return RedirectToAction(nameof(AfterShowNumbers));
        }
        public async Task<ViewResult> EditNumber(Guid Id)
        {
            var entity = await _manager.GetById(Id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid NumberId, CreateOrUpdateNumbers request)
        {
            await _manager.EditNumber(NumberId, request);
            return RedirectToAction(nameof(AfterShowNumbers));
        }

        public async Task<ActionResult> Kick(Number entity)
        {
            await _manager.Delete(entity);
            return RedirectToAction(nameof(AfterShowNumbers));
        }

        public async Task<ViewResult> ShowAllNumbers()
        {
            Perenos perenos = new Perenos();
            Perenos.number = (List<Number>)await _manager.GetAll();
            return View(perenos);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
