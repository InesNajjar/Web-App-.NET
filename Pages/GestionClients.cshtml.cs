using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GrowX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrowX.Pages
{
    [Authorize(Roles = "Admin")]
    public class GestionClientsModel : PageModel
    {
        GrowXDBContext _Context;
        public GestionClientsModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet =true)]
        public string SearchName { get; set; }
      
            public List<Client> ClientList { get; set; }
        public void OnGet()
        {
            var data = (from ClientList in _Context.Client
                        select ClientList).ToList();

            ClientList = data;

            if (!string.IsNullOrEmpty(SearchName))
            {
                ClientList = (from ClientList in _Context.Client
                            where (ClientList.Name.Contains(SearchName)) 
                            orderby ClientList.IdC descending
                            select ClientList
                ).ToList();
              
            }

        }
        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from client in _Context.Client
                            where client.IdC == id
                            select client).SingleOrDefault();

                _Context.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToPage("GestionClients");
        }
    }
}