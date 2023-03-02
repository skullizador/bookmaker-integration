// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalMarketsDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalMarketsDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.CasinoPortugal
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="CasinoPortugalMarketsDataModel"/>
    /// </summary>
    public class CasinoPortugalMarketsDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoPortugalMarketsDataModel"/> class.
        /// </summary>
        public CasinoPortugalMarketsDataModel()
        {
            this.name = string.Empty;
            this.selections = new List<CasinoPortugalOddDataModel>();
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; init; }

        /// <summary>
        /// Gets the selection.
        /// </summary>
        /// <value>The selection.</value>
        public List<CasinoPortugalOddDataModel> selections { get; init; }
    }
}