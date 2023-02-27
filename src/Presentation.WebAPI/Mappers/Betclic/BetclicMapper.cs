// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicMapper.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicMapper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers.Betclic
{
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="BetclicMapper"/>
    /// </summary>
    public static class BetclicMapper
    {
        /// <summary>
        /// Maps to competition dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <returns></returns>
        public static CompetitionDto MapToCompetitionDto(this BetclicCompetitionDataModel data, Guid bookmakerId)
        {
            CompetitionDto competition = new()
            {
                League = data.Name,
                Region = data.Country,
                BookmakerId = bookmakerId,
                Games = new()
            };
            foreach (BetclicGameDataModel game in data.Games)
            {
                competition.Games.Add(game.MapToGameDto());
            }

            return competition;
        }

        /// <summary>
        /// Maps to game dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static GameDto MapToGameDto(this BetclicGameDataModel data)
        {
            GameDto game = new()
            {
                Game = data.Name,
                StartDate = data.StartDate,
                Odds = new()
            };

            foreach (BetclicOddDataModel odd in data.Odds)
            {
                game.Odds.Add(odd.MapToOddsDto());
            }

            return game;
        }

        /// <summary>
        /// Maps to odds dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static OddDto MapToOddsDto(this BetclicOddDataModel data)
        {
            return new()
            {
                OddValue = data.OddValue,
                TeamName = data.TeamName,
            };
        }
    }
}