using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GrowX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;

namespace GrowX.Pages
{
    [Authorize(Roles = "Admin")]
    public class ModifierProjetModel : PageModel
    {
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        GrowXDBContext _Context;
        public ModifierProjetModel(GrowXDBContext databasecontext, IFileProvider fileprovider, IHostingEnvironment env)
        {
            fileProvider = fileprovider;
            hostingEnvironment = env;
            _Context = databasecontext;
        }
        public List<string> ClientList { get; set; }
        public List<string> CompanyList { get; set; }

        [BindProperty]
        public Project projet { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public string CompanyName { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "ClientName")]
            public string ClientName { get; set; }

        }
        public List<string> getClientName()
        {
            var data = (from ClientList in _Context.Client
                        select ClientList.Name).ToList();


            ClientList = data;

            return ClientList;
        }
        public List<string> getCompanyName()
        {
            var data = (from CompanyList in _Context.Company
                        select CompanyList.Name).ToList();


            CompanyList = data;
            return CompanyList;
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from projet in _Context.Project
                            where projet.IdP == id
                            select projet).SingleOrDefault();
                projet = data;
            }
        }
        public async Task<ActionResult> OnPostAsync(Project projet, IFormFile file)
        {
            
            var proj = projet;

            var context = new GrowXDBContext();
            Company projectcompany = context.Company.Where(p => p.Name == Input.CompanyName).Single();

            Client projectclient = context.Client.Where(n => n.Name == Input.ClientName).Single();

            proj.IdCompany = projectcompany.IdCmp;
            proj.IdClient = projectclient.IdC;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (file != null || file.Length != 0)
            {
                // Create a File Info 
                FileInfo fi = new FileInfo(file.FileName);

                // This code creates a unique file name to prevent duplications 
                // stored at the file location
                var newFilename = projet.IdP + "_" + String.Format("{0:d}",
                                  (DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
                var webPath = hostingEnvironment.WebRootPath;
                var path = Path.Combine("", webPath + @"\images\img" + newFilename);

                // IMPORTANT: The pathToSave variable will be save on the column in the database
                var pathToSave = @"/images/img" + newFilename;

                // This stream the physical file to the allocate wwwroot/ImageFiles folder
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // This save the path to the record
                projet.ImagePath = pathToSave;
                // _context.Update(projet);
                //    await _context.SaveChangesAsync();
            }
           

            _Context.Entry(proj).Property(x => x.Name).IsModified = true;
            _Context.Entry(proj).Property(x => x.Details).IsModified = true;
            _Context.Entry(proj).Property(x => x.DateBegin).IsModified = true;
            _Context.Entry(proj).Property(x => x.DateFinish).IsModified = true;
            _Context.Entry(proj).Property(x => x.TimeEstimated).IsModified = true;
            _Context.Entry(proj).Property(x => x.State).IsModified = true;
            _Context.Entry(proj).Property(x => x.TimeSpent).IsModified = true;
            _Context.Entry(proj).Property(x => x.ProgressPercent).IsModified = true;
            _Context.Entry(proj).Property(x => x.ImagePath).IsModified = true;
            _Context.Entry(proj).Property(x => x.IdClient).IsModified = true;
            _Context.Entry(proj).Property(x => x.IdCompany).IsModified = true;
            _Context.SaveChanges();
            return RedirectToPage("GestionProjet");
        }
    }
}