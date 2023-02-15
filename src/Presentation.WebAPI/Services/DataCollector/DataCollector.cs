// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataCollector.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DataCollector
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.Services.DataCollector
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betano;
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic;
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic.ConstantCollection;
    using HtmlAgilityPack;
    using RestSharp;

    /// <summary>
    /// <see cref="DataCollector"/>
    /// </summary>
    /// <seealso cref="IDataCollector"/>
    public class DataCollector : IDataCollector
    {
        /// <summary>
        /// Collects the betano data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<BetanoJsonDataModel> CollectBetanoDataAsync(string url, CancellationToken cancellationToken)
        {
            string data = await GetDataAsync(url, cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            return BetanoJsonDataModel.DecodeHtml(page);
        }

        /// <summary>
        /// Collects the betclic data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<BetclicCompetitionDataModel> CollectBetclicDataAsync(string url, CancellationToken cancellationToken)
        {
            string data = await GetDataAsync(url, cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            BetclicCompetitionDataModel competition = BetclicCompetitionDataModel.DecodeHtml(page);

            return competition;
        }

        /// <summary>
        /// Gets the data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        private static async Task<string> GetDataAsync(string url, CancellationToken cancellationToken)
        {
            RestClient client = new(url);

            RestRequest request = new(url, Method.Get);

            request.AddHeader("postman-token", "dcf8a6ac-80a7-b255-1494-f5bfae5d04b8");
            request.AddHeader("cache-control", "no-cache");

            RestResponse response = await client.ExecuteAsync(request, cancellationToken);

            return response.Content;
        }
    }
}