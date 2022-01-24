using pubgstats.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace pubgstats.PubgClient
{
    public class PubgClient : IPubgClient
    {
        public Task<List<string>> GetLifeTimeStats()
        {
            throw new NotImplementedException();
        }

        public async Task<PlayerSeasonStats> GetSeasonStats()
        {
            // eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiJiMWU2ODk0MC00OTU0LTAxMzktOWI4My0wMTVjZDc2MmZiYTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNjEyNDcwMTc4LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6InB1Ymctc3RhdHMtZmluIn0.gCOOQtprWoYa__2RIU3mHMIf4qplt9jojZjQJjdtgjM
            // account.aedc181577584ca9884fdd6e00f1d42b (Spuute PC-EU)

            var connectionString = "";
            var client = new RestClient("https://api.pubg.com/shards/steam/seasons/division.bro.official.pc-2018-15/gameMode/solo-fpp/");
            client.Authenticator = new JwtAuthenticator("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiJiMWU2ODk0MC00OTU0LTAxMzktOWI4My0wMTVjZDc2MmZiYTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNjEyNDcwMTc4LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6InB1Ymctc3RhdHMtZmluIn0.gCOOQtprWoYa__2RIU3mHMIf4qplt9jojZjQJjdtgjM");

            var request = new RestRequest("players?filter[playerIds]=account.c0e530e9b7244b358def282782f893af&filter[gamepad]=false");
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteAsync<PlayerSeasonStats>(request);

            return response.Data;
        }
    }
}
