// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinGameSportDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinGameSportDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    /// <summary>
    /// <see cref="BwinGameSportDataModel"/>
    /// </summary>
    public class BwinGameSportDataModel
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public BwinNameDataModel name { get; init; }
    }
}