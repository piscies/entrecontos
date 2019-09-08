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
        public string URL { get; set; }

        #endregion

        #region Constructors

        public ShortStory()
        {
            EntityName = "ShortStory";
        }
        public ShortStory(int id, string Title, Writer writer, string URL)
        {
            EntityName = "ShortStory";
            this.Id = id;
            this.Writer = writer;
            this.URL = URL;
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

            return actionResponse.Value;
        }

        #endregion
    }
}
