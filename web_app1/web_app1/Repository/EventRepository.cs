using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_app1.data;
using web_app1.Models;

namespace web_app1.Repository
{
    public class EventRepository
    {
        private readonly EventContext _context = null;
        public EventRepository(EventContext context)
        {
            _context = context;
        }
        public async Task<int> AddEvent(EventModel model)
        {
            var newEvent = new Events()
            {
                Title = model.Title,
                Category = model.Category,
                language = model.language,
                Description = model.Description,
                StartTime = DateTime.Now,
                EndTime = DateTime.UtcNow
            };

            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();
            return newEvent.Id;
        }
        public async Task<List<EventModel>> GetAllEvents()
        {
            var events = new List<EventModel>();
            var data = await _context.Events.ToListAsync();
            if (data?.Any() == true)
            {
                foreach (var event1 in data)
                {
                    events.Add(new EventModel()
                    {
                        Title = event1.Title,
                        Category = event1.Category,
                        Description = event1.Description,
                        language = event1.language,
                        StartTime = event1.StartTime,
                        EndTime = event1.EndTime
                    });
                }
            }
            return events;
        }
        public async Task<EventModel> GetEventById(int id)
        {
            var event1 = await _context.Events.FindAsync(id);
            //return DataSource().Where(x => x.Id == id).FirstOrDefault();
            if (event1 != null)
            {
                var eventDetails = new EventModel()
                {
                    Title = event1.Title,
                    Category = event1.Category,
                    Description = event1.Description,
                    language = event1.language,
                    StartTime = event1.StartTime,
                    EndTime = event1.EndTime
                };
            }
            return null;
        }
        public List<EventModel> SearchEvent(string title, string category)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Category.Contains(category)).ToList();
        }

        internal void AddNewEvent(EventModel eventModel)
        {
            throw new NotImplementedException();
        }

        private List<EventModel> DataSource()
        {
            return new List<EventModel>()
            {
                new EventModel(){Id=1 , Title="MVC", Description="Book of MVC", Category="Programming", language="English"},
                new EventModel(){Id=2 , Title="MVC1", Description="Book of MVC1", Category="Action", language="English"},
                new EventModel(){Id=3 , Title="MVC2", Description="Book of MVC2", Category="Programming", language="Hindi"},
                new EventModel(){Id=4 , Title="MVC3", Description="Book of MVC3", Category="Programming", language="English"}
            };
        }
    }
}
