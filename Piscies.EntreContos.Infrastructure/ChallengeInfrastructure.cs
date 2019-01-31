using Microsoft.Extensions.Configuration;
using Piscies.EntreContos.Domain;
using Piscies.EntreContos.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Piscies.EntreContos.Infrastructure
{
    public class ChallengeInfrastructure : IChallengeInfrastructure
    {
        private IConfiguration Configuration { get; set; }

        public ChallengeInfrastructure(IConfiguration config)
        {
            Configuration = config;
        }

        public async Task<Challenge> GetById(int id)
        {
            Challenge foundChallenge;

            using (EntityModelContext context = new EntityModelContext(Configuration))
            {
                foundChallenge = await context.Challenge
                    .Include(ch => ch.Classification)
                        .ThenInclude(cl => cl.ShortStory)
                            .ThenInclude(ss => ss.Writer)
                    .FirstOrDefaultAsync(x => x.Id == id);
            }

            return foundChallenge;
        }
    }
}
