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
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="DataCollector"/>
    /// </summary>
    /// <seealso cref="IDataCollector"/>
    public class DataCollector : IDataCollector
    {
        /// <summary>
        /// The betano script data index
        /// </summary>
        private const int BetanoScriptDataIndex = 1;

        /// <summary>
        /// The web
        /// </summary>
        private readonly HtmlWeb web;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollector"/> class.
        /// </summary>
        public DataCollector()
        {
            this.web = new HtmlWeb();
        }

        /// <summary>
        /// Collects the betano data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<string> CollectBetanoDataAsync(string url, CancellationToken cancellationToken)
        {
            HtmlDocument page = await this.web.LoadFromWebAsync(url);

            HtmlDocument htmlCode = new();

            htmlCode.LoadHtml(page.DocumentNode.ChildNodes["html"].InnerHtml);

            HtmlDocument body = new();

            body.LoadHtml(htmlCode.DocumentNode.ChildNodes["body"].InnerHtml);

            return body.DocumentNode.ChildNodes[BetanoScriptDataIndex].InnerHtml;
        }

        public Task<string> CollectBetclicDataAsync(string url, CancellationToken cancellationToken)
        {
            HtmlDocument page = this.web.Load(url);

            HtmlDocument htmlCode = new();

            htmlCode.LoadHtml(page.DocumentNode.ChildNodes["html"].InnerHtml);

            HtmlDocument body = new();

            body.LoadHtml(htmlCode.DocumentNode.ChildNodes["body"].InnerHtml);

            return Task.FromResult("");
        }
    }
}