// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardRequestVersionInfoModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardRequestVersionInfoModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Request
{
    using BookmakerIntegration.Domain.ConstantCollections.Placard;

    /// <summary>
    /// <see cref="PlacardRequestVersionInfoModel"/>
    /// </summary>
    public class PlacardRequestVersionInfoModel
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        /// <value>The API version.</value>
        public string apiVersion => PlacardConstantCollection.ApiVersion.Value;

        /// <summary>
        /// Gets the module version.
        /// </summary>
        /// <value>The module version.</value>
        public string moduleVersion => PlacardConstantCollection.ModuleVersion.Value;
    }
}