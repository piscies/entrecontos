using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Crosscut.DTO
{
    public class ChallengeDTO
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ResultsDate { get; set; }
    }
}
