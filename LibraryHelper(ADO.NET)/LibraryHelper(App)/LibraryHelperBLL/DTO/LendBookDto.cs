using LibraryHelperDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperBLL.DTO
{
    public class LendBookDto
    {
        public int Id { get; set; }
        public DateTime DateLendingFrom { get; set; }
        public DateTime DateLendingTo { get; set; }
        public ReaderDto Reader { get; set; }
        public int ReaderId { get; set; }
        public BookDto Book { get; set; }
        public int BookId { get; set; }

        public override string ToString()
        {
            return $"{Book.Id}. {Book.Name} {DateLendingTo}";
        }
    }
}
