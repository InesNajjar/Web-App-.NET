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
    public class ListeClientsModel : PageModel
    {
        GrowXDBContext _Context;
        public ListeClientsModel(GrowXDBContext databasecontext)
        {
            _Context = databasecontext;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        public List<Client> ClientList { get; set; }
        public void OnGet()
        {
            var data = (from ClientList in _Context.Client
                        orderby ClientList.IdC
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
    }
}