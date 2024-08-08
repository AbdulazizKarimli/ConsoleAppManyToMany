using ManyToMany.Contexts;
using ManyToMany.DTOs.BookDtos;
using ManyToMany.Models;
using ManyToMany.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Services.Implementations;

public class BookService : IBookService
{
    private readonly AppDbContext _context;
    public BookService()
    {
        _context = new AppDbContext();
    }

    public async Task CreateBookAsync(BookPostDto newBook)
    {
        Book book = new Book
        {
            Name = newBook.Name,
            Description = newBook.Description,
            Price = newBook.Price,
            StockCount = newBook.StockCount,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            AuthorId = newBook.AuthorId
        };

        await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
    }

    public async Task<List<BookGetDto>> GetAllBooksAsync()
    {
        var books = await _context.Books.Include(b => b.Author).ToListAsync();
        List<BookGetDto> bookList = new List<BookGetDto>();
        foreach (var book in books) 
        {
            bookList.Add(new BookGetDto
            {
                Name = book.Name,
                Description = book.Description,
                Price = book.Price,
                StockCount = book.StockCount,
                AuthorId = book.AuthorId,
                Author = book.Author
            });
        }
        return bookList;
    }
}