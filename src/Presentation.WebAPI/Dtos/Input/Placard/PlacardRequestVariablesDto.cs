// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardRequestVariablesDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardRequestVariablesDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Placard
{
    /// <summary>
    /// <see cref="PlacardRequestVariablesDto"/>
    /// </summary>
    public class PlacardRequestVariablesDto
    {
        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; init; }

        /// <summary>
        /// Gets the placard competition identifier.
        /// </summary>
        /// <value>The placard competition identifier.</value>
        public int PlacardCompetitionId { get; init; }

        /// <summary>
        /// Gets the sport.
        /// </summary>
        /// <value>The sport.</value>
        public string Sport { get; init; }
    }
}