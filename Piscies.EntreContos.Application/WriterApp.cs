using Piscies.Common.Crosscut.DTO;
using Piscies.Common.Crosscut.Helpers;
using Piscies.EntreContos.Application.Interface;
using Piscies.EntreContos.Application.Translators;
using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using Piscies.EntreContos.Infrastructure.Interface;
using System;
using System.Collections.Generic;

namespace Piscies.EntreContos.Application
{
    public class WriterApp : IWriterApp
    {
        IWriterInfrastructure writerInfrastructure;

        public WriterApp(IWriterInfrastructure writerInfrastructure)
        {
            this.writerInfrastructure = writerInfrastructure;
        }

        public ActionResponseDTO List()
        {
            ActionResponseWrapper actionResponseWrapper = new ActionResponseWrapper(typeof(WriterApp).FullName);

            //Gets the list in the database
            IList<Writer> writerList = writerInfrastructure.List();

            //Translates
            IList<WriterDTO> writerListDTO = WriterTranslator.SetDTO(writerList);

            //Prepares the return
            actionResponseWrapper.SetContent(writerListDTO);

            return actionResponseWrapper.Value;
        }
    }
}
