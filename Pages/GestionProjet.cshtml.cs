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
    public class GestionProjetModel : PageModel
    {
        GrowXDBContext _Context;
        public GestionProjetModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        public List<Project> ProjectList { get; set; }
        public void OnGet()
        {
            var data = (from ProjectList in _Context.Project
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
        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from projet in _Context.Project
                            where projet.IdP == id
                            select projet).SingleOrDefault();

                _Context.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToPage("GestionProjet");
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