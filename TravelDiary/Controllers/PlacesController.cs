using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;

namespace TravelDiary.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpPost("/places")]
        public ActionResult Create(string cityName)
        {
            Place newPlace = new Place(cityName);
            return RedirectToAction("Index");
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places/delete")]
        public ActionResult ClearAll()
        {
            Place.ClearAll();
            return RedirectToAction("Index");
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int id)
        {
            Place foundPlace = Place.Find(id);
            return View(foundPlace);
        }
    }
}