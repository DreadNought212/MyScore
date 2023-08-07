using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScore.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Score { get; set; }
        public int Host_team_id { get; set; }
        public int Guest_team_id { get; set; }
        public string Date { get; set; }
        public int League_id { get; set; }
        public int Stadium_id { get; set; }
    }
}


