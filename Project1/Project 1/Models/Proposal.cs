using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1.Models
{

    [Table("Proposal")]
    public class Proposal
    {
        
        [Key]
         public int ProposalID { get; set; }
         public string ProjectName { get; set; }
        public int ClientID { get; set; }

        public static int MinFeeOneTime { get; set; }
        public static int MinFeeRegular { get; set; }

        //% of fee that is for engineering and for drafting, used for calculations
        public static double DraftingFeePortion { get; set; }
        public static double EngineeringFeePortion { get; set; }

        //admin fields
        public int RequestByID { get; set; }
        public DateTime DateRequested { get; set; }
        public int CreatedByID { get; set; }
        public DateTime DateCreated { get; set; }
        public int ApproverID { get; set; }
        public DateTime ApprovedOn { get; set; }


        public enum Status { Request, WaitingApproval, Approved, Accepted };
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
         
        public double PlanCheckComments { get; set; }
        public double ShopDrawingReview { get; set; }
        public double ConstructionAdmin_RFI { get; set; }

        public int SpecialInspections { get; set; }
        public double SpecialInspectionsRate { get; set; }

        public double FeeSheets { get; set; }                //TOTAL  SUM(

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
        public double FeeAverage { get; set; }
        public int NumOfFeesInCalc { get; set; }
        public double EngineeringEst { get; set; }
        public double DraftingEst { get; set; }

        public double ContractAmount { get; set; }
        public double EngineeringFee { get; set; }
        public double DraftingFee { get; set; }



    }

    }
