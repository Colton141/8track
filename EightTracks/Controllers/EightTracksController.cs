using Microsoft.AspNetCore.Mvc;
using EightTracks.Models;
using System.Collections.Generic;

namespace EightTracks.Controllers
{
  public class EightTracksController : Controller
  {
    [HttpGet("/eighttracks")]
    public ActionResult Index()
    {
      List<EightTrackTape> allTapes = EightTrackTape.GetAll();
      return View(allTapes);
    }
    [HttpGet("/eighttracks/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/eighttracks")]
    public ActionResult Create(string albumname, string artist, string year)
    {
      EightTrackTape myEightTrackTape = new EightTrackTape(albumname, artist, year);
      return RedirectToAction("Index");
    }
    [HttpPost("/eighttracks/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
    [HttpGet("/eighttracks/{id}")]
    public ActionResult Show(int id)
    {
      EightTrackTape eighttracktape = EightTrackTape.Find(id);
      return View(place);
    }
    [HttpPost("/eighttracks/{id}")]
    public ActionResult Delete(int id)
    {
      EightTrackTape.DeleteEightTrackTape(id);
      return View();
    }
    [HttpPost("/eighttracks/search/year")]
    public ActionResult Search(string year)
    {
      List<EightTrackTape> results = EightTrackTape.FindAll(year);
      return View(results);
    }
    [HttpPost("/eighttracks/search/albumname")]
    public ActionResult Search(string albumname)
    {
      List<EightTrackTape> results = EightTrackTape.FindAll(albumname);
      return View(results);
    }
    [HttpPost("/eighttracks/search/artist")]
    public ActionResult Search(string artist)
    {
      List<EightTrackTape> results = EightTrackTape.FindAll(artist);
      return View(results);
    }
    [HttpGet("/eighttracks/searchform")]
    public ActionResult SearchForm()
    {
      return View();
    }
  }
}