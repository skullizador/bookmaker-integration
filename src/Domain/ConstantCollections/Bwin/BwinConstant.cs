// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BwinConstant.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BwinConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.ConstantCollections.Bwin
{
    using BookmakerIntegration.Domain.Utils;

    /// <summary>
    /// <see cref="BwinConstant"/>
    /// </summary>
    /// <seealso cref="ConstantObject"/>
    public class BwinConstant : ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BwinConstant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public BwinConstant(string name, string value)
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