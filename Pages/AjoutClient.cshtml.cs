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
    public class AjoutClientModel : PageModel
    {
        private readonly GrowXDBContext _context;
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        public string ReturnUrl { get; set; }
        public AjoutClientModel(GrowXDBContext context,
                          IFileProvider fileprovider, IHostingEnvironment env)
        {
            _context = context;
            fileProvider = fileprovider;
            hostingEnvironment = env;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public Client client { get; set; }
        public List<string> CompanyList { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public class InputModel
        {
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Domain")]
            public string Domain { get; set; }

            [Required]
            [Display(Name = "Details")]
            public string Details { get; set; }

            [Required]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "PhoneNumber")]
            public int PhoneNumber { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Mail")]
            public string Mail { get; set; }
    
            [DataType(DataType.Text)]
            [Display(Name = "ImagePath")]
            public string ImagePath { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Location")]
            public string Location { get; set; }
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Category")]
            public string Category { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string CompanyName { get; set; }


        }
        public List<string> getCompanyName()
        {
            var data = (from CompanyList in _context.Company
                        select CompanyList.Name).ToList();


            CompanyList = data;
            return CompanyList;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<LocalRedirectResult> OnPostAsync([Bind("IdC,Name,Domain,Details,PhoneNumber,Mail,ImagePath,Location,Category")]Client client, IFormFile file, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/GestionClients");

            var context = new GrowXDBContext();
            Company projectcompany = context.Company.Where(p => p.Name == Input.CompanyName).Single();
            client = new Client()
            {
                Name = Input.Name,
                Domain = Input.Domain,
                Details=Input.Details,
                PhoneNumber = Input.PhoneNumber,
                Mail = Input.Mail,
                LocationAddress = Input.Location,
                Category = Input.Category,
                IdCompany = projectcompany.IdCmp
            };
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
            context.Add(client);
            context.SaveChanges();

            return LocalRedirect(returnUrl);

        }

    }
}