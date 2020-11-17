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
    [Authorize(Roles = "Admin")]
    public class GestionEventsModel : PageModel
    {
        GrowXDBContext _Context;
        public GestionEventsModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }
        public List<Events> EventList { get; set; }
        public void OnGet()
        {
            var data = (from EventList in _Context.Events
                        select EventList).ToList();

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
    
        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from evnt in _Context.Events
                            where evnt.IdE == id
                            select evnt).SingleOrDefault();

                _Context.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToPage("GestionEvents");
        }
    }
}