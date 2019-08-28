using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pulse8.Data;
using Pulse8.Models;
using Pulse8.Service;

namespace Pulse8.Controllers
{
    public class MembersController : Controller
    {

        private readonly PulseContext _context;
        private readonly AccessingData _accessingData = new AccessingData();

        public MembersController(PulseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            //This is the solution to the first coding challenge question.
            var member = await _context.Members.Include(md => md.MemberDiagnosises)
                                                 .ThenInclude(d => d.Diagnosis)
                                                 .ThenInclude(dcm => dcm.DiagnosisCategoryMaps)
                                                 .ThenInclude(dc => dc.DiagnosisCategory)
                                                 .AsNoTracking().FirstOrDefaultAsync(m => m.MemberID == id);

           var diagnosisCategoryList = _accessingData.NavigatingCollection(member, id);

            if (member == null) return NotFound();

            return View(member);
        }
    }
}