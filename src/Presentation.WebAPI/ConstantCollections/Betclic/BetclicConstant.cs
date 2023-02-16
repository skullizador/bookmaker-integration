// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.ConstantCollections.Betclic
{
    using BookmakerIntegration.Presentation.WebAPI.Utils;

    /// <summary>
    /// <see cref="BetclicConstant"/>
    /// </summary>
    /// <seealso cref="ConstantObject"/>
    public class BetclicConstant : ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicConstant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public BetclicConstant(string name, string value)
            : base(value)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }
    }
}