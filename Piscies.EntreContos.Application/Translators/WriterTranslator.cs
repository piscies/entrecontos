using Piscies.EntreContos.Crosscut.DTO;
using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Piscies.EntreContos.Application.Translators
{
    public static class WriterTranslator
    {
        public static WriterDTO SetDTO(Writer writer)
        {
            if (writer == null)
                return null;

            WriterDTO writerDTO = new WriterDTO();
            writerDTO.Id = writer.Id;
            writerDTO.Name = writer.Name;

            return writerDTO;
        }

        public static IList<WriterDTO> SetDTO(IList<Writer> writers)
        {
            if (writers == null)
                return null;

            IList<WriterDTO> writerDTOs = new List<WriterDTO>();

            foreach (Writer writer in writers)
            {
                writerDTOs.Add(SetDTO(writer));
            }

            return writerDTOs;
        }
    }
}
