// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Response
{
    /// <summary>
    /// <see cref="PlacardDataModel"/>
    /// </summary>
    public class PlacardDataModel
    {
        /// <summary>
        /// Gets the event data list.
        /// </summary>
        /// <value>The event data list.</value>
        public PlacardEventListModel EventDataList { get; init; }
    }
}