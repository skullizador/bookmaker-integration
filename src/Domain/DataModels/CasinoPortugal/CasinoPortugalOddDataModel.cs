// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CasinoPortugalOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CasinoPortugalOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.CasinoPortugal
{
    /// <summary>
    /// <see cref="CasinoPortugalOddDataModel"/>
    /// </summary>
    public class CasinoPortugalOddDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoPortugalOddDataModel"/> class.
        /// </summary>
        public CasinoPortugalOddDataModel()
        {
            this.selection_name = string.Empty;
        }

        /// <summary>
        /// Gets the decimal.
        /// </summary>
        /// <value>The decimal.</value>
        public decimal Decimal { get; init; }

        /// <summary>
        /// Gets the name of the selection.
        /// </summary>
        /// <value>The name of the selection.</value>
        public string selection_name { get; init; }
    }
}