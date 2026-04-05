

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Data;
using HelloWorld.Models;

namespace HelloWorld.Controllers;
[ApiController]
[Route("api/[controller]")]


public class BooksController : ControllerBase
{
    private readonly AppDbContext _context;

    public BooksController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
    {
        return await _context.Books.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Books>> PostBooks(Books books)
    {
        _context.Books.Add(books);
        await _context.SaveChangesAsync();

        return Ok(books);
    }
}