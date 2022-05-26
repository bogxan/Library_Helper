using LibraryHelperBLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperBLL.Interfaces
{
    public interface IBookService
    {
        Task AddBook(BookDto book);
        Task DeleteBook(int id);
        Task UpdateBook(BookDto book);
        Task<List<BookDto>> SearchBooksByName(string name);
        Task<List<BookDto>> SearchBooksByAuthor(string author);
        Task<List<BookDto>> SearchBooksByGenre(string genre);
        Task<List<BookDto>> SearchBooksByPublOffice(string office);
        Task<List<BookDto>> SearchBooksByPublDate(int year);
    }
}
