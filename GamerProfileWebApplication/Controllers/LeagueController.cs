using System;
using System.Threading.Tasks;
using CoreApiClient;
using GamerProfileWebApplication.Models;
using LeagueLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GamerProfileWebApplication.Controllers
{
    public class LeagueController : Controller
    {
        private readonly TestApiKeys _testApiKeys;
        private readonly ApiClient _client = new ApiClient(new Uri("https://euw1.api.riotgames.com/"));

        public LeagueController(IOptions<TestApiKeys> testApiKeys)
        {
            _testApiKeys = testApiKeys.Value;
        }

        public async Task<IActionResult> Summoner(RequestModel requestModel)
        {
            requestModel.ApiKey = _testApiKeys.League;

            var profile = await _client.GetLeagueProfile(requestModel);
            return View(profile);
        }
    }
}