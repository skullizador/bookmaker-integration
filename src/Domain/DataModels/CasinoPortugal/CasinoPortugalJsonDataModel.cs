// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalJsonDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalJsonDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.CasinoPortugal
{
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="CasinoPortugalJsonDataModel"/>
    /// </summary>
    public class CasinoPortugalJsonDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoPortugalJsonDataModel"/> class.
        /// </summary>
        public CasinoPortugalJsonDataModel()
        {
            this.fixtures = new List<CasinoPortugalFixtureDataModel>();
        }

        /// <summary>
        /// Gets the fixtures.
        /// </summary>
        /// <value>The fixtures.</value>
        public List<CasinoPortugalFixtureDataModel> fixtures { get; init; }
    }
}