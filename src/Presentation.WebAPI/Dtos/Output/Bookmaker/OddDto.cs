// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    /// <see cref="OddDto"/>
    /// </summary>
    public class OddDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OddDto"/> class.
        /// </summary>
        public OddDto()
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