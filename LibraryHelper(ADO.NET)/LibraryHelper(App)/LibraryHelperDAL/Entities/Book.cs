using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperDAL.Entities
{
    public class Book: BaseEntity
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public int CountPages { get; set; }
        public string Genre { get; set; }
        public bool IsLendedOut { get; set; }
        public string PublishOffice { get; set; }
        public int PublishDate { get; set; }
        public LendBook LendBook { get; set; }

        public override string ToString()
        {
            if (IsLendedOut == true)
            {
                return $"{Id}. '{Name}'; Status: lended";
            }
            else
            {
                return $"{Id}. '{Name}'; Status: not lended";
            }
        }
    }
}
