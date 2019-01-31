using Piscies.Common.Crosscut.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Piscies.EntreContos.Application.Interface
{
    public interface IChallengeApp
    {
        Task<ActionResponseDTO> GetById(int id);
    }
}
