using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Models
{
    public class MemberDiagnosis
    {
        [Key]
        public int MemberDiagnosisID { get; set; }
        public int MemberID { get; set; }
        public int DiagnosisID { get; set; }

        public Member Member { get; set; }
        public Diagnosis Diagnosis { get; set; }
    }
}
