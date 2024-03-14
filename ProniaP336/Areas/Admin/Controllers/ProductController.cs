using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP336.Contexts;

namespace ProniaP336.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller

{
    private readonly PronioDbContext _context;

    public ProductController(PronioDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
   
    public async Task<IActionResult> Create()
    {
        ViewBag.Categories = await _context.Categories.ToListAsync();
            return View();
    }
}
