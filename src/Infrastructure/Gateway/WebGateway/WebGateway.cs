// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebGateway.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// WebGateway
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Gateway.WebGateway
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerIntegration.Domain.ConstantCollections.Betclic;
    using BookmakerIntegration.Domain.ConstantCollections.Placard;
    using RestSharp;

    /// <summary>
    /// <see cref="WebGateway"/>
    /// </summary>
    /// <seealso cref="IWebGateway"/>
    internal class WebGateway : IWebGateway
    {
        /// <summary>
        /// Gets the betano data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<string> GetBetanoDataAsync(string url, CancellationToken cancellationToken)
        {
            RestClient client = new(url);

            RestRequest request = new(url, Method.Get);

            RestResponse response = await client.ExecuteAsync(request, cancellationToken);

            return response.Content;
        }

        /// <summary>
        /// Gets the betclic data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<string> GetBetclicDataAsync(string url, CancellationToken cancellationToken)
        {
            RestClient client = new(url);

            RestRequest request = new(url, Method.Get);

            request.AddHeader(BetclicConstantCollection.RequestPostmanTokenHeader.Name, BetclicConstantCollection.RequestPostmanTokenHeader.Value);
            request.AddHeader(BetclicConstantCollection.RequestCacheControlHeader.Name, BetclicConstantCollection.RequestCacheControlHeader.Value);

            RestResponse response = await client.ExecuteAsync(request, cancellationToken);

            return response.Content;
        }

        /// <summary>
        /// Gets the placard data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="body">The body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<string> GetPlacardDataAsync(string url, string body, CancellationToken cancellationToken)
        {
            RestClient client = new(url);

            RestRequest request = new(url, Method.Post);

            request.AddBody(body);

            request.AddHeader(PlacardConstantCollection.RequestXCSRFTokenHeader.Name, PlacardConstantCollection.RequestXCSRFTokenHeader.Value);

            RestResponse response = await client.ExecuteAsync(request, cancellationToken);

            return response.Content;
        }
    }
}