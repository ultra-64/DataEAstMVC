using DataEastMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using System.Web.UI.WebControls;
using static DataLibrary.BusinessLogic.GameProcessor;

namespace DataEastMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ByRelease()
        {
            ViewBag.Message = "Data East Arcade List By Release Date";

            var data = LoadByRelease();
            List<ArcadeList> games = new List<ArcadeList>();

            foreach (var row in data)
            {
                games.Add(new ArcadeList
                {
                    Title = row.Title,
                    Release_Date = row.Release_Date,
                    Hardware_Type = row.Hardware_Type,
                    Genre = row.Genre
                });
            }
            return View(games);
        }

        public ActionResult ByHardware()
        {
            ViewBag.Message = "Data East Arcade List By Hardware Type";


            var data = LoadByHardware();
            List<ArcadeList> games = new List<ArcadeList>();

            foreach (var row in data)
            {
                games.Add(new ArcadeList
                {
                    Title = row.Title,
                    Release_Date = row.Release_Date,
                    Hardware_Type = row.Hardware_Type,
                    Genre = row.Genre
                });
            }
            return View(games);
        }

        public ActionResult Arcade_List()
        {
            ViewBag.Message = "Data East Arcade List By Title";

            var data = LoadByTitle();
            List<ArcadeList> games = new List<ArcadeList>();

            foreach (var row in data)
            {
                games.Add(new ArcadeList
                {
                    Title = row.Title,
                    Release_Date = row.Release_Date,
                    Hardware_Type = row.Hardware_Type,
                    Genre = row.Genre
                });
            }
            return View(games);
        }
        public ActionResult ByGenre()
        {
            ViewBag.Message = "Data East Arcade List By Genre";

            var data = LoadByGenre();
            List<ArcadeList> games = new List<ArcadeList>();

            foreach (var row in data)
            {
                games.Add(new ArcadeList
                {
                    Title = row.Title,
                    Release_Date = row.Release_Date,
                    Hardware_Type = row.Hardware_Type,
                    Genre = row.Genre
                });
            }
            return View(games);
        }
    }
}