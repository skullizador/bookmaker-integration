﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoBlockDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoBlockDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Dtos.Output.Betano
{
    /// <summary>
    /// <see cref="BetanoBlockDto"/>
    /// </summary>
    public class BetanoBlockDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoBlockDto"/> class.
        /// </summary>
        public BetanoBlockDto()
        {
            this.League = string.Empty;
            this.Region = string.Empty;
            this.Games = new List<BetanoGameDto>();
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
        public List<BetanoGameDto> Games { get; init; }

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