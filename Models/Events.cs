using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class Events
    {
        public int IdE { get; set; }
        public string Title { get; set; }
        public string Organizer { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? DateEvent { get; set; }
        public string ImageEvent { get; set; }
        public int? IdCompany { get; set; }
        public int? IdEventType { get; set; }
        public DateTime? DatePub { get; set; }

        public Company IdCompanyNavigation { get; set; }
        public EventType IdEventTypeNavigation { get; set; }
    }
}
