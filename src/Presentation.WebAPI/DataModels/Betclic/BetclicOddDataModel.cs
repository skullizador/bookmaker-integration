// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic
{
    /// <summary>
    /// <see cref="BetclicOddDataModel"/>
    /// </summary>
    public class BetclicOddDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicOddDataModel"/> class.
        /// </summary>
        public BetclicOddDataModel()
        {
            this.TeamName = string.Empty;
        }

        /// <summary>
        /// Gets the odd value.
        /// </summary>
        /// <value>The odd value.</value>
        public decimal OddValue { get; init; }

        /// <summary>
        /// Gets the name of the team.
        /// </summary>
        /// <value>The name of the team.</value>
        public string TeamName { get; init; }
    }
}