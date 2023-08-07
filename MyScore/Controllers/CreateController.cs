using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyScore.Models;
using MyScore.ViewModels;

namespace MyScore.Controllers
{
    public class CreateController : Controller
    {
        private Context db;
        public CreateController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Create";
            return View();
        }
        [HttpGet]
        public IActionResult Match()
        {
            ViewBag.PageTitle = "Match create";
            var model = new MatchClubLeagueModel()
            {
                Clubs = db.Clubs.ToList(),
                Matches = db.Matches.ToList(),
                Leagues = db.Leagues.ToList(),
                Countries = db.Countries.ToList(),
                Stadiums = db.Stadiums.ToList()

            };
            return View(model);

        }
        [HttpPost]
        public string Match(Match match)
        {
            db.Matches.Add(match);
            db.SaveChanges();
            return null;
        }
        [HttpGet]
        public IActionResult Club()
        {
            ViewBag.PageTitle = "Club create";
            var model = new MatchClubLeagueModel()
            {
                Clubs = db.Clubs.ToList(),
                Matches = db.Matches.ToList(),
                Leagues = db.Leagues.ToList(),
                Countries = db.Countries.ToList()
            };
            return View(model);

        }
        [HttpPost]
        public string Club(Club club)
        {
            db.Clubs.Add(club);
            db.SaveChanges();
            return null;
        }
        [HttpGet]
        public IActionResult League()
        {
            ViewBag.PageTitle = "League create";
            var model = new MatchClubLeagueModel()
            {
                Clubs = db.Clubs.ToList(),
                Matches = db.Matches.ToList(),
                Leagues = db.Leagues.ToList(),
                Countries = db.Countries.ToList()
            };
            return View(model);

        }
        [HttpPost]
        public string League(League league)
        {
            db.Leagues.Add(league);
            db.SaveChanges();
            return null;
        }
        [HttpGet]
        public IActionResult Stadium()
        {
            ViewBag.PageTitle = "Stadium create";
            var model = new MatchClubLeagueModel()
            {
                Clubs = db.Clubs.ToList(),
                Matches = db.Matches.ToList(),
                Leagues = db.Leagues.ToList(),
                Countries = db.Countries.ToList(),
                Stadiums = db.Stadiums.ToList()
            };
            return View(model);

        }
        [HttpPost]
        public string Stadium(Stadium stadium)
        {
            db.Stadiums.Add(stadium);
            db.SaveChanges();
            return null;
        }
    }
}