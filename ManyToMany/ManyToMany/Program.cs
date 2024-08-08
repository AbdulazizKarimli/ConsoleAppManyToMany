using ManyToMany.DTOs.BookDtos;
using ManyToMany.DTOs.SaleDtos;
using ManyToMany.Models;
using ManyToMany.Services.Implementations;
using ManyToMany.Services.Interfaces;

//IAuthorService authorService = new AuthorService();
//Author author = new Author
//{
//    Name = "Aqil"
//};
//await authorService.CreateAuthorAsync(author);

//IBookService bookService = new BookService();
//BookPostDto bookPostDto = new BookPostDto()
//{
//    Name = "Sefiller",
//    Description = "test",
//    AuthorId = 1,
//    Price = 15,
//    StockCount = 3
//};
//await bookService.CreateBookAsync(bookPostDto);

//var books = await bookService.GetAllBooksAsync();
//foreach (var item in books)
//{
//    Console.WriteLine($"Book name: {item.Name} - Book Description: {item.Description} - Book Price: {item.Price} - Book Stock Count: {item.StockCount} - Author name: {item.Author.Name}");
//}

ICustomerService customerService = new CustomerService();
//await customerService.CreateCustomerAsync(new Customer { Name = "Rizvan", Email = "rizvan@mail.ru"});

//ISaleService saleService = new SaleService();
//SaleDto saleDto = new SaleDto
//{
//    BookId = 1,
//    CustomerId = 1,
//    Count = 2
//};
//await saleService.AddSaleAsync(saleDto);

//var customers = await customerService.GetAllCustomersAsync();
//foreach (var customer in customers)
//{
//    foreach (var sale in customer.Sales)
//    {
//        Console.WriteLine($"Customer name: {customer.Name} - Customer email: {customer.Email} - Book name: {sale.Book.Name} - Book Author: {sale.Book.Author.Name} - Book Saled Count: {sale.BookCount} - Total price: {sale.TotalPrice}");
//    }
//}