using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Core.Common.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstSurname { get; set; }

        public string SecondSurname { get; set; }

        public string Area { get; set; }

        public DateTime BirthDate { get; set; }

        public double Salary { get; set; }
    }
}