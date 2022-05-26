using LibraryHelperBLL.DTO;
using LibraryHelperBLL.Interfaces;
using LibraryHelperDAL.Entities;
using LibraryHelperDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperBLL.Services
{
    public class BooksService : IBookService
    {
        private readonly IUnitOfWork uow;
        private readonly AutoMapper.ObjectMapper objectManager = AutoMapper.ObjectMapper.Instance;
        public BooksService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public async Task AddBook(BookDto book)
        {
            var result = objectManager.Mapper.Map<Book>(book);
            await uow.BooksRepository.Create(result);
            uow.Save();
        }

        public async Task DeleteBook(int id)
        {
            var result = await uow.BooksRepository.Get(id);
            await uow.BooksRepository.Delete(result.Id);
            uow.Save();
        }

        public async Task<List<BookDto>> GetAll()
        {
            return objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.GetAll());
        }

        public async Task<List<BookDto>> GetAll(Func<BookDto, bool> predicate)
        {
            var result = objectManager.Mapper.Map<Func<Book, bool>>(predicate);
            return objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.GetAll(result));
        }

        public async Task<BookDto> Get(int id)
        {
            return objectManager.Mapper.Map<BookDto>(await uow.ReadersRepository.Get(id));
        }

        public async Task<List<BookDto>> SearchBooksByAuthor(string author)
        {
            var result = objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.SearchBooksByAuthor(author));
            return result;
        }

        public async Task<List<BookDto>> SearchBooksByGenre(string genre)
        {
            var result = objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.SearchBooksByGenre(genre));
            return result;
        }

        public async Task<List<BookDto>> SearchBooksByName(string name)
        {
            var result = objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.SearchBooksByName(name));
            return result;
        }

        public async Task<List<BookDto>> SearchBooksByPublOffice(string office)
        {
            var result = objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.SearchBooksByPublOffice(office));
            return result;
        }

        public async Task<List<BookDto>> SearchBooksByPublDate(int year)
        {
            var result = objectManager.Mapper.Map<List<BookDto>>(await uow.BooksRepository.SearchBooksByPublDate(year));
            return result;
        }

        public async Task UpdateBook(BookDto book)
        {
            var result = objectManager.Mapper.Map<Book>(book);
            await uow.BooksRepository.Update(result);
            uow.Save();
        }
    }
}
