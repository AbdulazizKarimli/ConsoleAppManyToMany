using ManyToMany.DTOs.BookDtos;
using ManyToMany.Models;

namespace ManyToMany.Services.Interfaces;

public interface IBookService
{
    Task<List<BookGetDto>> GetAllBooksAsync();
    Task CreateBookAsync(BookPostDto newBook);
}