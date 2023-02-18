// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardScreenDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardScreenDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Request
{
    /// <summary>
    /// <see cref="PlacardScreenDataModel"/>
    /// </summary>
    public class PlacardScreenDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacardScreenDataModel"/> class.
        /// </summary>
        /// <param name="variables">The variables.</param>
        public PlacardScreenDataModel(PlacardVariablesModel variables)
        {
            this.variables = variables;
        }

        /// <summary>
        /// Gets the variables.
        /// </summary>
        /// <value>The variables.</value>
        public PlacardVariablesModel variables { get; init; }
    }
}