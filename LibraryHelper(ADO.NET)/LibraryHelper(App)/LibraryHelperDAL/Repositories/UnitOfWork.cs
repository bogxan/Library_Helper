using LibraryHelperDAL.EF;
using LibraryHelperDAL.Interfaces;
using LibraryHelperDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperDAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private StoreContext db;
        private BooksRepository _BooksRepository;
        private LendBooksRepository _LendBooksRepository;
        private ReadersRepository _ReadersRepository;
        public BooksRepository BooksRepository => 
            _BooksRepository??(_BooksRepository=new BooksRepository(db));
        public LendBooksRepository LendBooksRepository =>
            _LendBooksRepository ?? (_LendBooksRepository = new LendBooksRepository(db));
        public ReadersRepository ReadersRepository =>
            _ReadersRepository ?? (_ReadersRepository = new ReadersRepository(db));
        public UnitOfWork(string connectionstring)
        {
            db = new StoreContext(connectionstring);
        }
        public void Save()
        {
            db.SaveChanges();
        }

        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }
    }
}
