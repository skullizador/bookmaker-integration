// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardResponseVersionInfoModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardResponseVersionInfoModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Response
{
    /// <summary>
    /// <see cref="PlacardResponseVersionInfoModel"/>
    /// </summary>
    public class PlacardResponseVersionInfoModel
    {
        /// <summary>
        /// Gets a value indicating whether this instance has API version changed.
        /// </summary>
        /// <value><c>true</c> if this instance has API version changed; otherwise, <c>false</c>.</value>
        public bool HasApiVersionChanged { get; init; }

        /// <summary>
        /// Gets a value indicating whether this instance has module version changed.
        /// </summary>
        /// <value><c>true</c> if this instance has module version changed; otherwise, <c>false</c>.</value>
        public bool HasModuleVersionChanged { get; init; }
    }
}