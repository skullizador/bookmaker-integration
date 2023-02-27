// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    /// <see cref="GameDto"/>
    /// </summary>
    public class GameDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameDto"/> class.
        /// </summary>
        public GameDto()
        {
            this.Game = string.Empty;
            this.Odds = new List<OddDto>();
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
        public List<OddDto> Odds { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; init; }
    }
}