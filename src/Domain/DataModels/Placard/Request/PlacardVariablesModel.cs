// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardVariablesModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardVariablesModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Request
{
    /// <summary>
    /// <see cref="PlacardVariablesModel"/>
    /// </summary>
    public class PlacardVariablesModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacardVariablesModel"/> class.
        /// </summary>
        /// <param name="selectedCompetitionId">The selected competition identifier.</param>
        /// <param name="selectedDate">The selected date.</param>
        /// <param name="selectedModalityId">The selected modality identifier.</param>
        public PlacardVariablesModel(string selectedCompetitionId, string selectedDate, string selectedModalityId)
        {
            this.SelectedCompetitionId = selectedCompetitionId;
            this.SelectedDate = selectedDate;
            this.SelectedModalityId = selectedModalityId;
        }

        /// <summary>
        /// Gets the selected competition identifier.
        /// </summary>
        /// <value>The selected competition identifier.</value>
        public string SelectedCompetitionId { get; init; }

        /// <summary>
        /// Gets the selected date.
        /// </summary>
        /// <value>The selected date.</value>
        public string SelectedDate { get; init; }

        /// <summary>
        /// Gets the selected modality identifier.
        /// </summary>
        /// <value>The selected modality identifier.</value>
        public string SelectedModalityId { get; init; }
    }
}