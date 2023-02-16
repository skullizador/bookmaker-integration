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
    using BookmakerIntegration.Domain.DataModels.Betano;
    using BookmakerIntegration.Domain.DataModels.Betclic;
    using BookmakerIntegration.Infrastructure.Gateway.WebGateway;
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="DataCollector"/>
    /// </summary>
    /// <seealso cref="IDataCollector"/>
    public class DataCollector : IDataCollector
    {
        /// <summary>
        /// The web gateway
        /// </summary>
        private readonly IWebGateway webGateway;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollector"/> class.
        /// </summary>
        /// <param name="webGateway">The web gateway.</param>
        public DataCollector(IWebGateway webGateway)
        {
            this.webGateway = webGateway;
        }

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

            //TODO: CHANGE THIS TO WORK ON MULTI BOOKMAKERS;
            request.AddHeader(BetclicConstantCollection.RequestPostmanTokenHeader.Name, BetclicConstantCollection.RequestPostmanTokenHeader.Value);
            request.AddHeader(BetclicConstantCollection.RequestCacheControlHeader.Name, BetclicConstantCollection.RequestCacheControlHeader.Value);

            RestResponse response = await client.ExecuteAsync(request, cancellationToken);

            return response.Content;
        }
    }
}