using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Models
{
    public class DiagnosisCategoryMap
    {
        [Key]
        public int DiagnosisCategoryMapID { get; set; }

        public int DiagnosisCategoryID { get; set; }
        public int DiagnosisID { get; set; }

        public DiagnosisCategory DiagnosisCategory { get; set; }
        public Diagnosis Diagnosis { get; set; }
    }
}
