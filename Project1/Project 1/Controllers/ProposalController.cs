﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    class Client
    {
        int clientID;
        string ClientName;
        string ContactName;
        string ContactPhone;
        string AddressLine1;
        string AddressLine2;
        string City;
        string State;
        string email;
    }

    class Proposal
    {
        string ProjectName;
        Client Client;
    }

    class Proposal_details : Proposal
    {
        static int MinFeeOneTime;
        static int MinFeeRegular;

        //% of fee that is for engineering and for drafting, used for calculations
        static double DraftingFeePortion;
        static double EngineeringFeePortion;

        //admin fields
        int RequestByID;
        DateTime DateRequested;
        int CreatedByID;
        DateTime DateCreated;
        int ApproverID;
        DateTime ApprovedOn;
        int ProposalID;

        //Client and ProjectName Inherited From parent

        //Fields for calculation of fee
        //Percent of Construction Method and Fee per Sq. Foot
        double SqFtCost;
        int SqFootage;
        double EngineeringFeePercent;
        double EngineeringFeePerSqFt;
        double FeeSqFt;
        double FeePercentConstruction;

        //Fee based on sheets
        int GSN;
        int TypicalDetails;
        int FoundationPlans;
        int FloorFraming;
        int RoofFraming;
        int WallPanelElevation;
        int SheerWallPlans;
        int FoundationDetails;
        int FramingDetails;

        int EstHoursPerSheet;
        int DraftingHours;
        int EngineeringHours;

        int PlanCheckComments;
        int ShopDrawingReview;
        int ConstructionAdmin_RFI;

        int SpecialInspections;
        double SpecialInspectionsRate;

        double FeeSheets;

        //Fee on Man hours
        int GSNHours;
        int TypicalDetailsHours;
        int FoundationPlansHours;
        int FloorFramingHours;
        int RoofFramingHours;
        int WallPanelElevationHours;
        int SheerWallPlansHours;
        int FoundationDetailsHours;
        int FramingDetailsHours;

        //Fee based on number of Units
        int NumUnits;
        double CostPerUnit;
        int CommunityServiceArea;
        double PricePerSqFt_CommunityServiceArea;
        double CommunityServiceFees;
        double RetainingWallsAndMiscFee;
        string NoteOnMiscFees;
        double FeeNumUnits;


        //SummaryFields
        double FeeAverage;
        int NumOfFeesInCalc;
        double EngineeringEst;
        double DraftingEst;

        double ContractAmount;
        double EngineeringFee;
        double DraftingFee;



    }
    class Proposal_Request : Proposal
    {
        int RequestByID;
        DateTime DateRequested;
        string RequestData;
    }

    public class ProposalController : Controller
    {
        
        public ActionResult NewRequest()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult All()
        {
            return View();
        }

        public ActionResult Proposal(int ProposalID)
        {
            return View();
        }
    }
}