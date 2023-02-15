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
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic;

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
    }
}