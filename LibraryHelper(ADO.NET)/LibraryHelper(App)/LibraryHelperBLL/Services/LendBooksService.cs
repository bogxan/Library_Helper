using LibraryHelperBLL.DTO;
using LibraryHelperBLL.Interfaces;
using LibraryHelperDAL.Entities;
using LibraryHelperDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperBLL.Services
{
    public class LendBooksService : ILendBookService
    {
        private IUnitOfWork uow;
        private AutoMapper.ObjectMapper objectManager = AutoMapper.ObjectMapper.Instance;
        public LendBooksService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public async Task AddLendBook(LendBookDto lendBook)
        {
            var result = objectManager.Mapper.Map<LendBook>(lendBook);
            await uow.LendBooksRepository.Create(result);
            uow.Save();
        }

        public async Task DeleteLendBook(int id)
        {
            var result = await uow.LendBooksRepository.Get(id);
            await uow.LendBooksRepository.Delete(result.Id);
            uow.Save();
        }

        public async Task UpdateLendBook(LendBookDto lendBook)
        {
            var result = objectManager.Mapper.Map<LendBook>(lendBook);
            await uow.LendBooksRepository.Update(result);
            uow.Save();
        }

        public async Task<List<LendBookDto>> GetAll()
        {
            return objectManager.Mapper.Map<List<LendBookDto>>(await uow.LendBooksRepository.GetAll());
        }

        public async Task<List<LendBookDto>> GetAll(Func<LendBookDto, bool> predicate)
        {
            var result = objectManager.Mapper.Map<Func<LendBook, bool>>(predicate);
            return objectManager.Mapper.Map<List<LendBookDto>>(await uow.LendBooksRepository.GetAll(result));
        }

        public async Task<List<LendBookDto>> GetBooksMustBeReturnedToday()
        {
            return objectManager.Mapper.Map<List<LendBookDto>>(await uow.LendBooksRepository.GetAll(p=>p.DateLendingTo.Day==DateTime.Now.Day));
        }

        public async Task ReturnBook(int id)
        {
            var book = uow.LendBooksRepository.Get(id);
            await uow.LendBooksRepository.Delete(book.Id);
        }
    }
}
