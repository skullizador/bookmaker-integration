// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebBrowserGateway.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// WebBrowserGateway
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.Gateway.WebBrowserGateway
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// <see cref="WebBrowserGateway"/>
    /// </summary>
    /// <seealso cref="IWebBrowserGateway"/>
    internal class WebBrowserGateway : IWebBrowserGateway
    {
        /// <summary>
        /// The HTML
        /// </summary>
        private string html;

        /// <summary>
        /// The web browser
        /// </summary>
        private WebBrowser webBrowser;

        /// <summary>
        /// Requests the data asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<string> RequestDataAsync(string url, CancellationToken cancellationToken)
        {
            this.ResetData();

            Uri uri = new(url);

            Thread thread = new(() => RunThread(uri));

            thread.SetApartmentState(ApartmentState.STA);

            thread.Start();

            return Task.FromResult(this.html);
        }

        /// <summary>
        /// Configures the WebBrowser.
        /// </summary>
        private void ConfigureWebBrowser()
        {
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.DocumentCompleted += RenderingCompleted;
        }

        /// <summary>
        /// Renderings the completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="WebBrowserDocumentCompletedEventArgs"/> instance containing the event data.
        /// </param>
        private void RenderingCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = (WebBrowser)sender;

            this.html = browser.DocumentText;

            if (browser.Url == e.Url)
            {
                Application.ExitThread();
            }
        }

        /// <summary>
        /// Resets the data.
        /// </summary>
        private void ResetData()
        {
            this.html = string.Empty;
        }

        /// <summary>
        /// Runs the thread asynchronous.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        private void RunThread(Uri uri)
        {
            this.webBrowser = new WebBrowser();

            this.ConfigureWebBrowser();

            this.webBrowser.Navigate(uri);
        }
    }
}