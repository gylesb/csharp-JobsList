using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobsList.Models;

namespace JobsList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/jobs/list")]
    public ActionResult JobsList()
    {
      List<string> allJobs = Job.GetAll();
        return View(allJobs);
    }

    [HttpPost("/jobs/create")]
    public ActionResult CreateJob()
    {
      Job newJob = new Job (Request.Form["jobTitle"], Request.Form["jobDescription"], Request.Form["jobDate"]);
      newJob.Save();
      return View(newJob);
    }

    [HttpPost("/jobs/list/clear")]
    public ActionResult JobsListClear()
    {
      Job.ClearAll();
      return View();
    }
  }
}
