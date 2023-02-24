// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitionDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CompetitionDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    /// <see cref="CompetitionDto"/>
    /// </summary>
    public class CompetitionDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionDto"/> class.
        /// </summary>
        public CompetitionDto()
        {
            this.League = string.Empty;
            this.Region = string.Empty;
            this.Games = new List<GameDto>();
        }

        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }

        /// <summary>
        /// Gets the games.
        /// </summary>
        /// <value>The games.</value>
        public List<GameDto> Games { get; init; }

        /// <summary>
        /// Gets the league.
        /// </summary>
        /// <value>The league.</value>
        public string League { get; init; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <value>The region.</value>
        public string Region { get; init; }
    }
}