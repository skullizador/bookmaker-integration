// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardEventListModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardEventListModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Response
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="PlacardEventListModel"/>
    /// </summary>
    public class PlacardEventListModel
    {
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <value>The list.</value>
        public List<PlacardEventModel> List { get; init; }
    }
}