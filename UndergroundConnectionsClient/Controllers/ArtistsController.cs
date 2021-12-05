using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UndergroundConnectionsClient.Models;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
>>>>>>> eb367d86c5412eca5518f2cba807d8b5a330567f

namespace UndergroundConnectionsClient.Controllers
{
  public class ArtistsController : Controller
  {
    public IActionResult Index()
    {
      var allArtists = Artist.GetArtists();
      return View(allArtists);
    }
<<<<<<< HEAD

    [HttpPost]
    public IActionResult Index(Artist artist)
    {
      Artist.Post(artist);
      return RedirectToAction("Index");
=======
    public IActionResult Create()
    {
      var allClassifications = Classification.GetClassifications();
      ViewBag.ClassificationId = new SelectList(allClassifications,"ClassificationId","ClassificationName");
      return View();
    }

    [HttpPost]
    public IActionResult Create( Artist artist, int ClassificationId)
    {
      Artist.Post(artist);
      return RedirectToAction("Index","Classifications");
>>>>>>> eb367d86c5412eca5518f2cba807d8b5a330567f
    }

    public IActionResult Details(int id)
    {
      var artist = Artist.GetDetails(id);
      return View(artist);
    }

    public IActionResult Edit(int id)
    {
      var artist = Artist.GetDetails(id);
      return View(artist);
    }

    [HttpPost]
    public IActionResult Details(int id, Artist artist)
    {
      artist.ArtistId = id;
      Artist.Put(artist);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Artist.Delete(id);
      return RedirectToAction("Index");
    }
  }
}