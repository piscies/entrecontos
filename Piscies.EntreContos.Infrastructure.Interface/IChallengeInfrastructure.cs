using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Piscies.EntreContos.Infrastructure.Interface
{
    public interface IChallengeInfrastructure
    {
        Task<Challenge> GetById(int id);
        Task<IList<Challenge>> GetList();
    }
}
