using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrowX.Pages
{
    [Authorize]
    public class EventTimelineModel : PageModel
    {
        GrowXDBContext _Context;
        public EventTimelineModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        public List<Events> EventList { get; set; }
        public void OnGet()
        {
            var data = (from eventlist in _Context.Events
                        orderby
                        eventlist.DateEvent descending
                        select eventlist
                        ).ToList();

            EventList = data;
            if (!string.IsNullOrEmpty(SearchName))
            {
                EventList = (from EventList in _Context.Events
                              where (EventList.Title.Contains(SearchName))
                              orderby EventList.IdE descending
                              select EventList
                ).ToList();
            }
        }
        public string getTypeEvent(int id)
        {
            EventType Cm = _Context.EventType.Where(p => p.IdTypeEvent == id).Single();
            return Cm.Name;
        }
       
    }
}
