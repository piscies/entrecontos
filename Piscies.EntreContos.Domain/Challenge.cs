using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.Common.Domain;
using System;
using System.Collections.Generic;

namespace Piscies.EntreContos.Domain
{
    public class Challenge : Entity
    {
        #region Properties

        public string Theme { get; set; }
        public List<Classification> Classification { get; set; }

        #endregion

        #region Constructors

        public Challenge()
        {
            EntityName = "Challenge";
        }

        #endregion

        #region Entity Methods

        public override ActionResponseDTO Validate()
        {
            ActionResponseWrapper actionResponse = new ActionResponseWrapper(EntityName);

            if (string.IsNullOrWhiteSpace(Theme))
                actionResponse.AddError("'Tema' é campo obrigatório de um desafio.");

            return actionResponse.Value;
        }

        #endregion
    }
}
