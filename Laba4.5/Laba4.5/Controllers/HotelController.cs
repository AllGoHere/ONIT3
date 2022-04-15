using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba4._5.Managers;
using Laba4._5.Managers.Hotels;
using Laba4._5.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkId=397860

namespace Laba4._5.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelsManager _manager ;

        public HotelController(IHotelsManager manager)
        {
            _manager = manager;
        }
        public async Task<ViewResult> ShowHotel()
        {
            var entity = await _manager.GetAll();
            return View(entity);

        }
       

        public ViewResult CreateHotel()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateHotels request)
        { 
            await _manager.AddHotel(request);
            return RedirectToAction(nameof(ShowHotel));
        }
        public async Task<ViewResult> EditHotel(Guid Id)
        {
            var entity = await _manager.GetById(Id);
            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid HotelId, CreateOrUpdateHotels request)
        {
            await _manager.EditHotel(HotelId, request);
            return RedirectToAction(nameof(ShowHotel));
        }
        public async Task<ActionResult> Kick(Hotel entity)
        {
            await _manager.Delete(entity);
            return RedirectToAction(nameof(ShowHotel));
        }
        public async Task<ViewResult> ShowAllHotel()
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
