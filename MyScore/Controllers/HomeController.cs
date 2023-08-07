using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyScore.Models;
using MyScore.ViewModels;

namespace MyScore.Controllers
{
    public class HomeController : Controller
    {
        Context db;
        public HomeController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Home";
            var model = new MatchClubLeagueModel()
            {
                Clubs = db.Clubs.ToList(),
                Matches = db.Matches.ToList(),
                Leagues = db.Leagues.ToList(),
                Countries = db.Countries.ToList(),
                PersonRoles = db.PersonRoles.ToList(),
                Persons = db.Persons.ToList(),
                Stadiums = db.Stadiums.ToList()
            };
            return View(model);
        }
    }
}
