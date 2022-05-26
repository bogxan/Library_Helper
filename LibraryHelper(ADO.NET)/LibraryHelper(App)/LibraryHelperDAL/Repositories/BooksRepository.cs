using LibraryHelperDAL.EF;
using LibraryHelperDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperDAL.Repositories
{
    public class BooksRepository : BaseRepository<Book>
    {
        public BooksRepository(StoreContext context) : base(context) { }

        public async Task<List<Book>> SearchBooksByName(string name)
        {
            var result = await GetAll(p=>p.Name.Contains(name)==true);
            return result.ToList();
        }

        public async Task<List<Book>> SearchBooksByAuthor(string author)
        {
            var result = await GetAll(p => p.Authors.Contains(author) == true);
            return result.ToList();
        }

        public async Task<List<Book>> SearchBooksByGenre(string genre)
        {
            var result = await GetAll(p => p.Genre == genre);
            return result.ToList();
        }

        public async Task<List<Book>> SearchBooksByPublOffice(string office)
        {
            var result = await GetAll(p => p.PublishOffice == office);
            return result.ToList();
        }

        public async Task<List<Book>> SearchBooksByPublDate(int year)
        {
            var result = await GetAll(p => p.PublishDate == year);
            return result.ToList();
        }

        public override async Task Update(Book entity)
        {
            var updateBook = await Get(entity.Id);
            updateBook.Name = entity.Name;
            updateBook.Authors = entity.Authors;
            updateBook.Genre = entity.Genre;
            updateBook.CountPages = entity.CountPages;
            updateBook.IsLendedOut = entity.IsLendedOut;
            updateBook.PublishOffice = entity.PublishOffice;
            updateBook.PublishDate = entity.PublishDate;
            db.Entry(updateBook).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
