using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Katzavia.Data;
using Katzavia.Models;

namespace Katzavia.Controllers
{
    public class ProductsController : Controller
    {
        private readonly KatzaviaContext _context;

        public ProductsController(KatzaviaContext context)
        {
            _context = context;
        }

        // GET: Products
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var KatzaviaContext = _context.Product.Include(c => c.Category);
            return View(await KatzaviaContext.ToListAsync());
        }
        public async Task<IActionResult> Menu()
        {
            var KatzaviaContext = _context.Product.Include(c => c.Category);
            return View(await KatzaviaContext.ToListAsync());
        }
        public async Task<IActionResult> Search(string queryN)
        {
            var KatzaviaContext = _context.Product.Include(c => c.Category).Where(p => p.Name.Contains(queryN) ||
                                    (queryN == null) || (p.Desc.Contains(queryN)));
            return View("Menu", await KatzaviaContext.ToListAsync());
        }
        public async Task<IActionResult> advSearch(string queryP, string queryC, string queryM)
        {
            var KatzaviaContext = _context.Product.Include(a => a.Category).Where(a =>
                                    (a.Name.Contains(queryP) || a.Desc.Contains(queryP))
                                    && a.Category.Name.Equals(queryC)
                                    && a.Price <= (Int32.Parse(queryM)));
            return View("Menu", await KatzaviaContext.ToListAsync());
        }
        public async Task<IActionResult> Buttom(string ctN)
        {
            var KatzaviaContext = _context.Product.Include(c => c.Category).Where(p => p.Category.Name.Equals(ctN) ||
                                    (ctN == null));
            return View("Menu", await KatzaviaContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.Include(c => c.Category).Include(t => t.myTags)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["Categoriess"] = new SelectList(_context.Category, nameof(Category.Id), nameof(Category.Name));
            ViewData["Tagss"] = new SelectList(_context.Tags, nameof(Tags.Id), nameof(Tags.Name));

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Desc,Image,CategoryId,myTags")] Product product, int[] myTags) //po mosifim CategoryId she ze istader
        {
            product.myTags = new List<Tags>();
            product.myTags.AddRange(_context.Tags.Where(x => myTags.Contains(x.Id)));
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Categoriess"] = new SelectList(_context.Category, nameof(Category.Id), nameof(Category.Name));
            ViewData["Tagss"] = new SelectList(_context.Tags, nameof(Tags.Id), nameof(Tags.Name));
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Desc,Image,CategoryId,myTags")] Product product, int[] myTags)
        {
            if (id != product.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    Product pro = _context.Product.Include(p => p.myTags).FirstOrDefault(p => p.Id == product.Id);

                    product.myTags = new List<Tags>();
                    product.myTags.AddRange(_context.Tags.Where(x => myTags.Contains(x.Id)));
                    if (ModelState.IsValid)
                    {
                        _context.Add(product);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    return View(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
