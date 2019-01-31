using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.EntreContos.Application.Interface;
using Piscies.EntreContos.Application.Translators;
using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using Piscies.EntreContos.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Piscies.EntreContos.Application
{
    public class ChallengeApp : IChallengeApp
    {
        IChallengeInfrastructure challengeInfrastructure;

        public ChallengeApp(IChallengeInfrastructure challengeInfrastructure)
        {
            this.challengeInfrastructure = challengeInfrastructure;
        }

        public async Task<ActionResponseDTO> GetById(int id)
        {
            ActionResponseWrapper actionResponseWrapper = new ActionResponseWrapper(typeof(ChallengeApp).FullName);
            
            //Gets the challenge in the database
            Challenge foundChallenge = await challengeInfrastructure.GetById(id);

            //Translates
            ChallengeDTO challengeDTO = ChallengeTranslator.SetDTO(foundChallenge);

            //Prepares the return
            actionResponseWrapper.SetContent(challengeDTO);

            return actionResponseWrapper.Value;
        }
    }
}
