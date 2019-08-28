using Pulse8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse8.Service
{
    public class AccessingData
    {
        public List<DiagnosisCategory> NavigatingCollection(Member member, int? id)
        {
            var diagnosisCategoryList = new List<DiagnosisCategory>();

            var memberDiagnosesList = member.MemberDiagnosises.Where(m => m.MemberID == id).ToList();

            var count = memberDiagnosesList.Count;

            for (int i=0; i<count; i++)
            {
                var memberDiagnosis = memberDiagnosesList[i];
                foreach (var diagnosisCategoryMap in memberDiagnosis.Diagnosis.DiagnosisCategoryMaps)
                {
                    var diagnosisCategory = new DiagnosisCategory
                    {
                        DiagnosisCategoryID = diagnosisCategoryMap.DiagnosisCategory.DiagnosisCategoryID,
                        CategoryDescription = diagnosisCategoryMap.DiagnosisCategory.CategoryDescription,
                        CategoryScore = diagnosisCategoryMap.DiagnosisCategory.CategoryScore
                    };

                    diagnosisCategoryList.Add(diagnosisCategory);
                }
            }

            return diagnosisCategoryList;
        }
    }
}
