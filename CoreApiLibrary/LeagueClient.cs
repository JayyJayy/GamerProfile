using LeagueLibrary.Models;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<SummonerModel> GetLeagueProfile(RequestModel request)
        {
            var queryString = $"api_key={request.ApiKey}";
            var requestUri = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"/lol/summoner/v4/summoners/by-name/{request.SummonerName}"), queryString);
            return await GetAsync<SummonerModel>(requestUri);
        }
    }
}
