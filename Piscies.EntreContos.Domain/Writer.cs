using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Domain
{
    public class Writer : Entity
    {
        #region Properties

        public string Name { get; set; }

        #endregion

        #region Constructors

        public Writer()
        {
            EntityName = "Writer";
        }
        public Writer(int id, string name)
        {
            EntityName = "Writer";
            this.Id = id;
            this.Name = name;
        }

        #endregion

        #region Entity Methods

        public override ActionResponseDTO Validate()
        {
            ActionResponseWrapper actionResponse = new ActionResponseWrapper(EntityName);

            if (string.IsNullOrEmpty(Name))
                actionResponse.AddError("'Nome' é campo obrigatório para um Escritor.");

            return actionResponse.Value;
        }

        #endregion
    }
}
