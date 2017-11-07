using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    class Proposal
    {
        //variables here
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