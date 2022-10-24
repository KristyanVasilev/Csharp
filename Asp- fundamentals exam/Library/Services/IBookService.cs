using Library.Data.Models;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetAllAsync();

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task AddBookAsync(AddBookViewModel model);

        Task<IEnumerable<BookViewModel>> GetMyBooksAsync(string userId);

        Task AddBookToCollectionAsync(int bookId, string userId);

        Task RemoveBookFromCollectionAsync(int bookId, string userId);
    }
}
