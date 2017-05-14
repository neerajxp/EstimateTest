using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using EstimateCreator.Models;

namespace EstimateCreator.Controllers
{
    public class CreateEstimatorController : Controller
    {
        // GET: CreateEstimator
       
        public ActionResult CreateEstimate(EstimateCreatorViewModel model)
        {
            EstimateHeader estimateHeader = new EstimateHeader();
            EstimatePublication estimatePublication = new EstimatePublication();
            EstimateEdition estimateEdition = new EstimateEdition();
            EstimateCreatorViewModel estimateCreator = new EstimateCreatorViewModel();
            estimateCreator.EstimateHeader = estimateHeader;
            estimateCreator.EstimatePublication = estimatePublication;
            estimateCreator.EstimateEdition = estimateEdition;
            EstimatorDbContext db = new EstimatorDbContext();
            ViewBag.Client = new SelectList(db.ClientMasters, "ClientID", "Client_Name");
            ViewBag.Brand = new SelectList(db.BrandMasters, "BrandID","Brand_Name");
            return View(estimateCreator);
        }
    }
}