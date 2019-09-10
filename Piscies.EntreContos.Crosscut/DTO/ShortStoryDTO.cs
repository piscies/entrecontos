using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Crosscut.DTO
{
    public class ShortStoryDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public WriterDTO Author { get; set; }
        public string URL { get; set; }
    }
}