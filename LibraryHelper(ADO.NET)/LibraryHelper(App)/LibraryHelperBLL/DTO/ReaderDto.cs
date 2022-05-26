using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperBLL.DTO
{
    public class ReaderDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<LendBookDto> LendBooks { get; set; }
        public override string ToString()
        {
            return $"{Id}. {LastName} {FirstName}; {PhoneNumber}";
        }
    }
}
