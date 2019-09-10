using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Crosscut.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Piscies.EntreContos.Frontend.MVC.Controllers
{
    public class ChallengesController : Controller
    {   
        public ActionResult Index()
        {
            List<ChallengeDTO> challenges = new List<ChallengeDTO>();
            challenges.Add(new ChallengeDTO() { Theme = "Cemitérios", AnnouncementDate = DateTime.Now.AddMonths(3) });
            challenges.Add(new ChallengeDTO() { Theme = "Fantasmas", AnnouncementDate = DateTime.Now.AddMonths(6) });
            challenges.Add(new ChallengeDTO() { Theme = "Faroeste", AnnouncementDate = DateTime.Now.AddMonths(-7) });

            ChallengeViewModel challengeViewModel = new ChallengeViewModel();
            challengeViewModel.Challenges = challenges;
            return View(challengeViewModel);
        }
    }
}