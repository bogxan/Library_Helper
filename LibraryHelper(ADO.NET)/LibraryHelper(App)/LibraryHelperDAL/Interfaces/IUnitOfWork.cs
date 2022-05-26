using LibraryHelperDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperDAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        public BooksRepository BooksRepository { get; }
        public LendBooksRepository LendBooksRepository { get;  }
        public ReadersRepository ReadersRepository { get; }
        void Save();
    }
}
