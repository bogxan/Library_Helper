using LibraryHelperBLL.DTO;
using LibraryHelperDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelperBLL.Interfaces
{
    public interface ILendBookService
    {
        Task AddLendBook(LendBookDto lendBook);
        Task DeleteLendBook(int id);
        Task UpdateLendBook(LendBookDto lendBook);
        Task ReturnBook(int id);
    }
}
