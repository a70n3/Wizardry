using System;

namespace Wizardry.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string Street { get; set; }
        public string Municipality { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
