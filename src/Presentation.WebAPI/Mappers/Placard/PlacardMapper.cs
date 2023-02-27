// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardMapper.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardMapper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Mappers.Placard
{
    using BookmakerIntegration.Domain.DataModels.Placard.Response;
    using BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="PlacardMapper"/>
    /// </summary>
    public static class PlacardMapper
    {
        /// <summary>
        /// Maps to competition dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="league">The league.</param>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        public static CompetitionDto MapToCompetitionDto(this PlacardDataModel data, Guid bookmakerId, string league, string region)
        {
            CompetitionDto competition = new()
            {
                League = league,
                Region = region,
                BookmakerId = bookmakerId,
                Games = new()
            };

            foreach (PlacardEventModel game in data.EventDataList.List)
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
        public static GameDto MapToGameDto(this PlacardEventModel data)
        {
            return new()
            {
                Game = $"{data.HomeOpponent} - {data.AwayOpponent}",
                StartDate = data.StartDateTime,
                Odds = data.MapToOddsDto()
            };
        }

        /// <summary>
        /// Maps to odds dto.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static List<OddDto> MapToOddsDto(this PlacardEventModel data)
        {
            List<OddDto> odds = new();

            OddDto awayOpponentOdd = new()
            {
                OddValue = Convert.ToDecimal(data.MarketOutcome3_Price),
                TeamName = data.MarketOutcome3_Description
            };

            odds.Add(awayOpponentOdd);

            OddDto homeOpponentOdd = new()
            {
                OddValue = Convert.ToDecimal(data.MarketOutcome1_Price),
                TeamName = data.MarketOutcome1_Description
            };

            odds.Add(homeOpponentOdd);

            OddDto drawOdd = new()
            {
                OddValue = Convert.ToDecimal(data.MarketOutcome2_Price),
                TeamName = data.MarketOutcome2_Description
            };

            odds.Add(drawOdd);

            return odds;
        }
    }
}