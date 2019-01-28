using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Domain
{
    public class Classification : Entity
    {
        #region Properties

        public int Position { get; set; }        
        public ShortStory ShortStory { get; set; }

        #endregion

        #region Constructors

        public Classification()
        {
            EntityName = "Classification";
        }

        #endregion

        #region Entity Methods

        public override ActionResponseDTO Validate()
        {
            ActionResponseWrapper actionResponse = new ActionResponseWrapper(EntityName);

            if (Position <= 0)
                actionResponse.AddError("'Posição' é campo obrigatório de uma classificação.");

            if (ShortStory == null)
                actionResponse.AddError("Toda classificação tem que ter um Conto atrelado a ela.");
            else
                actionResponse.IncorporateActionResponse(ShortStory.Validate());

            return actionResponse.Value;
        }

        #endregion
    }
}
