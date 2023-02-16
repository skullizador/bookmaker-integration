// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.ConstantCollections.Betano
{
    /// <summary>
    /// <see cref="BetanoConstantCollection"/>
    /// </summary>
    public static class BetanoConstantCollection
    {
        /// <summary>
        /// Gets the betano body x path.
        /// </summary>
        /// <value>The betano body x path.</value>
        public static BetanoConstant BetanoBodyXPath => new("//body");

        /// <summary>
        /// The betano current wanted odds
        /// </summary>
        public static BetanoConstant BetanoCurrentWantedOdds => new("Resultado Final");
    }
}