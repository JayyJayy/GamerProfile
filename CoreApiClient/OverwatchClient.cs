using OverwatchApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<Profile> GetProfile(UserModel user)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"profile/{user.PlatformSelect}/{user.RegionSelect}/{user.UserName}"));
            return await GetAsync<Profile>(requestUrl);
        }
    }
}