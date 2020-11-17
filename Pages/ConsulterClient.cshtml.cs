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
    public class ConsulterClientModel : PageModel
    {
        GrowXDBContext _Context;
        public ConsulterClientModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }

        [BindProperty]
        public static Client client { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from client in _Context.Client
                            where client.IdC == id
                            select client).SingleOrDefault();
                client = data;
            }
        }
        public string getCompanyName(int id)
        {
            Company Cm = _Context.Company.Where(p => p.IdCmp == id).Single();
            return Cm.Name;
        }
       
    }
}