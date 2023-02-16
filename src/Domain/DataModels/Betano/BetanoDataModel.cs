// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Betano
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="BetanoDataModel"/>
    /// </summary>
    public class BetanoDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoDataModel"/> class.
        /// </summary>
        public BetanoDataModel()
        {
            this.Blocks = new();
        }

        /// <summary>
        /// Gets the blocks.
        /// </summary>
        /// <value>The blocks.</value>
        public List<BetanoBlocksDataModel> Blocks { get; set; }
    }
}