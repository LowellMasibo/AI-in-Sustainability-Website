using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMvcWebSite.Data;
using AspNetCoreMvcWebSite.Models;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreMvcWebSite.Controllers
{
    public class AIImagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnv;

        public AIImagesController(ApplicationDbContext context, IWebHostEnvironment hostingEnv)
        {
            _context = context;
            _hostingEnv = hostingEnv;
        }

        // GET: AIImages
        public async Task<IActionResult> Index()
        {
            return View(await _context.AIImages.ToListAsync());
        }

        // GET: AIImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aIImages = await _context.AIImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aIImages == null)
            {
                return NotFound();
            }

            return View(aIImages);
        }

        // GET: AIImages/Create
        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AIImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create([Bind("Id,Prompt,ImageGenerator,UploadDate,Filename,Like,canIncreaseLike")] AIImages aIImages, UploadFile uploadFile)
        {
            if (uploadFile.File != null)
            {
                var fileName = Path.GetFileName(uploadFile.File.FileName);
                var filePath = Path.Combine(_hostingEnv.WebRootPath, "uploads",
                fileName);
                using (var fileStream = new FileStream(filePath,
                FileMode.Create))
                {
                    await uploadFile.File.CopyToAsync(fileStream);
                }
                aIImages.Filename = fileName;
            }
            if (ModelState.IsValid)
            {
                _context.Add(aIImages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aIImages);
        }

        // GET: AIImages/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aIImages = await _context.AIImages.FindAsync(id);
            if (aIImages == null)
            {
                return NotFound();
            }
            return View(aIImages);
        }

        // POST: AIImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prompt,ImageGenerator,UploadDate,Filename,Like,canIncreaseLike")] AIImages aIImages)
        {
            if (id != aIImages.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aIImages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AIImagesExists(aIImages.Id))
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
            return View(aIImages);
        }

        // GET: AIImages/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aIImages = await _context.AIImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aIImages == null)
            {
                return NotFound();
            }

            return View(aIImages);
        }

        // POST: AIImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aIImages = await _context.AIImages.FindAsync(id);
            if (aIImages != null)
            {
                _context.AIImages.Remove(aIImages);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AIImagesExists(int id)
        {
            return _context.AIImages.Any(e => e.Id == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Like(int id)
        {
            var image = await _context.AIImages.FindAsync(id);
            if (image == null)
                return NotFound();

            image.LikesCount++;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
