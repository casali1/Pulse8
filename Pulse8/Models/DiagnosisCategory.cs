using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Models
{
    public class DiagnosisCategory
    {
        public int DiagnosisCategoryID { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryScore { get; set; }

        public ICollection<DiagnosisCategoryMap> DiagnosisCategoryMaps { get; set; }
    }
}
