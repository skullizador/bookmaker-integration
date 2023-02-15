// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicOddDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicOddDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betclic
{
    /// <summary>
    /// <see cref="BetclicOddDto"/>
    /// </summary>
    public class BetclicOddDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicOddDto"/> class.
        /// </summary>
        public BetclicOddDto()
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