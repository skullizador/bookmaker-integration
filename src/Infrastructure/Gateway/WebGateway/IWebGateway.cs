// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebGateway.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IWebGateway
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Gateway.WebGateway
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IWebGateway"/>
    /// </summary>
    public interface IWebGateway
    {
        /// <summary>
        /// Gets the betano data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<string> GetBetanoDataAsync(string url, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the betclic data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<string> GetBetclicDataAsync(string url, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the placard data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="body">The body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<string> GetPlacardDataAsync(string url, string body, CancellationToken cancellationToken);
    }
}