using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShippingCompany.Models;

namespace ShippingCompany.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> listOfParcels = Parcel.GetAll();
      return View(listOfParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(double length, double width, double height, double weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}