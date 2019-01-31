using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Application.Translators
{
    public static class ClassificationTranslator
    {
        public static ClassificationDTO SetDTO(Classification classification)
        {
            if (classification == null)
                return null;

            ClassificationDTO classificationDTO = new ClassificationDTO();
            classificationDTO.Id = classification.Id;
            classificationDTO.Position = classification.Position;

            classificationDTO.ShortStory = ShortStoryTranslator.SetDTO(classification.ShortStory);

            return classificationDTO;
        }

        public static IList<ClassificationDTO> SetDTO(IList<Classification> classifications)
        {
            if (classifications == null)
                return null;

            IList<ClassificationDTO> classificationDTOs = new List<ClassificationDTO>();

            foreach (Classification classification in classifications)
            {
                classificationDTOs.Add(SetDTO(classification));
            }

            return classificationDTOs;
        }
    }
}
