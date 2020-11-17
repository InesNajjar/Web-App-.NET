using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class Company
    {
        public Company()
        {
            Client = new HashSet<Client>();
            Events = new HashSet<Events>();
            Project = new HashSet<Project>();
            User = new HashSet<User>();
        }

        public int IdCmp { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }

        public ICollection<Client> Client { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<User> User { get; set; }
    }
}
