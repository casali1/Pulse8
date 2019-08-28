using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Models
{
    public class Diagnosis
    {
        public int DiagnosisID { get; set; }
        public string DiagnosisDescription { get; set; }

        public ICollection<DiagnosisCategoryMap> DiagnosisCategoryMaps { get; set; }
        public ICollection<MemberDiagnosis> MemberDiagnosises { get; set; }
    }
}
