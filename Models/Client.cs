using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class Client
    {
        public Client()
        {
            Project = new HashSet<Project>();
        }

        public int IdC { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int? PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string ImagePath { get; set; }
        public string LocationAddress { get; set; }
        public int? IdCompany { get; set; }
        public string Category { get; set; }
        public string Details { get; set; }

        public Company IdCompanyNavigation { get; set; }
        public ICollection<Project> Project { get; set; }
    }
}
