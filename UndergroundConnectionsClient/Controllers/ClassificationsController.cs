using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UndergroundConnectionsClient.Models;

namespace UndergroundConnectionsClient.Controllers
{
  public class ClassificationsController : Controller
  {
    public IActionResult Index()
    {
      var allClassifications = Classification.GetClassifications();
      return View(allClassifications);
    }

    [HttpPost]
    public IActionResult Index(Classification classification)
    {
      Classification.Post(classification);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var classification = Classification.GetDetails(id);
      return View(classification);
    }

    public IActionResult Edit(int id)
    {
      var classification = Classification.GetDetails(id);
      return View(classification);
    }

    [HttpPost]
    public IActionResult Details(int id, Classification classification)
    {
      classification.ClassificationId = id;
      Classification.Put(classification);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Classification.Delete(id);
      return RedirectToAction("Index");
    }
  }
} 