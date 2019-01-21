using Piscies.EntreContos.Domain;
using System;
using System.Collections.Generic;

namespace Piscies.EntreContos.Infrastructure.Interface
{
    public interface IWriterInfrastructure
    {
        IList<Writer> List();
    }
}
