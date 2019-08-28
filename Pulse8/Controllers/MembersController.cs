using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pulse8.Data;
using Pulse8.Models;

namespace Pulse8.Controllers
{
    public class MembersController : Controller
    {

        private readonly PulseContext _context;

        public MembersController(PulseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ViewData["id"] = id;

            Member member = new Member();

            if (id != null)
            {

                if (id == null) return NotFound();

                member = await _context.Members
                                    .AsNoTracking().FirstOrDefaultAsync(m => m.MemberID == id);

                //if (member == null) return NotFound();
            }

            return View(member);
        }
    }
}