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
    public class ReadersRepository : BaseRepository<Reader>
    {
        public ReadersRepository(StoreContext context) : base(context) { }

        public async Task<IEnumerable<Reader>> SearchReadersByNameSurname(string name, string surname)
        {
            var result = await GetAll(p => p.FirstName == name && p.LastName == surname);
            return result.ToList();
        }

        public async Task<IEnumerable<Reader>> SearchReadersByPhoneNumber(string number)
        {
            var result = await GetAll(p => p.PhoneNumber == number);
            return result.ToList();
        }

        public override async Task Update(Reader entity)
        {
            var updateReader = await Get(entity.Id);
            updateReader.FirstName = entity.FirstName;
            updateReader.LastName = entity.LastName;
            updateReader.PhoneNumber = entity.PhoneNumber;
            updateReader.LendBooks = entity.LendBooks;
            db.Entry(updateReader).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
