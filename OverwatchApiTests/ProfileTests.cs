using System;
using Xunit;
using CoreApiClient;
using OverwatchLibrary.Models;

namespace OverwatchLibraryTests
{
    public class ProfileTests
    {
        private readonly ApiClient _client = new ApiClient(new Uri("http://owapi.io"));

        [Fact]
        public async System.Threading.Tasks.Task PublicProfileTest()
        {
            var user = new UserModel { UserName = "Kevster-21281", PlatformSelect = "pc", RegionSelect = "eu" };
            var profile = await _client.GetProfile(user);
            Assert.Equal(false, profile.Private);
        }

        [Fact]
        public async void PrivateProfileTest()
        {
            var user = new UserModel { UserName = "JayyJayy-2357", PlatformSelect = "pc", RegionSelect = "eu" };
            var profile = await _client.GetProfile(user);
            Assert.Equal(true, profile.Private);
        }
    }
}
