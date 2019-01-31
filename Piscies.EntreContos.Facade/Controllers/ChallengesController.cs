using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piscies.Common.Crosscut.DTO;
using Piscies.EntreContos.Application.Interface;

namespace Piscies.EntreContos.Facade.Controllers
{
    [Route("api/[controller]")]
    public class ChallengesController : Controller
    {
        IChallengeApp challengeApp;

        public ChallengesController(IChallengeApp challengeApp)
        {
            this.challengeApp = challengeApp;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ActionResponseDTO response = new ActionResponseDTO();

            try
            {
                response = await challengeApp.GetById(id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

            return Ok(response.Content);
        }
    }
}
