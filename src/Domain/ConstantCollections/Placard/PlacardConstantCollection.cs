// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardConstantCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.Placard
{
    /// <summary>
    /// <see cref="PlacardConstantCollection"/>
    /// </summary>
    public static class PlacardConstantCollection
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        /// <value>The API version.</value>
        public static PlacardConstant ApiVersion => new("apiVersion", "+CXbYZ1y22VBdCuen25vAg");

        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public static PlacardConstant BookmakerId => new(null, string.Empty);

        /// <summary>
        /// Gets the current football league.
        /// </summary>
        /// <value>The current football league.</value>
        public static PlacardConstant CurrentFootballLeague => new(null, "Primeira Liga");

        /// <summary>
        /// Gets the current football league region.
        /// </summary>
        /// <value>The current football league region.</value>
        public static PlacardConstant CurrentFootballLeagueRegion => new(null, "Portugal");

        /// <summary>
        /// Gets the module version.
        /// </summary>
        /// <value>The module version.</value>
        public static PlacardConstant ModuleVersion => new("moduleVersion", "xZ7ndd+e16MkGvtoGztwxA");

        /// <summary>
        /// Gets the name of the request view.
        /// </summary>
        /// <value>The name of the request view.</value>
        public static PlacardConstant RequestViewName => new("viewName", "Events.Events");

        /// <summary>
        /// Gets the request XCSRF token header.
        /// </summary>
        /// <value>The request XCSRF token header.</value>
        public static PlacardConstant RequestXCSRFTokenHeader => new("x-csrftoken", "T6C+9iB49TLra4jEsMeSckDMNhQ=");
    }
}