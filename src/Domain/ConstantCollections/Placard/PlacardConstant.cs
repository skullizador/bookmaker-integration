// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardConstant.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.Placard
{
    using BookmakerIntegration.Domain.Utils;

    /// <summary>
    /// <see cref="PlacardConstant"/>
    /// </summary>
    /// <seealso cref="ConstantObject"/>
    public class PlacardConstant : ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacardConstant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public PlacardConstant(string name, string value)
            : base(value)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}