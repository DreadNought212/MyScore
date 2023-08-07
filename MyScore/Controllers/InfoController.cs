using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyScore.Models;
using MyScore.ViewModels;

namespace MyScore.Controllers
{
    public class InfoController : Controller
    {
        private Context db;
        public InfoController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Info";
            return View();
        }
        [HttpGet]
        public IActionResult MatchInfo(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.MatchId = id;
            var match = db.Matches.Where(x => x.Id == id).First();
            ViewBag.LeagueId = match.League_id;
            ViewBag.HostTeamId = match.Host_team_id;
            ViewBag.GuestTeamId = match.Guest_team_id;
            ViewBag.Score = match.Score;
            ViewBag.Date = match.Date;
            ViewBag.HostTeamName = db.Clubs.Where(x => x.Id == match.Host_team_id).First().Name;
            ViewBag.GuestTeamName = db.Clubs.Where(x => x.Id == match.Guest_team_id).First().Name;
            ViewBag.PageTitle = ViewBag.HostTeamName + "-" + ViewBag.GuestTeamName;
            ViewBag.StadiumId = match.Stadium_id;
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
        [HttpGet]
        public IActionResult ClubInfo(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ClubId = id;
            var club = db.Clubs.Where(x => x.Id == id).First();
            ViewBag.LeagueId = club.Home_league_id;
            ViewBag.ClubName = club.Name;
            ViewBag.PageTitle = club.Name;
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
        public IActionResult LeagueInfo(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var league = db.Leagues.Where(x => x.Id == id).First();
            ViewBag.LeagueId = league.Id;
            ViewBag.LeagueName = league.Name;
            ViewBag.PageTitle = league.Name;
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
    }
}