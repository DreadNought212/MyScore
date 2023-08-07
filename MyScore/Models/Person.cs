using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScore.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public int Country_id { get; set; }
        public int Club_id { get; set; }
        public int Role_id { get; set; }
    }
}
