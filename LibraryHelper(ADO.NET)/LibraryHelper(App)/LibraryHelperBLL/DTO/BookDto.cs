using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperBLL.DTO
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Authors { get; set; }
        public int CountPages { get; set; }
        public string Genre { get; set; }
        public bool IsLendedOut { get; set; }
        public string PublishOffice { get; set; }
        public int PublishDate { get; set; }
        public LendBookDto LendBook { get; set; }

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
