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
    using BookmakerIntegration.Domain.DataModels.Bwin;
    using BookmakerIntegration.Domain.DataModels.CasinoPortugal;
    using BookmakerIntegration.Domain.DataModels.Placard.Request;
    using BookmakerIntegration.Domain.DataModels.Placard.Response;
    using BookmakerIntegration.Infrastructure.Gateway.WebGateway;
    using HtmlAgilityPack;
    using Newtonsoft.Json;

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
            string data = await this.webGateway.GetBetanoDataAsync(url, cancellationToken);

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
            string data = await this.webGateway.GetBetclicDataAsync(url, cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            BetclicCompetitionDataModel competition = BetclicCompetitionDataModel.DecodeHtml(page);

            return competition;
        }

        /// <summary>
        /// Collects the bwin data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<BwinJsonDataModel> CollectBwinDataAsync(string url, CancellationToken cancellationToken)
        {
            string data = await this.webGateway.GetBwinDataAsync(url, cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            return JsonConvert.DeserializeObject<BwinJsonDataModel>(page.DocumentNode.InnerHtml);
        }

        /// <summary>
        /// Collects the casino portugal data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<CasinoPortugalJsonDataModel> CollectCasinoPortugalDataAsync(string url, CancellationToken cancellationToken)
        {
            string data = await this.webGateway.GetCasinoPortugalDataAsync(url, cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            return JsonConvert.DeserializeObject<CasinoPortugalJsonDataModel>(page.DocumentNode.InnerHtml);
        }

        /// <summary>
        /// Collects the placard data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="body">The body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<PlacardResponseModel> CollectPlacardDataAsync(string url, PlacardRequestModel body, CancellationToken cancellationToken)
        {
            string data = await this.webGateway.GetPlacardDataAsync(url, JsonConvert.SerializeObject(body), cancellationToken);

            HtmlDocument page = new();

            page.LoadHtml(data);

            return JsonConvert.DeserializeObject<PlacardResponseModel>(page.DocumentNode.InnerHtml);
        }
    }
}