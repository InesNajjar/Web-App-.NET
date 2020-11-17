using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class Project
    {
        public int IdP { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateFinish { get; set; }
        public int? TimeSpent { get; set; }
        public int? TimeEstimated { get; set; }
        public int? ProgressPercent { get; set; }
        public string State { get; set; }
        public int? IdCompany { get; set; }
        public int? IdClient { get; set; }

        public Client IdClientNavigation { get; set; }
        public Company IdCompanyNavigation { get; set; }
    }
}
