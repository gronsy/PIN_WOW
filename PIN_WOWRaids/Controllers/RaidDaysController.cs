using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PIN_WOWRaids.Models;

namespace PIN_WOWRaids.Controllers
{
    public class RaidDaysController : Controller
    {
        private readonly PIN_WOWRaidsContext _context;

        public RaidDaysController(PIN_WOWRaidsContext context)
        {
            _context = context;
        }

        // GET: RaidDays
        public async Task<IActionResult> Index()
        {
            return View(await _context.RaidDays.ToListAsync());
        }

        // GET: RaidDays/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raidDays = await _context.RaidDays
                .SingleOrDefaultAsync(m => m.Id == id);
            if (raidDays == null)
            {
                return NotFound();
            }

            return View(raidDays);
        }

        // GET: RaidDays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RaidDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RaidName,RaidDate,PeopleAttended")] RaidDays raidDays)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raidDays);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(raidDays);
        }

        // GET: RaidDays/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raidDays = await _context.RaidDays.SingleOrDefaultAsync(m => m.Id == id);
            if (raidDays == null)
            {
                return NotFound();
            }
            return View(raidDays);
        }

        // POST: RaidDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,RaidName,RaidDate,PeopleAttended")] RaidDays raidDays)
        {
            if (id != raidDays.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raidDays);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaidDaysExists(raidDays.Id))
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
            return View(raidDays);
        }

        // GET: RaidDays/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raidDays = await _context.RaidDays
                .SingleOrDefaultAsync(m => m.Id == id);
            if (raidDays == null)
            {
                return NotFound();
            }

            return View(raidDays);
        }

        // POST: RaidDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var raidDays = await _context.RaidDays.SingleOrDefaultAsync(m => m.Id == id);
            _context.RaidDays.Remove(raidDays);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaidDaysExists(string id)
        {
            return _context.RaidDays.Any(e => e.Id == id);
        }
    }
}
