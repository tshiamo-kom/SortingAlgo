using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
{
    internal class Employee
    {
        public int departId { get; set; }
        public string surname { get; set; }

        public Employee(string departID, string surname)
        {
            departID = departID;
            surname = surname;
        }

        public override string? ToString()
        {
            return $"{departId} {surname}";
        }
    }
}
