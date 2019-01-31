using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Domain
{
    public class ShortStory : Entity
    {
        #region Properties

        public string Title { get; set; }
        public Writer Writer { get; set; }
        public Challenge Challenge { get; set; }
        public string URL { get; set; }

        #endregion

        #region Constructors

        public ShortStory()
        {
            EntityName = "ShortStory";
        }

        #endregion

        #region Entity Methods

        public override ActionResponseDTO Validate()
        {
            ActionResponseWrapper actionResponse = new ActionResponseWrapper(EntityName);

            if (string.IsNullOrEmpty(Title))
                actionResponse.AddError("'Título' é campo obrigatório para um Conto.");

            if (Writer == null)
                actionResponse.AddError("'Autor' é campo obrigatório para um Conto.");
            else
                actionResponse.IncorporateActionResponse(Writer.Validate());

            if (Challenge == null)
                actionResponse.AddError("'Desafio' é campo obrigatório para um Conto.");
            else
                actionResponse.IncorporateActionResponse(Challenge.Validate());

            return actionResponse.Value;
        }

        #endregion
    }
}
