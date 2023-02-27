// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinMapper.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinMapper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers.Bwin
{
    using BookmakerIntegration.Domain.ConstantCollections.Bwin;
    using BookmakerIntegration.Domain.DataModels.Bwin;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="BwinMapper"/>
    /// </summary>
    public static class BwinMapper
    {
        /// <summary>
        /// Maps to competition dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="league">The league.</param>
        /// <returns></returns>
        public static CompetitionDto MapToCompetitionDto(this BwinWidgetDataModel data, Guid bookmakerId, string league)
        {
            CompetitionDto competition = new()
            {
                BookmakerId = bookmakerId,
                League = league,
                Region = data.payload.fixtures.First().region.name.value,
                Games = new()
            };

            foreach (BwinGameDataModel game in data.payload.fixtures)
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
        private static GameDto MapToGameDto(this BwinGameDataModel data)
        {
            GameDto game = new()
            {
                Game = data.name.value,
                StartDate = data.startDate,
                Odds = new()
            };

            List<BwinOddDataModel> gameOptions = data.optionMarkets
                .First(x => x.name.value == BwinConstantCollection.CurrentWantedOdds.Value)
                .options;

            foreach (BwinOddDataModel odd in gameOptions)
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
        private static OddDto MapToOddDto(this BwinOddDataModel data)
        {
            return new()
            {
                OddValue = data.price.odds,
                TeamName = data.name.value
            };
        }
    }
}