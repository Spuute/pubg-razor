using System.Collections.Generic;
using pubgstats.Models;

namespace pubgstats.PubgClient
{
    public interface IPubgClient
    {
        Task<List<string>> GetLifeTimeStats();
        Task<PlayerSeasonStats> GetSeasonStats();
    }
}