using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Application.Translators
{
    public static class ShortStoryTranslator
    {
        public static ShortStoryDTO SetDTO(ShortStory shortStory)
        {
            if (shortStory == null)
                return null;

            ShortStoryDTO shortStoryDTO = new ShortStoryDTO();
            shortStoryDTO.Id = shortStory.Id;
            shortStoryDTO.Title = shortStory.Title;
            shortStoryDTO.URL = shortStory.URL;            

            shortStoryDTO.Author = WriterTranslator.SetDTO(shortStory.Writer);

            return shortStoryDTO;
        }

        public static IList<ShortStoryDTO> SetDTO(IList<ShortStory> shortStories)
        {
            if (shortStories == null)
                return null;

            IList<ShortStoryDTO> shortStoryDTOs = new List<ShortStoryDTO>();

            foreach (ShortStory shortStory in shortStories)
            {
                shortStoryDTOs.Add(SetDTO(shortStory));
            }

            return shortStoryDTOs;
        }
    }
}
