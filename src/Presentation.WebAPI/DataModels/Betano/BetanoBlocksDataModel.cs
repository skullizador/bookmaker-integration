// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoBlocksDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoBlocksDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betano
{
    /// <summary>
    /// <see cref="BetanoBlocksDataModel"/>
    /// </summary>
    public class BetanoBlocksDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoBlocksDataModel"/> class.
        /// </summary>
        public BetanoBlocksDataModel()
        {
            this.Id = string.Empty;
            this.Name = string.Empty;
            this.ShortName = string.Empty;
            this.Url = string.Empty;
            this.Events = new List<BetanoGameDataModel>();
        }

        /// <summary>
        /// Gets the events.
        /// </summary>
        /// <value>The events.</value>
        public List<BetanoGameDataModel> Events { get; init; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; init; }

        /// <summary>
        /// Gets the layout.
        /// </summary>
        /// <value>The layout.</value>
        public int Layout { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; init; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; init; }
    }
}