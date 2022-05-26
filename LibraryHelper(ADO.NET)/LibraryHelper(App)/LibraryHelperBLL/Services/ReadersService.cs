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
    public class ReadersService : IReaderService
    {
        private IUnitOfWork uow;
        private AutoMapper.ObjectMapper objectManager = AutoMapper.ObjectMapper.Instance;
        public ReadersService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public async Task AddReader(ReaderDto reader)
        {
            var result = objectManager.Mapper.Map<Reader>(reader);
            await uow.ReadersRepository.Create(result);
            uow.Save();
        }

        public async Task DeleteReader(int id)
        {
            var result = await uow.ReadersRepository.Get(id);
            await uow.ReadersRepository.Delete(result.Id);
            uow.Save();
        }

        public async Task<List<ReaderDto>> GetAll()
        {
            return objectManager.Mapper.Map<List<ReaderDto>>(await uow.ReadersRepository.GetAll());
        }

        public async Task<List<ReaderDto>> GetAll(Func<ReaderDto, bool> predicate)
        {
            var result  = objectManager.Mapper.Map<Func<Reader, bool>>(predicate);
            return objectManager.Mapper.Map<List<ReaderDto>>(await uow.ReadersRepository.GetAll(result));
        }

        public async Task<ReaderDto> Get(int id)
        {
            return objectManager.Mapper.Map<ReaderDto>(await uow.ReadersRepository.Get(id));
        }

        public async Task<List<ReaderDto>> SearchReaderByNameSurname(string name, string surname)
        {
            var result = objectManager.Mapper.Map<List<ReaderDto>>(await uow.ReadersRepository.SearchReadersByNameSurname(name, surname)).ToList(); ;
            return result;
        }

        public async Task<List<ReaderDto>> SearchReaderByPhoneNumber(string number)
        {
            var result = objectManager.Mapper.Map<List<ReaderDto>>(await uow.ReadersRepository.SearchReadersByPhoneNumber(number)).ToList(); ;
            return result;
        }

        public async Task UpdateReader(ReaderDto reader)
        {
            var result = objectManager.Mapper.Map<Reader>(reader);
            await uow.ReadersRepository.Update(result);
            uow.Save();
        }
    }
}
