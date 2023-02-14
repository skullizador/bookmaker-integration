// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicOddDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicOddDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic
{
    using BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic.ConstantCollection;
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="BetclicOddDataModel"/>
    /// </summary>
    public class BetclicOddDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicOddDataModel"/> class.
        /// </summary>
        public BetclicOddDataModel()
        {
            this.TeamName = string.Empty;
        }

        /// <summary>
        /// Gets the odd value.
        /// </summary>
        /// <value>The odd value.</value>
        public decimal OddValue { get; init; }

        /// <summary>
        /// Gets the name of the team.
        /// </summary>
        /// <value>The name of the team.</value>
        public string TeamName { get; init; }

        /// <summary>
        /// Decodes the HTML.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <returns></returns>
        public static BetclicOddDataModel DecodeHtml(HtmlNode html)
        {
            HtmlNode oddData = html.SelectSingleNode(BetclicConstantCollection.OddRootXPath.Value);

            string teamName = oddData.Attributes[BetclicConstantCollection.OddTeamNameAttributeName.Value].Value;

            string oddValue = oddData.ChildNodes
                .First(x => x.Attributes
                    .Any(a =>
                        a.Name == BetclicConstantCollection.OddOddValueAttributeName.Value &&
                        a.Value.Contains(BetclicConstantCollection.OddOddValueAttributeValuePortion.Value)))
                .InnerText;

            return new BetclicOddDataModel()
            {
                TeamName = ParseTeamName(teamName),
                OddValue = Convert.ToDecimal(oddValue)
            };
        }

        /// <summary>
        /// Parses the name of the team.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        private static string ParseTeamName(string name)
        {
            return name switch
            {
                "Empate" => "X",
                _ => name
            };
        }
    }
}