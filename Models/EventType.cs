using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Events>();
        }

        public int IdTypeEvent { get; set; }
        public string Name { get; set; }

        public ICollection<Events> Events { get; set; }
    }
}
