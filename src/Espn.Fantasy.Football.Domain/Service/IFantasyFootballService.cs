﻿using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model;

namespace Espn.Fantasy.Football.Domain.Service
{
    public interface IFantasyFootballService
    {
        Task<League> GetLeagueAsync(int leagueId, int year);
    }
}
