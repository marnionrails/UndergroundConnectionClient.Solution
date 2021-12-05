using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UndergroundConnectionsClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace UndergroundConnectionsClient.Controllers
{
  public class ArtistsController : Controller
  {
    public IActionResult Index()
    {
      var allArtists = Artist.GetArtists();
      return View(allArtists);
    }
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