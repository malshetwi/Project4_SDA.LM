using malshetwi_Project4_SDA.LMS.Data;
using malshetwi_Project4_SDA.LMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace malshetwi_Project4_SDA.LMS.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;

        }
        // Get Items
        public async Task<IActionResult> Index()
        {
           // var data = _context.Items.ToList();
            return View(await _context.Items.ToListAsync());
        }
        //~


        // GET: Items/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Item = await _context.Items.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return View(Item);
        }

        // POST: Items/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemID,ItemPicURL,ItemName,ItemBio,Price")] Item Item)
        {
            if (id != Item.ItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(Item.ItemID))
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
            return View(Item);
        }
        //~

        // GET: Orders/Order  (SameEdit)
        public async Task<IActionResult> Checkout(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Item = await _context.Items.FindAsync(id);
            if (Item == null)
            {
                return NotFound();
            }
            return View(Item);
        }
        // POST: Orders/Order v
        // POST: Order/Creation

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrder([Bind("ItemID")] Order Order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Order);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(CreateOrder));
            }
            return View(Order);
        }




        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.ItemID == id);
        }
    }
}

    