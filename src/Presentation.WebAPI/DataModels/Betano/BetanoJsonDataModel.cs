// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoJsonDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoJsonDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betano
{
    /// <summary>
    /// <see cref="BetanoJsonDataModel"/>
    /// </summary>
    public class BetanoJsonDataModel
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>The data.</value>
        public BetanoDataModel Data { get; init; }
    }
}