﻿using Espn.Fantasy.Football.Domain.Provider;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Provider
{
    [TestFixture]
    public class HardcodedUrlConfigurationProviderTests
    {
        [Test]
        public void Should_GetLeagueUrl_ForValidInput()
        {
            //arrange
            int leagueId = 5555;
            int year = 2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetLeagueEndpointUrl(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/leaguesettings?leagueId=5555&seasonId=2018");
        }

        [Test]
        public void Should_GetLeagueUrl_ForNegativeInput()
        {
            //arrange
            int leagueId = -5555;
            int year = -2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetLeagueEndpointUrl(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/leaguesettings?leagueId=-5555&seasonId=-2018");
        }

        [Test]
        public void Should_GetScoreboardUrl_ForValidInput()
        {
            //arrange
            int leagueId = 5555;
            int year = 2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetScoreboardEndpoint(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/scoreboard?leagueId=5555&seasonId=2018");
        }

        [Test]
        public void Should_GetScoreboardUrl_ForNegativeInput()
        {
            //arrange
            int leagueId = -5555;
            int year = -2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetScoreboardEndpoint(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/scoreboard?leagueId=-5555&seasonId=-2018");
        }
        
        [Test]
        public void Should_GetRecentActivityUrl_ForValidInput()
        {
            //arrange
            int leagueId = 5555;
            int year = 2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetRecentActivityEndpoint(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/recentActivity?leagueId=5555&seasonId=2018");
        }

        [Test]
        public void Should_GetRecentActivityUrl_ForNegativeInput()
        {
            //arrange
            int leagueId = -5555;
            int year = -2018;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetRecentActivityEndpoint(leagueId, year);

            //assert
            url.Should().BeEquivalentTo("http://games.espn.com/ffl/api/v2/recentActivity?leagueId=-5555&seasonId=-2018");
        }
        
        [Test]
        public void Should_GetNflPlayerUrl_ForValidInput()
        {
            //arrange
            int playerId = 55555;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetNflPlayerEndpoint(playerId);

            //assert
            url.Should().BeEquivalentTo("http://www.espn.com/nfl/player/_/id/55555");
        }

        [Test]
        public void Should_GetNflPlayerUrl_ForNegativeInput()
        {
            //arrange
            int playerId = -55555;
            IUrlConfigurationProvider urlConfigurationProvider = new HardcodedUrlConfigurationProvider();

            //act
            string url = urlConfigurationProvider.GetNflPlayerEndpoint(playerId);

            //assert
            url.Should().BeEquivalentTo("http://www.espn.com/nfl/player/_/id/-55555");
        }
    }
}
