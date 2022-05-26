using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperDAL.Entities
{
    public class LendBook: BaseEntity
    {
        public DateTime DateLendingFrom { get; set; }
        public DateTime DateLendingTo { get; set; }
        public Reader Reader { get; set; }
        public int ReaderId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }

        public override string ToString()
        {
            return $"{Book.Id}. '{Book.Name}'; {DateLendingTo}";
        }
    }
}
