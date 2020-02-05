using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlizzardCSharp;
using BlizzardLibrary;
using GamerProfileWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace GamerProfileWebApplication.Controllers
{
    public class DiabloController : Controller
    {
        private readonly TestApiKeys _testApiKeys;
        private readonly Client _client;

        public DiabloController(IOptions<TestApiKeys> testApiKeys)
        {
            _testApiKeys = testApiKeys.Value;
            _client = new Client(_testApiKeys.DiabloClient, _testApiKeys.DiabloSecret, Region.EU, Locale.en_GB);
            _client.VerifyConnection();
        }

        public IActionResult Index()
        {
            return View();
        }

        public void Profile(DiabloModel model)
        {
            var c = _client;
        }

        public IActionResult Callback()
        {
            return View();
        }
    }
}