// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetanoJsonDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetanoJsonDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Domain.DataModels.Betano
{
    using BookmakerIntegration.Domain.ConstantCollections.Betano;
    using HtmlAgilityPack;
    using Newtonsoft.Json;

    /// <summary>
    /// <see cref="BetanoJsonDataModel"/>
    /// </summary>
    public class BetanoJsonDataModel
    {
        /// <summary>
        /// The betano script data index
        /// </summary>
        private const int BetanoScriptDataIndex = 1;

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>The data.</value>
        public BetanoDataModel Data { get; init; }

        /// <summary>
        /// Decodes the HTML.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        public static BetanoJsonDataModel DecodeHtml(HtmlDocument html)
        {
            string data = html.DocumentNode.SelectSingleNode(BetanoConstantCollection.BetanoBodyXPath.Value)
                .ChildNodes[BetanoScriptDataIndex]
                .InnerHtml
                .Remove(0, 24);

            return JsonConvert.DeserializeObject<BetanoJsonDataModel>(data);
        }
    }
}