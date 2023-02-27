// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlacardEventModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// PlacardEventModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Placard.Response
{
    using System;

    /// <summary>
    /// <see cref="PlacardEventModel"/>
    /// </summary>
    public class PlacardEventModel
    {
        /// <summary>
        /// Gets the active program identifier.
        /// </summary>
        /// <value>The active program identifier.</value>
        public string ActiveProgramId { get; init; }

        /// <summary>
        /// Gets the away opponent.
        /// </summary>
        /// <value>The away opponent.</value>
        public string AwayOpponent { get; init; }

        /// <summary>
        /// Gets the away opponent identifier.
        /// </summary>
        /// <value>The away opponent identifier.</value>
        public string AwayOpponentId { get; init; }

        /// <summary>
        /// Gets a value indicating whether [away opponent is favorite].
        /// </summary>
        /// <value><c>true</c> if [away opponent is favorite]; otherwise, <c>false</c>.</value>
        public bool AwayOpponentIsFavorite { get; init; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code { get; init; }

        /// <summary>
        /// Gets the count event open markets.
        /// </summary>
        /// <value>The count event open markets.</value>
        public int CountEventOpenMarkets { get; init; }

        /// <summary>
        /// Gets the count outcomes.
        /// </summary>
        /// <value>The count outcomes.</value>
        public int CountOutcomes { get; init; }

        /// <summary>
        /// Gets the event external identifier.
        /// </summary>
        /// <value>The event external identifier.</value>
        public string EventExternalId { get; init; }

        /// <summary>
        /// Gets the event global identifier.
        /// </summary>
        /// <value>The event global identifier.</value>
        public string EventGlobalId { get; init; }

        /// <summary>
        /// Gets the event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        public string EventId { get; init; }

        /// <summary>
        /// Gets the event statistics identifier.
        /// </summary>
        /// <value>The event statistics identifier.</value>
        public string EventStatisticsId { get; init; }

        /// <summary>
        /// Gets the featured market type identifier.
        /// </summary>
        /// <value>The featured market type identifier.</value>
        public int FeaturedMarketTypeId { get; init; }

        /// <summary>
        /// Gets the home opponent.
        /// </summary>
        /// <value>The home opponent.</value>
        public string HomeOpponent { get; init; }

        /// <summary>
        /// Gets the home opponent identifier.
        /// </summary>
        /// <value>The home opponent identifier.</value>
        public string HomeOpponentId { get; init; }

        /// <summary>
        /// Gets a value indicating whether [home opponent is favorite].
        /// </summary>
        /// <value><c>true</c> if [home opponent is favorite]; otherwise, <c>false</c>.</value>
        public bool HomeOpponentIsFavorite { get; init; }

        /// <summary>
        /// Gets the market outcome1 code.
        /// </summary>
        /// <value>The market outcome1 code.</value>
        public string MarketOutcome1_Code { get; init; }

        /// <summary>
        /// Gets the market outcome1 description.
        /// </summary>
        /// <value>The market outcome1 description.</value>
        public string MarketOutcome1_Description { get; init; }

        /// <summary>
        /// Gets the market outcome1 evolution identifier.
        /// </summary>
        /// <value>The market outcome1 evolution identifier.</value>
        public string MarketOutcome1_EvolutionId { get; init; }

        /// <summary>
        /// Gets the market outcome1 global identifier.
        /// </summary>
        /// <value>The market outcome1 global identifier.</value>
        public string MarketOutcome1_GlobalId { get; init; }

        /// <summary>
        /// Gets the market outcome1 identifier.
        /// </summary>
        /// <value>The market outcome1 identifier.</value>
        public string MarketOutcome1_Id { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome1 is active].
        /// </summary>
        /// <value><c>true</c> if [market outcome1 is active]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome1_IsActive { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome1 is hidden].
        /// </summary>
        /// <value><c>true</c> if [market outcome1 is hidden]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome1_IsHidden { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome1 is suspended].
        /// </summary>
        /// <value><c>true</c> if [market outcome1 is suspended]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome1_IsSuspended { get; init; }

        /// <summary>
        /// Gets the market outcome1 price.
        /// </summary>
        /// <value>The market outcome1 price.</value>
        public string MarketOutcome1_Price { get; init; }

        /// <summary>
        /// Gets the market outcome2 code.
        /// </summary>
        /// <value>The market outcome2 code.</value>
        public string MarketOutcome2_Code { get; init; }

        /// <summary>
        /// Gets the market outcome2 description.
        /// </summary>
        /// <value>The market outcome2 description.</value>
        public string MarketOutcome2_Description { get; init; }

        /// <summary>
        /// Gets the market outcome2 evolution identifier.
        /// </summary>
        /// <value>The market outcome2 evolution identifier.</value>
        public string MarketOutcome2_EvolutionId { get; init; }

        /// <summary>
        /// Gets the market outcome2 global identifier.
        /// </summary>
        /// <value>The market outcome2 global identifier.</value>
        public string MarketOutcome2_GlobalId { get; init; }

        /// <summary>
        /// Gets the market outcome2 identifier.
        /// </summary>
        /// <value>The market outcome2 identifier.</value>
        public string MarketOutcome2_Id { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome2 is active].
        /// </summary>
        /// <value><c>true</c> if [market outcome2 is active]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome2_IsActive { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome2 is hidden].
        /// </summary>
        /// <value><c>true</c> if [market outcome2 is hidden]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome2_IsHidden { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome2 is suspended].
        /// </summary>
        /// <value><c>true</c> if [market outcome2 is suspended]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome2_IsSuspended { get; init; }

        /// <summary>
        /// Gets the market outcome2 price.
        /// </summary>
        /// <value>The market outcome2 price.</value>
        public string MarketOutcome2_Price { get; init; }

        /// <summary>
        /// Gets the market outcome3 code.
        /// </summary>
        /// <value>The market outcome3 code.</value>
        public string MarketOutcome3_Code { get; init; }

        /// <summary>
        /// Gets the market outcome3 description.
        /// </summary>
        /// <value>The market outcome3 description.</value>
        public string MarketOutcome3_Description { get; init; }

        /// <summary>
        /// Gets the market outcome3 evolution identifier.
        /// </summary>
        /// <value>The market outcome3 evolution identifier.</value>
        public string MarketOutcome3_EvolutionId { get; init; }

        /// <summary>
        /// Gets the market outcome3 global identifier.
        /// </summary>
        /// <value>The market outcome3 global identifier.</value>
        public string MarketOutcome3_GlobalId { get; init; }

        /// <summary>
        /// Gets the market outcome3 identifier.
        /// </summary>
        /// <value>The market outcome3 identifier.</value>
        public string MarketOutcome3_Id { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome3 is active].
        /// </summary>
        /// <value><c>true</c> if [market outcome3 is active]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome3_IsActive { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome3 is hidden].
        /// </summary>
        /// <value><c>true</c> if [market outcome3 is hidden]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome3_IsHidden { get; init; }

        /// <summary>
        /// Gets a value indicating whether [market outcome3 is suspended].
        /// </summary>
        /// <value><c>true</c> if [market outcome3 is suspended]; otherwise, <c>false</c>.</value>
        public bool MarketOutcome3_IsSuspended { get; init; }

        /// <summary>
        /// Gets the market outcome3 price.
        /// </summary>
        /// <value>The market outcome3 price.</value>
        public string MarketOutcome3_Price { get; init; }

        /// <summary>
        /// Gets the market retail sales close dt.
        /// </summary>
        /// <value>The market retail sales close dt.</value>
        public string MarketRetailSalesCloseDT { get; init; }

        /// <summary>
        /// Gets the modality identifier.
        /// </summary>
        /// <value>The modality identifier.</value>
        public string ModalityId { get; init; }

        /// <summary>
        /// Gets the modality label.
        /// </summary>
        /// <value>The modality label.</value>
        public string ModalityLabel { get; init; }

        /// <summary>
        /// Gets the start date time.
        /// </summary>
        /// <value>The start date time.</value>
        public DateTime StartDateTime { get; init; }

        /// <summary>
        /// Gets the tv channel.
        /// </summary>
        /// <value>The tv channel.</value>
        public string TVChannel { get; init; }
    }
}