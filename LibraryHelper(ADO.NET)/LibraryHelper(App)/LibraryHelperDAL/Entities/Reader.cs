using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryHelperDAL.Entities
{
    public class Reader: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<LendBook> LendBooks { get; set; }
        public override string ToString()
        {
            return $"{Id}. {LastName} {FirstName}; {PhoneNumber}";
        }
    }
}
