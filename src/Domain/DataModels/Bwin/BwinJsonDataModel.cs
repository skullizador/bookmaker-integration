// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinJsonDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinJsonDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Bwin
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BwinJsonDataModel"/>
    /// </summary>
    public class BwinJsonDataModel
    {
        /// <summary>
        /// Gets the widgets.
        /// </summary>
        /// <value>The widgets.</value>
        public List<BwinWidgetDataModel> widgets { get; init; }
    }
}