using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public enum Status { Request, WaitingApproval, Approved, Accepted };

    [Table("Proposal")]
    public class Proposal
    {
        
        [Key]
        public int ProposalID { get; set; }
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        //public static int MinFeeOneTime { get; set; }
        //public static int MinFeeRegular { get; set; }

        //% of fee that is for engineering and for drafting, used for calculations
        //public static double DraftingFeePortion { get; set; }
        //public static double EngineeringFeePortion { get; set; }

        //admin fields
        public int RequestByID { get; set; }
        [DisplayName("Date Requested")]
        public DateTime DateRequested { get; set; }
        [DisplayName("Created By ID")]
        public int CreatedByID { get; set; }
        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }
        [DisplayName("Approver ID")]
        public int ApproverID { get; set; }
        [DisplayName("Date Approved")]
        public DateTime ApprovedDate { get; set; }
        [DisplayName("Current Status")]
        public Status CurrentStatus { get; set; }

        //Client and ProjectName Inherited From parent

        //Fields for calculation of fee
        //Percent of Construction Method and Fee per Sq. Foot
        public double SqFtCost { get; set; }
        public int SqFootage { get; set; }
        public double EngineeringFeePercent { get; set; }
        public double EngineeringFeePerSqFt { get; set; }
        public double FeeSqFt { get; set; }                           //TOTAL EngineeringFeePerSqFt * SqFootage 
        public double FeePercentConstruction { get; set; }          //TOTAL ConstructionCost * EngineeringFeePercent
        public double ConstructionCost { get; set;  }               //CLACULATED SqFtCost * SqFootage

        //Fee based on sheets
        public int GSN { get; set; }
        public int TypicalDetails { get; set; }
        public int FoundationPlans { get; set; }
        public int FloorFraming { get; set; }
        public int RoofFraming { get; set; }
        public int WallPanelElevation { get; set; }
        public int SheerWallPlans { get; set; }
        public int FoundationDetails { get; set; }
        public int FramingDetails { get; set; }

        public int EstHoursPerSheet { get; set; }
        //public int DraftingHours { get; set; }                  //CALCULATED TotalSheets * EstHoursPerSheet
       // public int EngineeringHours { get; set; }               // CALCULATED 2/3 * DraftingHours + PlanCheckComments + ShopDrawingReview + ConstructionAdmin_RFI
       public double DraftingHourlyRate { get; set; }
        public double EngineeringHourlyRate { get; set; } 
        //public double DraftingEstimatedFee {get;set;}         // CALCULATED DraftingHours * DraftingHourlyRate
         //public double EngineeringEstimatedFee {get;set;}          //CALCULATED EngineeringHours * EnginerringHourlyRate

        public double PlanCheckComments { get; set; }
        public double ShopDrawingReview { get; set; }
        public double ConstructionAdmin_RFI { get; set; }

        public int SpecialInspections { get; set; }                  //hour count
        public double SpecialInspectionsRate { get; set; }

        public double FeeSheets { get; set; }                //TOTAL  DraftingEstimatedFee + EngineeringEstimatedFee

        //Fee on Man hours
        public int GSNHours { get; set; }                         
        public int TypicalDetailsHours { get; set; }
        public int FoundationPlansHours { get; set; }
        public int FloorFramingHours { get; set; }
        public int RoofFramingHours { get; set; }
        public int WallPanelElevationHours { get; set; }
        public int SheerWallPlansHours { get; set; }
        public int FoundationDetailsHours { get; set; }
        public int FramingDetailsHours { get; set; }

        //Fee based on number of Units
        public int NumUnits { get; set; }
        public double CostPerUnit { get; set; }
        public int CommunityServiceArea { get; set; }
        public double PricePerSqFt_CommunityServiceArea { get; set; }
        public double CommunityServiceFees { get; set; }
        public double RetainingWallsAndMiscFee { get; set; }
        public string NoteOnMiscFees { get; set; }
        public double FeeNumUnits { get; set; }


        //SummaryFields
        [DisplayName("Estimated Total Fee")]
        public double FeeAverage { get; set; }
        public int NumOfFeesInCalc { get; set; }
        public double EngineeringEst { get; set; }
        public double DraftingEst { get; set; }


        [DisplayName("Contract Amount")]
        public double ContractAmount { get; set; }
        [DisplayName("Engineering Fee")]
        public double EngineeringFee { get; set; }
        [DisplayName("Drafting Fee")]
        public double DraftingFee { get; set; }



    }

    }
