// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicGameDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicGameDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betclic
{
    /// <summary>
    /// <see cref="BetclicGameDto"/>
    /// </summary>
    public class BetclicGameDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicGameDto"/> class.
        /// </summary>
        public BetclicGameDto()
        {
            this.Name = string.Empty;
            this.TeamAName = string.Empty;
            this.TeamBName = string.Empty;
            this.Odds = new();
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<BetclicOddDto> Odds { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; init; }

        /// <summary>
        /// Gets the name of the team a.
        /// </summary>
        /// <value>The name of the team a.</value>
        public string TeamAName { get; init; }

        /// <summary>
        /// Gets the name of the team b.
        /// </summary>
        /// <value>The name of the team b.</value>
        public string TeamBName { get; init; }
    }
}