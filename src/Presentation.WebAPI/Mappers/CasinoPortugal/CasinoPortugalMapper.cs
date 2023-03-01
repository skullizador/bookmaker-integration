// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalMapper.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalMapper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers.CasinoPortugal
{
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="CasinoPortugalMapper"/>
    /// </summary>
    public static class CasinoPortugalMapper
    {
        /// <summary>
        /// Maps to competition dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <returns></returns>
        public static CompetitionDto MapToCompetitionDto(this CasinoPortugalJsonDataModel data, Guid bookmakerId)
        {
            CompetitionDto competition = new()
            {
                League = data.fixtures.First().comp_name,
                Region = data.fixtures.First().region_name,
                BookmakerId = bookmakerId,
                Games = new List<GameDto>()
            };

            foreach (CasinoPortugalFixtureDataModel fixture in data.fixtures)
            {
                competition.Games.Add(fixture.MapToGameDto());
            }

            return competition;
        }

        /// <summary>
        /// Maps to game dto.
        /// </summary>
        /// <param name="fixture">The fixture.</param>
        /// <returns></returns>
        private static GameDto MapToGameDto(this CasinoPortugalFixtureDataModel fixture)
        {
            GameDto game = new()
            {
                Game = fixture.name,
                StartDate = fixture.start_time_utc,
                Odds = new List<OddDto>()
            };

            List<CasinoPortugalOddDataModel> odds = fixture.WantedMarkets.First().selections;

            foreach (CasinoPortugalOddDataModel odd in odds)
            {
                game.Odds.Add(odd.MapToOddDto());
            }

            return game;
        }

        /// <summary>
        /// Maps to odd dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        private static OddDto MapToOddDto(this CasinoPortugalOddDataModel data)
        {
            return new OddDto()
            {
                TeamName = data.selection_name,
                OddValue = data.Decimal
            };
        }
    }
}