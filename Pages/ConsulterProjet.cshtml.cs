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
    public class ConsulterProjetModel : PageModel
    {
        GrowXDBContext _Context;
        public ConsulterProjetModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }

        [BindProperty]
        public static Project projet { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
          var   data = (from projet in _Context.Project
                            where projet.IdP == id
                            select projet).SingleOrDefault();
               
                projet = data;
            }
        }
        public string getCompanyName(int id)
        {
            Company Cm = _Context.Company.Where(p => p.IdCmp == id).Single();
            return Cm.Name;
        }
        public string getClientName(int id)
        {
            Client Cl = _Context.Client.Where(p => p.IdC == id).Single();
            return Cl.Name;
        }
    }
    }