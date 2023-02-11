// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBookmakerDataByCompetitionIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBookmakerDataByCompetitionIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Input.Bookmaker
{
    /// <summary>
    /// <see cref="GetBookmakerDataByCompetitionIdDto"/>
    /// </summary>
    public class GetBookmakerDataByCompetitionIdDto
    {
        /// <summary>
        /// Gets the competition identifier.
        /// </summary>
        /// <value>The competition identifier.</value>
        public Guid CompetitionId { get; init; }
    }
}