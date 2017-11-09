using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Client")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        //public static int MinFeeOneTime { get; set; }
        //public static int MinFeeRegular { get; set; }

        //% of fee that is for engineering and for drafting, used for calculations
        //public static double DraftingFeePortion { get; set; }
        //public static double EngineeringFeePortion { get; set; }

        //admin fields
        public int? RequestByID { get; set; }
        [DisplayName("Date Requested")]
        public DateTime? DateRequested { get; set; }
        [DisplayName("Created By ID")]
        public int? CreatedByID { get; set; }
        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }
        [DisplayName("Approver ID")]
        public int? ApproverID { get; set; }
        [DisplayName("Date Approved")]
        public DateTime? ApprovedDate { get; set; }
        [DisplayName("Current Status")]
        public string CurrentStatus { get; set; }

        //Client and ProjectName Inherited From parent

        //Fields for calculation of fee
        //Percent of Construction Method and Fee per Sq. Foot
        [DisplayName("Square Foot Cost")]
        public double? SqFtCost { get; set; }
        [DisplayName("Square Foot Amount")]
        public int? SqFootage { get; set; }
        [DisplayName("Engineering Fee Percent")]
        public double? EngineeringFeePercent { get; set; }
        [DisplayName("Engineering Fee Per Square Foot")]
        public double? EngineeringFeePerSqFt { get; set; }
        [DisplayName("Total Fee by Square Foot Method")]
        public double? FeeSqFt { get; set; }                           //TOTAL EngineeringFeePerSqFt * SqFootage 
        [DisplayName("Total Fee by % Construction Method")]
        public double? FeePercentConstruction { get; set; }          //TOTAL ConstructionCost * EngineeringFeePercent
        [DisplayName("Construction Cost")]
        public double? ConstructionCost { get; set;  }               //CLACULATED SqFtCost * SqFootage

        //Fee based on sheets
        [DisplayName("GSN")]
        public int? GSN { get; set; }
        [DisplayName("Typical Details")]
        public int? TypicalDetails { get; set; }
        [DisplayName("Foundation Plans")]
        public int? FoundationPlans { get; set; }
        [DisplayName("Floor Framing")]
        public int? FloorFraming { get; set; }
        [DisplayName("Roof Framing")]
        public int? RoofFraming { get; set; }
        [DisplayName("Wall Panel Elevation")]
        public int? WallPanelElevation { get; set; }
        [DisplayName("Sheer Wall Plans")]
        public int? SheerWallPlans { get; set; }
        [DisplayName("Foundation Details")]
        public int? FoundationDetails { get; set; }
        [DisplayName("Framing Details")]
        public int? FramingDetails { get; set; }

        [DisplayName("Estimated Hours Per Sheet")]
        public int? EstHoursPerSheet { get; set; }
        //public int DraftingHours { get; set; }                  //CALCULATED TotalSheets * EstHoursPerSheet
        // public int EngineeringHours { get; set; }               // CALCULATED 2/3 * DraftingHours + PlanCheckComments + ShopDrawingReview + ConstructionAdmin_RFI
        [DisplayName("Drafting Hourly Rate")]
        public double? DraftingHourlyRate { get; set; }
        [DisplayName("Engineering Hourly Rate")]
        public double? EngineeringHourlyRate { get; set; }
        //public double DraftingEstimatedFee {get;set;}         // CALCULATED DraftingHours * DraftingHourlyRate
        //public double EngineeringEstimatedFee {get;set;}          //CALCULATED EngineeringHours * EnginerringHourlyRate

        [DisplayName("Plan Check Comments")]
        public double? PlanCheckComments { get; set; }
        [DisplayName("Shop Drawing Review")]
        public double? ShopDrawingReview { get; set; }
        [DisplayName("Construction Administration (RFI)")]
        public double? ConstructionAdmin_RFI { get; set; }

        [DisplayName("Special Instructions")]
        public int? SpecialInspections { get; set; }                  //hour count
        [DisplayName("Special Inspections Rate")]
        public double? SpecialInspectionsRate { get; set; }

        [DisplayName("Total Fee by Number of Sheets Method")]
        public double? FeeSheets { get; set; }                //TOTAL  DraftingEstimatedFee + EngineeringEstimatedFee

        //Fee on Man hours
        [DisplayName("GSN Hours")]
        public int? GSNHours { get; set; }
        [DisplayName("Typical Details Hours")]
        public int? TypicalDetailsHours { get; set; }
        [DisplayName("Foundation Plans Hours")]
        public int? FoundationPlansHours { get; set; }
        [DisplayName("Floor Framing Hours")]
        public int? FloorFramingHours { get; set; }
        [DisplayName("Roof Framing Hours")]
        public int? RoofFramingHours { get; set; }
        [DisplayName("Wall Panel Elevation Hours")]
        public int? WallPanelElevationHours { get; set; }
        [DisplayName("Sheer Wall Plans Hours")]
        public int? SheerWallPlansHours { get; set; }
        [DisplayName("Foundation Details Hours")]
        public int? FoundationDetailsHours { get; set; }
        [DisplayName("Framing Details Hours")]
        public int? FramingDetailsHours { get; set; }

        //Fee based on number of Units
        [DisplayName("Number of Units")]
        public int? NumUnits { get; set; }
        [DisplayName("Cost Per Unit")]
        public double? CostPerUnit { get; set; }
        [DisplayName("Community Service Area")]
        public int? CommunityServiceArea { get; set; }
        [DisplayName("Price Per SqFt for Community Service Area")]
        public double? PricePerSqFt_CommunityServiceArea { get; set; }
        [DisplayName("Community Service Fees")]
        public double? CommunityServiceFees { get; set; }
        [DisplayName("Retaining Walls and Misc Fee")]
        public double? RetainingWallsAndMiscFee { get; set; }
        [DisplayName("Note On Misc Fees")]
        public string NoteOnMiscFees { get; set; }
        [DisplayName("Total Fee Based on Number of Units")]
        public double? FeeNumUnits { get; set; }


        //SummaryFields
        [DisplayName("Estimated Total Fee")]
        public double? FeeAverage { get; set; }
        [DisplayName("Number of Fees in Calculation")]
        public int? NumOfFeesInCalc { get; set; }
        [DisplayName("Engineering Estimate")]
        public double? EngineeringEst { get; set; }
        [DisplayName("Drafting Estimate")]
        public double? DraftingEst { get; set; }


        [DisplayName("Contract Amount")]
        public double? ContractAmount { get; set; }
        [DisplayName("Engineering Fee")]
        public double? EngineeringFee { get; set; }
        [DisplayName("Drafting Fee")]
        public double? DraftingFee { get; set; }



    }

    }
