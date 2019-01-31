using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Crosscut.DTO
{
    public class ClassificationDTO
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public ShortStoryDTO ShortStory { get; set; }
    }
}
