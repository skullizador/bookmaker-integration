// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoGameDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoGameDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betano
{
    /// <summary>
    /// <see cref="BetanoGameDto"/>
    /// </summary>
    public class BetanoGameDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoGameDto"/> class.
        /// </summary>
        public BetanoGameDto()
        {
            this.Game = string.Empty;
            this.Odds = new List<BetanoOddDto>();
        }

        /// <summary>
        /// Gets the game.
        /// </summary>
        /// <value>The game.</value>
        public string Game { get; init; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<BetanoOddDto> Odds { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; init; }
    }
}