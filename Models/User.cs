using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class User
    {
        public User()
        {
            ObjectivesIdColbNavigation = new HashSet<Objectives>();
            ObjectivesIdMngNavigation = new HashSet<Objectives>();
        }

        public string IdUser { get; set; }
        public int? IdCompany { get; set; }
        public string ImagePath { get; set; }

        public Company IdCompanyNavigation { get; set; }
        public AspNetUsers IdUserNavigation { get; set; }
        public ICollection<Objectives> ObjectivesIdColbNavigation { get; set; }
        public ICollection<Objectives> ObjectivesIdMngNavigation { get; set; }
    }
}
