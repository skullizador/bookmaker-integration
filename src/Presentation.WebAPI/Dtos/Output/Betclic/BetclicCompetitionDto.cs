// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicCompetitionDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicCompetitionDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betclic
{
    /// <summary>
    /// <see cref="BetclicCompetitionDto"/>
    /// </summary>
    public class BetclicCompetitionDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicCompetitionDto"/> class.
        /// </summary>
        public BetclicCompetitionDto()
        {
            this.Country = string.Empty;
            this.Name = string.Empty;
            this.Games = new();
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; init; }

        /// <summary>
        /// Gets the games.
        /// </summary>
        /// <value>The games.</value>
        public List<BetclicGameDto> Games { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }
    }
}