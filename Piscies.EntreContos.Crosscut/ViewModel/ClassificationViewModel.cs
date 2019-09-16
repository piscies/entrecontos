using Piscies.EntreContos.Crosscut.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Crosscut.ViewModel
{
    public class ClassificationViewModel
    {
        public string ChallengeTheme { get; set; }
        public List<ClassificationDTO> Classifications { get; set; }
    }
}
