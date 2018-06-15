﻿using System.Threading.Tasks;
using Espn.Fantasy.Football.Client;
using Espn.Fantasy.Football.Domain.Model;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Integration.NetCore20
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public async Task Should_GetLeagueAsync_ForValidInput()
        {
            //arrange
            int leagueId = 526113;
            int year = 2018;
            EspnFantasyFootballClient espnFantasyFootballClient = new EspnFantasyFootballClient();

            //act
            League league = await espnFantasyFootballClient.GetLeagueAsync(leagueId, year);

            //assert
            league.Should().NotBeNull();
        }
    }
}