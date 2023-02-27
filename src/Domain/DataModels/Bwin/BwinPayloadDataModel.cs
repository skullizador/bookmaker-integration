// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinPayloadDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinPayloadDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BwinPayloadDataModel"/>
    /// </summary>
    public class BwinPayloadDataModel
    {
        /// <summary>
        /// Gets the fixtures.
        /// </summary>
        /// <value>The fixtures.</value>
        public List<BwinGameDataModel> fixtures { get; init; }
    }
}