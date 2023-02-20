// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebBrowserGateway.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IWebBrowserGateway
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Gateway.WebBrowserGateway
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IWebBrowserGateway"/>
    /// </summary>
    public interface IWebBrowserGateway
    {
        /// <summary>
        /// Requests the data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<string> RequestDataAsync(string url, CancellationToken cancellationToken);
    }
}