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
    public class ListeProjetsModel : PageModel
    {
        GrowXDBContext _Context;
        public ListeProjetsModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        public List<Project> ProjectList { get; set; }
        public void OnGet()
        {
            var data = (from ProjectList in _Context.Project
                        orderby ProjectList.IdP
                        select ProjectList).ToList();

            ProjectList = data;
            if (!string.IsNullOrEmpty(SearchName))
            {
                ProjectList = (from ProjectList in _Context.Project
                              where (ProjectList.Name.Contains(SearchName))
                               orderby ProjectList.IdP descending
                               select ProjectList
                ).ToList();

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