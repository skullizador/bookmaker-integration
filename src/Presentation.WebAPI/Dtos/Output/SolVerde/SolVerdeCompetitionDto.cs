// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolVerdeCompetitionDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SolVerdeCompetitionDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.SolVerde
{
    /// <summary>
    /// <see cref="SolVerdeCompetitionDto"/>
    /// </summary>
    public class SolVerdeCompetitionDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolVerdeCompetitionDto"/> class.
        /// </summary>
        public SolVerdeCompetitionDto()
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
        public List<SolVerdeGameDto> Games { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }
    }
}