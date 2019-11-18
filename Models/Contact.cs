using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMvcApplication.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public DateTime BirthDate { get; set; }
        public long MobileNo { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }


    }
}