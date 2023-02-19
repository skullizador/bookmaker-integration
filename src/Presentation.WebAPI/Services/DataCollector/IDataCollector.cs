// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataCollector.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IDataCollector
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Services.DataCollector
{
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Domain.DataModels.Placard.Request;
    using BookmakerIntegration.Domain.DataModels.Placard.Response;

    /// <summary>
    /// IDataCollector
    /// </summary>
    public interface IDataCollector
    {
        /// <summary>
        /// Collects the betano data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<BetanoJsonDataModel> CollectBetanoDataAsync(string url, CancellationToken cancellationToken);

        /// <summary>
        /// Collects the betclic data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<BetclicCompetitionDataModel> CollectBetclicDataAsync(string url, CancellationToken cancellationToken);

        /// <summary>
        /// Collects the placard data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="body">The body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<PlacardResponseModel> CollectPlacardDataAsync(string url, PlacardRequestModel body, CancellationToken cancellationToken);

        Task<string> CollectSolVerdeDataAsync(string url, CancellationToken cancellationToken);
    }
}