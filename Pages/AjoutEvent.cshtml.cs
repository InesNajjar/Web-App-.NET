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
    public class AjoutEventModel : PageModel
    {
        private readonly GrowXDBContext _context;
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        public string ReturnUrl { get; set; }
        public AjoutEventModel(GrowXDBContext context,
                          IFileProvider fileprovider, IHostingEnvironment env)
        {
            _context = context;
            fileProvider = fileprovider;
            hostingEnvironment = env;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public Events evenement { get; set; }
        public EventType eventType { get; set; }
        public List<string> typeList { get; set; }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public class InputModel
        {
            [Required]
            [Display(Name = "Title")]
            public string Title { get; set; }

            [Required]
            [Display(Name = "Description")]
            public string Description { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Organizer")]
            public string Organizer { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "DateEvent")]
            public DateTime DateEvent { get; set; }          

            [DataType(DataType.Text)]
            [Display(Name = "Location")]
            public string Location { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "ImageEvent")]
            public string ImageEvent { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "TypeEvent")]
            public string TypeEvent { get; set; }

        }
        public List<string> getEventType()
        {
            var data = (from typeList in _context.EventType
                        select typeList.Name).ToList();


            typeList = data;

            return typeList;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<LocalRedirectResult> OnPostAsync([Bind("IdE,Title,Organizer,Description,DateEvent,Location,ImageEvent")]Events evenement, IFormFile file, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/GestionEvents");

            var context = new GrowXDBContext();
         
            EventType typeEv = context.EventType.Where(n => n.Name == Input.TypeEvent).Single();

            evenement = new Events()
            {
                Title = Input.Title,
                Organizer = Input.Organizer,
                Description= Input.Description,
                DateEvent =Input.DateEvent,
                Location = Input.Location,
                DatePub = DateTime.Today.Date,
                IdEventType = typeEv.IdTypeEvent
           
            };
            if (file != null || file.Length != 0)
            {
                // Create a File Info 
                FileInfo fi = new FileInfo(file.FileName);

                // This code creates a unique file name to prevent duplications 
                // stored at the file location
                var newFilename = evenement.IdE + "_" + String.Format("{0:d}",
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
                evenement.ImageEvent = pathToSave;
                // _context.Update(projet);
                //    await _context.SaveChangesAsync();
            }

            context.Add(evenement);
            context.SaveChanges();

            return LocalRedirect(returnUrl);

        }

    }
}