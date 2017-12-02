using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_1.DAL;
using Project_1.Models;

namespace Project_1.Controllers
{
    [Authorize]
    public class ProposalsController : Controller
    {
        private BabbittNelsonContext db = new BabbittNelsonContext();

        // GET: Proposals
        public ActionResult Index()
        {
            return View(db.Proposals.ToList());
        }

        // GET: Proposals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // GET: Proposals/Create
        public ActionResult Create()
        {
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName");

            return View();
        }

        // POST: Proposals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProposalID,ProjectName,ClientID,RequestByID,DateRequested,CreatedByID,DateCreated,ApproverID,ApprovedDate,CurrentStatus,SqFtCost,SqFootage,EngineeringFeePercent,EngineeringFeePerSqFt,FeeSqFt,FeePercentConstruction,ConstructionCost,GSN,TypicalDetails,FoundationPlans,FloorFraming,RoofFraming,WallPanelElevation,SheerWallPlans,FoundationDetails,FramingDetails,EstHoursPerSheet,DraftingHourlyRate,EngineeringHourlyRate,PlanCheckComments,ShopDrawingReview,ConstructionAdmin_RFI,SpecialInspections,SpecialInspectionsRate,FeeSheets,GSNHours,TypicalDetailsHours,FoundationPlansHours,FloorFramingHours,RoofFramingHours,WallPanelElevationHours,SheerWallPlansHours,FoundationDetailsHours,FramingDetailsHours,NumUnits,CostPerUnit,CommunityServiceArea,PricePerSqFt_CommunityServiceArea,CommunityServiceFees,RetainingWallsAndMiscFee,NoteOnMiscFees,FeeNumUnits,FeeAverage,NumOfFeesInCalc,EngineeringEst,DraftingEst,ContractAmount,EngineeringFee,DraftingFee")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Proposals.Add(proposal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", proposal.ClientID);

            return View(proposal);
        }

        // GET: Proposals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", proposal.ClientID);
            return View(proposal);
        }

        // POST: Proposals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProposalID,ProjectName,ClientID,RequestByID,DateRequested,CreatedByID,DateCreated,ApproverID,ApprovedDate,CurrentStatus,SqFtCost,SqFootage,EngineeringFeePercent,EngineeringFeePerSqFt,FeeSqFt,FeePercentConstruction,ConstructionCost,GSN,TypicalDetails,FoundationPlans,FloorFraming,RoofFraming,WallPanelElevation,SheerWallPlans,FoundationDetails,FramingDetails,EstHoursPerSheet,DraftingHourlyRate,EngineeringHourlyRate,PlanCheckComments,ShopDrawingReview,ConstructionAdmin_RFI,SpecialInspections,SpecialInspectionsRate,FeeSheets,GSNHours,TypicalDetailsHours,FoundationPlansHours,FloorFramingHours,RoofFramingHours,WallPanelElevationHours,SheerWallPlansHours,FoundationDetailsHours,FramingDetailsHours,NumUnits,CostPerUnit,CommunityServiceArea,PricePerSqFt_CommunityServiceArea,CommunityServiceFees,RetainingWallsAndMiscFee,NoteOnMiscFees,FeeNumUnits,FeeAverage,NumOfFeesInCalc,EngineeringEst,DraftingEst,ContractAmount,EngineeringFee,DraftingFee")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proposal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", proposal.ClientID);
            return View(proposal);
        }

        // GET: Proposals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // POST: Proposals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proposal proposal = db.Proposals.Find(id);
            db.Proposals.Remove(proposal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
