using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyScore.Models;
using MyScore.ViewModels;

namespace MyScore.Controllers
{
    public class EditController : Controller
    {
        private Context db;
        public EditController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MatchSelect()
        {
            ViewBag.PageTitle = "Macth Select";
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
        public async Task<IActionResult> MatchSelect(int? id)
        {
            if (id != null)
            {
                Match match = db.Matches.Where(p => p.Id == id).First();
                db.Matches.Remove(match);
                await db.SaveChangesAsync();
                return RedirectToAction("MatchSelect");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult ClubSelect()
        {
            ViewBag.PageTitle = "Club Select";
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
        public async Task<IActionResult> ClubSelect(int? id)
        {
            if (id != null)
            {
                Club club = db.Clubs.Where(p => p.Id == id).First();
                club.Delete = 1;
                db.Clubs.Update(club);
                await db.SaveChangesAsync();
                return RedirectToAction("ClubSelect");
            }
            return NotFound();   
        }
        [HttpGet]
        public IActionResult LeagueSelect()
        {
            ViewBag.PageTitle = "League Select";
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
        public async Task<IActionResult> LeagueSelect(int? id)
        {
            if (id != null)
            {
                League league = db.Leagues.Where(p => p.Id == id).First();
                league.Delete = 1;
                db.Leagues.Update(league);
                await db.SaveChangesAsync();
                return RedirectToAction("LeagueSelect");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult StadiumSelect()
        {
            ViewBag.PageTitle = "Stadium Select";
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
        public async Task<IActionResult> StadiumSelect(int? id)
        {
            if (id != null)
            {
                Stadium stadium = db.Stadiums.Where(p => p.Id == id).First();
                stadium.Delete = 1;
                db.Stadiums.Update(stadium);
                await db.SaveChangesAsync();
                return RedirectToAction("StadiumSelect");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult ClubEdit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ClubId = id;
            var club = db.Clubs.Where(x => x.Id == id).First();
            ViewBag.ClubName = club.Name;
            ViewBag.ClubHomeLeagueId = club.Home_league_id;
            ViewBag.PageTitle = "Club Edit";
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
        public async Task<IActionResult> ClubEdit(Club club)
        {
            db.Clubs.Update(club);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult MatchEdit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.MatchId = id;
            var match = db.Matches.Where(x => x.Id == id).First();
            ViewBag.LeagueId = match.League_id;
            ViewBag.HostTeamId = match.Host_team_id;
            ViewBag.GuestTeamId = match.Guest_team_id;
            ViewBag.Score = match.Score;
            ViewBag.Date = match.Date;
            ViewBag.StadiumId = match.Stadium_id;
            ViewBag.PageTitle = "Match Edit";
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
        public async Task<IActionResult> MatchEdit(Match match)
        {
            db.Matches.Update(match);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult LeagueEdit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.LeagueId = id;
            var league = db.Leagues.Where(x => x.Id == id).First();
            ViewBag.Name = league.Name;
            ViewBag.CountryId = league.Country_id;
            ViewBag.PageTitle = "League Edit";
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
        public async Task<IActionResult> LeagueEdit(League league)
        {
            db.Leagues.Update(league);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult StadiumEdit(int? id)
        {
            if (id == null) return RedirectToAction("StadiumSelect");
            ViewBag.StadiumId = id;
            var stadium = db.Stadiums.Where(x => x.Id == id).First();
            var club = db.Clubs.Where(x => x.Id == stadium.Club_id).First();
            ViewBag.StadiumName = stadium.Name;
            ViewBag.ClubId = stadium.Club_id;
            ViewBag.LeagueId = club.Home_league_id;
            ViewBag.PageTitle = "Stadium Edit";
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
        public async Task<IActionResult> StadiumEdit(Stadium stadium)
        {
            db.Stadiums.Update(stadium);
            await db.SaveChangesAsync();
            return RedirectToAction("StadiumSelect");
        }
    }
}