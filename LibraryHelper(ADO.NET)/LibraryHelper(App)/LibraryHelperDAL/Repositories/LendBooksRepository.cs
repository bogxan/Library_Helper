using LibraryHelperDAL.EF;
using LibraryHelperDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperDAL.Repositories
{
    public class LendBooksRepository : BaseRepository<LendBook>
    {
        public LendBooksRepository(StoreContext context): base(context) { }
        public override async Task Update(LendBook entity)
        {
            var updateBook = await Get(entity.Id);
            updateBook.Reader = entity.Reader;
            updateBook.ReaderId = entity.ReaderId;
            updateBook.DateLendingFrom = entity.DateLendingFrom;
            updateBook.DateLendingTo = entity.DateLendingTo;
            updateBook.Book = entity.Book;
            updateBook.BookId = entity.BookId;
            db.Entry(updateBook).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
