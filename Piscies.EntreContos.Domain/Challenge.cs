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
        public DateTime AnnouncementDate { get; set; }
        public DateTime ResultsDate { get; set; }

        #endregion

        #region Constructors

        public Challenge()
        {
            EntityName = "Challenge";
        }

        public Challenge(int id, string theme, DateTime announcementDate)
        {
            EntityName = "Challenge";
            this.Id = id;
            this.Theme = theme;
            this.AnnouncementDate = announcementDate;
        }

        #endregion

        #region Entity Methods

        public override ActionResponseDTO Validate()
        {
            ActionResponseWrapper actionResponse = new ActionResponseWrapper(EntityName);

            if (string.IsNullOrWhiteSpace(Theme))
                actionResponse.AddError("'Tema' é campo obrigatório de um desafio.");

            if (AnnouncementDate == null || AnnouncementDate == DateTime.MinValue)
                actionResponse.AddError("'Data de Anúncio' é campo obrigatório de um desafio.");

            return actionResponse.Value;
        }

        #endregion
    }
}
