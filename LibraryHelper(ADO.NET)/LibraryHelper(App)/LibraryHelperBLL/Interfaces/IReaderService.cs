using LibraryHelperBLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperBLL.Interfaces
{
    public interface IReaderService
    {
        Task AddReader(ReaderDto reader);
        Task DeleteReader(int id);
        Task UpdateReader(ReaderDto book);
        Task<List<ReaderDto>> SearchReaderByNameSurname(string name, string surname);
        Task<List<ReaderDto>> SearchReaderByPhoneNumber(string number);
    }
}
