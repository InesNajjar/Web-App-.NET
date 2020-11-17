using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GrowX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;

namespace GrowX.Pages
{
    [Authorize]
    public class ConsulterEventModel : PageModel
    {
        GrowXDBContext _Context;
        public ConsulterEventModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }

        [BindProperty]
        public static Events evenement { get; set; }
        
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from evnt in _Context.Events
                            where evnt.IdE == id
                            select evnt).SingleOrDefault();

                evenement = data;
            }  
        }
        public string getCategoryName(int id)
        {
          EventType Cm = _Context.EventType.Where(p => p.IdTypeEvent == id).Single();
            return Cm.Name;
        }
    }
}