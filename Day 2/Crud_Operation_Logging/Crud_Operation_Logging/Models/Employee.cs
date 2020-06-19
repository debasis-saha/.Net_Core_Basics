using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Operation_Logging.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        public decimal Salary { get; set; }

        public string AddressLine { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }
    }
}
