using Microsoft.Extensions.Configuration;
using Piscies.EntreContos.Domain;
using Piscies.EntreContos.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Piscies.EntreContos.Infrastructure
{
    public class WriterInfrastructure : IWriterInfrastructure
    {
        private IConfiguration Configuration { get; set; }

        public WriterInfrastructure(IConfiguration config)
        {
            Configuration = config;
        }

        public IList<Writer> List()
        {
            List<Writer> allWriters;

            using (EntityModelContext context = new EntityModelContext(Configuration))
            {
                allWriters = context.Writer.ToList();
            }

            return allWriters;
        }
    }
}
