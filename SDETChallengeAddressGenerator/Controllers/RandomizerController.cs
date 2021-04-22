using Bogus;

using Microsoft.AspNetCore.Mvc;
using SDETChallengeAddressGenerator.Models;
using SDETChallengeAddressGenerator.UtilityFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SDETChallengeAddressGenerator.Controllers
{
    [Route("[controller]")]

    public class RandomizerController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Address()
        {
            var result = RandomGenerator.AddressGenerator();

            return Ok(result);
        }
    }
}