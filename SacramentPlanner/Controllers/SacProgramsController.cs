using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class SacProgramsController : Controller
    {
        private readonly SacramentPlannerContext _context;

        public SacProgramsController(SacramentPlannerContext context)
        {
            _context = context;
        }

        // GET: SacPrograms
        public async Task<IActionResult> Index(string searchString)
        {
            var programs = from m in _context.Program
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                programs = programs.Where(s => s.FirstSpeaker.Contains(searchString));
            }

            return View(await programs.ToListAsync());
        }

        // GET: SacPrograms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacProgram = await _context.Program
                .SingleOrDefaultAsync(m => m.ID == id);
            if (sacProgram == null)
            {
                return NotFound();
            }

            return View(sacProgram);
        }

        // GET: SacPrograms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SacPrograms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Date,Conducting,OpeningSong,OpeningPrayer,SacramentSong,FirstSpeaker,SecondSpeaker,IntermediateSong,ThirdSpeaker,ClosingSong,ClosingPrayer")] SacProgram sacProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacProgram);
        }

        // GET: SacPrograms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacProgram = await _context.Program.SingleOrDefaultAsync(m => m.ID == id);
            if (sacProgram == null)
            {
                return NotFound();
            }
            return View(sacProgram);
        }

        // POST: SacPrograms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,Conducting,OpeningSong,OpeningPrayer,SacramentSong,FirstSpeaker,SecondSpeaker,IntermediateSong,ThirdSpeaker,ClosingSong,ClosingPrayer")] SacProgram sacProgram)
        {
            if (id != sacProgram.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacProgramExists(sacProgram.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sacProgram);
        }

        // GET: SacPrograms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacProgram = await _context.Program
                .SingleOrDefaultAsync(m => m.ID == id);
            if (sacProgram == null)
            {
                return NotFound();
            }

            return View(sacProgram);
        }

        // POST: SacPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacProgram = await _context.Program.SingleOrDefaultAsync(m => m.ID == id);
            _context.Program.Remove(sacProgram);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacProgramExists(int id)
        {
            return _context.Program.Any(e => e.ID == id);
        }
    }
}
