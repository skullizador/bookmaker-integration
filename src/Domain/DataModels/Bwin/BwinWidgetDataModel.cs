// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinWidgetDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinWidgetDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    /// <summary>
    /// <see cref="BwinWidgetDataModel"/>
    /// </summary>
    public class BwinWidgetDataModel
    {
        /// <summary>
        /// Gets the payload.
        /// </summary>
        /// <value>The payload.</value>
        public BwinPayloadDataModel payload { get; init; }

        /// <summary>
        /// Gets the name of the template.
        /// </summary>
        /// <value>The name of the template.</value>
        public string templateName { get; init; }
    }
}