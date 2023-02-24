// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinGameRegionDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinGameRegionDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    /// <summary>
    /// <see cref="BwinGameRegionDataModel"/>
    /// </summary>
    public class BwinGameRegionDataModel
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public BwinNameDataModel name { get; init; }
    }
}