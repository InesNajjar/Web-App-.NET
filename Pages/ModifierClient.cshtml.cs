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
    public class ModifierClientModel : PageModel
    {
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        GrowXDBContext _Context;
        public ModifierClientModel(GrowXDBContext databasecontext, IFileProvider fileprovider, IHostingEnvironment env)
        {
            fileProvider = fileprovider;
            hostingEnvironment = env;
            _Context = databasecontext;
        }

        [BindProperty]
        public Client client { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        public List<string> CompanyList { get; set; }
        public class InputModel
        {
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string CompanyName { get; set; }
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
                var data = (from client in _Context.Client
                            where client.IdC == id
                            select client).SingleOrDefault();
                client = data;
            }
        }
        public async Task<ActionResult> OnPostAsync(Client client, IFormFile file)
        {
          
            var cl = client;
            var context = new GrowXDBContext();
            Company projectcompany = context.Company.Where(p => p.Name == Input.CompanyName).Single();
            cl.IdCompany = projectcompany.IdCmp;

            if (file != null || file.Length != 0)
            {
                // Create a File Info 
                FileInfo fi = new FileInfo(file.FileName);

                // This code creates a unique file name to prevent duplications 
                // stored at the file location
                var newFilename = client.IdC + "_" + String.Format("{0:d}",
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
                client.ImagePath = pathToSave;
                // _context.Update(projet);
                //    await _context.SaveChangesAsync();
            }
            _Context.Entry(cl).Property(x => x.Name).IsModified = true;
            _Context.Entry(cl).Property(x => x.Domain).IsModified = true;
            _Context.Entry(cl).Property(x => x.Details).IsModified = true;
            _Context.Entry(cl).Property(x => x.PhoneNumber).IsModified = true;
            _Context.Entry(cl).Property(x => x.Mail).IsModified = true;
            _Context.Entry(cl).Property(x => x.LocationAddress).IsModified = true;
            _Context.Entry(cl).Property(x => x.Category).IsModified = true;    
            _Context.Entry(cl).Property(x => x.ImagePath).IsModified = true;
            _Context.Entry(cl).Property(x => x.IdCompany).IsModified = true;
            _Context.SaveChanges();
            return RedirectToPage("GestionClients");
        }
    }
}