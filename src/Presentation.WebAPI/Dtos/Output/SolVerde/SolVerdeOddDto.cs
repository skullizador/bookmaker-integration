// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolVerdeOddDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// SolVerdeOddDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.SolVerde
{
    /// <summary>
    /// <see cref="SolVerdeOddDto"/>
    /// </summary>
    public class SolVerdeOddDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolVerdeOddDto"/> class.
        /// </summary>
        public SolVerdeOddDto()
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