using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiClient;
using Microsoft.AspNetCore.Mvc;
using OverwatchLibrary.Models;

namespace GamerProfileWebApplication.Controllers
{
    public class OverwatchController : Controller
    {
        private readonly ApiClient _client = new ApiClient(new Uri("http://owapi.io"));

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Stats")]
        public async Task<IActionResult> Stats(string username, string platform, string region)
        {
            var profileModel = new UserModel
            {
                UserName = username,
                PlatformSelect = platform,
                RegionSelect = region
            };

            var profile = await _client.GetProfile(profileModel);
            return View(profile);
        }
    }
}