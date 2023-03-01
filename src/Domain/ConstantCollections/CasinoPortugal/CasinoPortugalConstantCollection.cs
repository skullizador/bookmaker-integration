// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.CasinoPortugal
{
    /// <summary>
    /// <see cref="CasinoPortugalConstantCollection"/>
    /// </summary>
    public static class CasinoPortugalConstantCollection
    {
        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public static CasinoPortugalConstant BookmakerId => new(string.Empty);

        /// <summary>
        /// Gets the casino portugal wanted odds.
        /// </summary>
        /// <value>The casino portugal wanted odds.</value>
        public static CasinoPortugalConstant CasinoPortugalWantedOdds => new("1x2");
    }
}