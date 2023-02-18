// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Betano
{
    /// <summary>
    /// <see cref="BetanoOddDataModel"/>
    /// </summary>
    public class BetanoOddDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetanoOddDataModel"/> class.
        /// </summary>
        public BetanoOddDataModel()
        {
            this.BetRef = string.Empty;
            this.Id = string.Empty;
            this.FullName = string.Empty;
            this.Name = string.Empty;
            this.ShortName = string.Empty;
        }

        /// <summary>
        /// Gets the bet reference.
        /// </summary>
        /// <value>The bet reference.</value>
        public string BetRef { get; init; }

        /// <summary>
        /// Gets the index of the column.
        /// </summary>
        /// <value>The index of the column.</value>
        public int ColumnIndex { get; init; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName { get; init; }

        /// <summary>
        /// Gets the handicap.
        /// </summary>
        /// <value>The handicap.</value>
        public decimal Handicap { get; init; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>The price.</value>
        public decimal Price { get; init; }

        /// <summary>
        /// Gets the rendering layout.
        /// </summary>
        /// <value>The rendering layout.</value>
        public int RenderingLayout { get; init; }

        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <value>The short name.</value>
        public string ShortName { get; init; }
    }
}