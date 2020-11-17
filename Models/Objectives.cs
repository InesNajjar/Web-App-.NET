using System;
using System.Collections.Generic;

namespace GrowX.Models
{
    public partial class Objectives
    {
        public int IdObj { get; set; }
        public string ObjectiveName { get; set; }
        public string Description { get; set; }
        public string ColbComment { get; set; }
        public string MngrComment { get; set; }
        public bool? Validation { get; set; }
        public int? Rating { get; set; }
        public int? TimeEstimation { get; set; }
        public int? Progression { get; set; }
        public string Type { get; set; }
        public string IdMng { get; set; }
        public string IdColb { get; set; }

        public User IdColbNavigation { get; set; }
        public User IdMngNavigation { get; set; }
    }
}
