// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoOddDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoOddDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betano
{
    /// <summary>
    /// <see cref="BetanoOddDto"/>
    /// </summary>
    public class BetanoOddDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoOddDto"/> class.
        /// </summary>
        public BetanoOddDto()
        {
            this.TeamName = string.Empty;
        }

        /// <summary>
        /// Gets the odd value.
        /// </summary>
        /// <value>The odd value.</value>
        public decimal OddValue { get; init; }

        /// <summary>
        /// Gets the name of the team.
        /// </summary>
        /// <value>The name of the team.</value>
        public string TeamName { get; init; }
    }
}