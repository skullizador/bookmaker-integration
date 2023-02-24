// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoMapper.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoMapper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers.Betano
{
    using BookmakerIntegration.Domain.ConstantCollections.Betano;
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="BetanoMapper"/>
    /// </summary>
    public static class BetanoMapper
    {
        /// <summary>
        /// Maps to competition dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <returns></returns>
        public static CompetitionDto MapToCompetitionDto(this BetanoBlocksDataModel data, Guid bookmakerId)
        {
            CompetitionDto competition = new()
            {
                League = data.ShortName,
                Region = GetRegion(data.Name),
                BookmakerId = bookmakerId,
                Games = new()
            };

            foreach (BetanoGameDataModel game in data.Events)
            {
                competition.Games.Add(game.MapToGameDto());
            }

            return competition;
        }

        /// <summary>
        /// Gets the date time.
        /// </summary>
        /// <param name="millis">The millis.</param>
        /// <returns></returns>
        private static DateTime GetDateTime(long millis)
        {
            double ticks = Convert.ToDouble(millis);

            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local)
                .AddMilliseconds(ticks)
                .ToUniversalTime();
        }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <param name="markets">The markets.</param>
        /// <returns></returns>
        private static List<BetanoOddDataModel> GetOdds(List<BetanoMarketDataModel> markets)
        {
            return markets.Single(x => x.Name == BetanoConstantCollection.BetanoCurrentWantedOdds.Value)
                .Selections;
        }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string GetRegion(string name)
        {
            return name.Split(' ')
                .First();
        }

        /// <summary>
        /// Maps to game dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        private static GameDto MapToGameDto(this BetanoGameDataModel data)
        {
            GameDto game = new()
            {
                Game = data.Name,
                StartDate = GetDateTime(data.StartTime),
                Odds = new()
            };

            foreach (BetanoOddDataModel odd in GetOdds(data.Markets))
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
        private static OddDto MapToOddDto(this BetanoOddDataModel data)
        {
            return new()
            {
                TeamName = data.FullName,
                OddValue = data.Price
            };
        }
    }
}