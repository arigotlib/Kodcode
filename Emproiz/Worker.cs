using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Emproiz
{
    public class Worker
    {
  
        public int Code {  get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FulName { get { return FirstName + " " + LastName; } }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public string Status { get; set; }
        public string HomePhone { get; set; }
        public string Cellphone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BildingNumber { get; set; }
        public string HomeNumber { get; set; }
        public string HomeAdress { get { return City + " " + Street + " " + HomeNumber; } }

        public Worker(int code, string id, string firstName, string lastName, DateTime birthDay, bool isMale, string status, string homePhone, string cellphone, string city, string street, string bildingNumber, string homeNumber)
        {
            Code = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthDay;
            IsMale = isMale;
            Status = status;
            HomePhone = homePhone;
            Cellphone = cellphone;
            City = city;
            Street = street;
            BildingNumber = bildingNumber;
            HomeNumber = homeNumber;     


        }
    }
}
