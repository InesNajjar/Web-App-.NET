using System;
using System.Collections.Generic;
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
    public class ModifierEventModel : PageModel
    {
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        GrowXDBContext _Context;
        public ModifierEventModel(GrowXDBContext databasecontext, IFileProvider fileprovider, IHostingEnvironment env)
        {
            fileProvider = fileprovider;
            hostingEnvironment = env;
            _Context = databasecontext;
        }
 
        [BindProperty]
        public Events evenement { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            // Input for Event Type (to complete)

        }
        
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
        public async Task<ActionResult> OnPostAsync(Events evenement, IFormFile file)
        {

            var evnt = evenement;

            var context = new GrowXDBContext();
       

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
                var newFilename = evnt.IdE + "_" + String.Format("{0:d}",
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
                evnt.ImageEvent= pathToSave;
                // _context.Update(projet);
                //    await _context.SaveChangesAsync();
            }


            _Context.Entry(evnt).Property(x => x.Title).IsModified = true;
            _Context.Entry(evnt).Property(x => x.Description).IsModified = true;
            _Context.Entry(evnt).Property(x => x.Organizer).IsModified = true;
            _Context.Entry(evnt).Property(x => x.DateEvent).IsModified = true;
            _Context.Entry(evnt).Property(x => x.Location).IsModified = true;
            _Context.Entry(evnt).Property(x => x.ImageEvent).IsModified = true;
            
            _Context.SaveChanges();
            return RedirectToPage("GestionEvents");
        }
    }
}