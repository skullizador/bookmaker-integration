// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardRequestModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardRequestModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Request
{
    using BookmakerIntegration.Domain.ConstantCollections.Placard;

    /// <summary>
    /// <see cref="PlacardRequestModel"/>
    /// </summary>
    public class PlacardRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacardRequestModel"/> class.
        /// </summary>
        /// <param name="variables">The variables.</param>
        public PlacardRequestModel(PlacardVariablesModel variables)
        {
            this.versionInfo = new();
            this.screenData = new(variables);
        }

        /// <summary>
        /// Gets the screen data.
        /// </summary>
        /// <value>The screen data.</value>
        public PlacardScreenDataModel screenData { get; init; }

        /// <summary>
        /// Gets the version information.
        /// </summary>
        /// <value>The version information.</value>
        public PlacardRequestVersionInfoModel versionInfo { get; init; }

        /// <summary>
        /// Gets the name of the view.
        /// </summary>
        /// <value>The name of the view.</value>
        public string viewName => PlacardConstantCollection.RequestViewName.Value;
    }
}