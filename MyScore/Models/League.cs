using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScore.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Country_id { get; set; }
        public int Delete { get; set; }
    }
}
