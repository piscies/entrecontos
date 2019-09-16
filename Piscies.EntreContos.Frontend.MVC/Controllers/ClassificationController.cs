using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Crosscut.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Piscies.EntreContos.Frontend.MVC.Controllers
{
    public class ClassificationController : Controller
    {        
        public ActionResult Index()
        {
            List<ClassificationDTO> classifications = new List<ClassificationDTO>();
            classifications.Add(new ClassificationDTO() { Challenge = new ChallengeDTO() { Theme = "CHALLENGE!" }, Position = 1, ShortStory = new ShortStoryDTO() { Title = "Short Story 1", Author = new WriterDTO() { Name = "Marco" } } });
            classifications.Add(new ClassificationDTO() { Challenge = new ChallengeDTO() { Theme = "CHALLENGE!" }, Position = 2, ShortStory = new ShortStoryDTO() { Title = "Short Story 2", Author = new WriterDTO() { Name = "Fabio" } } });
            classifications.Add(new ClassificationDTO() { Challenge = new ChallengeDTO() { Theme = "CHALLENGE!" }, Position = 3, ShortStory = new ShortStoryDTO() { Title = "Short Story 3", Author = new WriterDTO() { Name = "Gustavo" } } });

            ClassificationViewModel classificationViewModel = new ClassificationViewModel();
            classificationViewModel.ChallengeTheme = classifications[0].Challenge.Theme;
            classificationViewModel.Classifications = classifications;
            return View(classificationViewModel);
        }
    }
}