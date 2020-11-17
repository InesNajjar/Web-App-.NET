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
    public class AjoutProjetModel : PageModel
    {
        private readonly GrowXDBContext _context;
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment hostingEnvironment;
        public string ReturnUrl { get; set; }
        public AjoutProjetModel(GrowXDBContext context,
                          IFileProvider fileprovider, IHostingEnvironment env)
        {
            _context = context;
            fileProvider = fileprovider;
            hostingEnvironment = env;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public Project projet { get; set; }
        public Company company { get; set; }
        public Client client { get; set; }
        public List<string> ClientList { get; set; }
        public List<string> CompanyList { get; set; }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public class InputModel
        {
            [Required]
            [Display(Name = "Name")]
            public string NameProj { get; set; }

            [Required]
            [Display(Name = "Details")]
            public string Details { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "DateBegin")]
            public DateTime DateBegin { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "DateFinish")]
            public DateTime DateFinish { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "TimeEstimated")]
            public int TimeEstimated { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "State")]
            public string State { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "ProgressPercent")]
            public int ProgressPercent { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "TimeSpent")]
            public int TimeSpent { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string CompanyName { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "ClientName")]
            public string ClientName { get; set; }

        }
        public List<string> getClientName()
        {
            var data = (from ClientList in _context.Client
                        select ClientList.Name).ToList();


            ClientList = data;
         
            return ClientList;
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
          public async Task<LocalRedirectResult> OnPostAsync([Bind("IdP,Name,Details,DateBegin,DateFinish,TimeEstim,State,ImagePath, ProgressPercent, TimeSpent")]Project projet, IFormFile file,string returnUrl = null)
          {
              returnUrl = returnUrl ?? Url.Content("~/GestionProjet");

              var context = new GrowXDBContext();
            Company projectcompany = context.Company.Where(p => p.Name == Input.CompanyName).Single();

            Client projectclient = context.Client.Where(n => n.Name == Input.ClientName).Single();

           


           

            projet = new Project() {
                  Name = Input.NameProj,
                  Details = Input.Details,
                  DateBegin = Input.DateBegin,
                  DateFinish = Input.DateFinish,
                  TimeEstimated = Input.TimeEstimated,
                  State = Input.State,
                  TimeSpent=Input.TimeSpent,        
                  ProgressPercent =Input.ProgressPercent,
                  IdCompany=projectcompany.IdCmp,
                  IdClient=projectclient.IdC
                  

            };
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
            
            context.Add(projet);
            context.SaveChanges();

            return LocalRedirect(returnUrl);

          }
   
    }
}
