using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<MemberDiagnosis> MemberDiagnosises { get; set; }
    }
}
