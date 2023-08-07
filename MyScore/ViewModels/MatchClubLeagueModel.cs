using MyScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScore.ViewModels
{
    public class MatchClubLeagueModel
    {
        public IEnumerable <Match> Matches { get; set; }
        public IEnumerable <League> Leagues { get; set; }
        public IEnumerable <Club> Clubs { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Person> Persons { get; set; }
        public IEnumerable<PersonRole> PersonRoles { get; set; }
        public IEnumerable<Stadium> Stadiums { get; set; }
    }
}
