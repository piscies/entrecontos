using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Piscies.EntreContos.Application.Translators
{
    public static class ChallengeTranslator
    {
        public static ChallengeDTO SetDTO(Challenge challenge)
        {
            if (challenge == null)
                return null;

            ChallengeDTO challengeDTO = new ChallengeDTO();
            challengeDTO.Id = challenge.Id;
            challengeDTO.Theme = challenge.Theme;
            challengeDTO.AnnouncementDate = challenge.AnnouncementDate;
            challengeDTO.ResultsDate = challenge.ResultsDate;

            return challengeDTO;
        }

        public static IList<ChallengeDTO> SetDTO(IList<Challenge> challenges)
        {
            if (challenges == null)
                return null;

            IList<ChallengeDTO> challengeDTOs = new List<ChallengeDTO>();

            foreach (Challenge challenge in challenges)
            {
                challengeDTOs.Add(SetDTO(challenge));
            }

            return challengeDTOs;
        }
    }
}
