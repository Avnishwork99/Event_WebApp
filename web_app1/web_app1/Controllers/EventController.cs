using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_app1.Models;
using web_app1.Repository;

namespace web_app1.Controllers
{
    public class EventController : Controller
    {
        private readonly EventRepository _eventRepository = null;

        public EventController(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<ViewResult> GetAllEvents()
        {
            var data = await _eventRepository.GetAllEvents();
            return View(data);
        }
        public async Task<ViewResult> GetEvent(int id)
        {
            var data = _eventRepository.GetEventById(id);
            return View(data);
        }
        public List<EventModel> SearchEvent(string bookName, string authorName)
        {
            return _eventRepository.SearchEvent(bookName, authorName);
        }
        public ViewResult AddEvent(bool isSuccess = false, int eventId = 0)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.EventId = eventId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEvent(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _eventRepository.AddEvent(eventModel);
                if (id > 0)
                {
                    return RedirectToAction("AddEvent", new { isSuccess = true });
                }
            }

            return View();    
        }
    }
}
