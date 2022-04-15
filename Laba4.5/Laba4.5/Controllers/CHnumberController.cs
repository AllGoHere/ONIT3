using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers;
using Laba4._5.Managers.CHnumbers;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace Laba4._5.Controllers
{
    public class CHnumberController : Controller
    {
        private readonly ICHnumbersManager _manager;

        public CHnumberController(ICHnumbersManager manager)
        {
            _manager = manager;
        }
        public async Task<ViewResult> ShowCHnumber(Guid Id)
        {
            Perenos perenos = new Perenos();
            Perenos.chnumbers = (List<CHnumber>)await _manager.GetAll();
            Perenos.Guid = Id;
            return View(perenos);

        }
        public async Task<ViewResult> AfterShowCHnumber()
        {
            Perenos perenos = new Perenos();
            Perenos.chnumbers = (List<CHnumber>)await _manager.GetAll();
            return View(perenos);
        }

        public ViewResult CreateCHnumber()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateCHnumbers request)
        {
            request.HotelId = Perenos.Guid;
            await _manager.AddCHnumber(request);
            return RedirectToAction(nameof(AfterShowCHnumber));
        }
        public async Task<ViewResult> EditCHnumber(Guid Id)
        {
            var entity = await _manager.GetById(Id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid CHnumberId, CreateOrUpdateCHnumbers request)
        {
            await _manager.EditCHnumber(CHnumberId, request);
            return RedirectToAction(nameof(AfterShowCHnumber));
        }
        public async Task<ActionResult> Kick(CHnumber entity)
        {
            await _manager.Delete(entity);
            return RedirectToAction(nameof(AfterShowCHnumber));
        }
        public async Task<ViewResult> ShowAllCHnumbers()
        {
            Perenos perenos = new Perenos();
            Perenos.chnumbers = (List<CHnumber>)await _manager.GetAll();
            return View(perenos);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
