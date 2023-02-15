// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic.ConstantCollection
{
    /// <summary>
    /// <see cref="BetclicConstant"/>
    /// </summary>
    public class BetclicConstant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicConstant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public BetclicConstant(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; init; }
    }
}