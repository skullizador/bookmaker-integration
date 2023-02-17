// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardResponseModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardResponseModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Response
{
    /// <summary>
    /// <see cref="PlacardResponseModel"/>
    /// </summary>
    public class PlacardResponseModel
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>The data.</value>
        public PlacardDataModel Data { get; init; }

        /// <summary>
        /// Gets the roles information.
        /// </summary>
        /// <value>The roles information.</value>
        public string RolesInfo { get; init; }

        /// <summary>
        /// Gets the version information.
        /// </summary>
        /// <value>The version information.</value>
        public PlacardResponseVersionInfoModel VersionInfo { get; init; }
    }
}