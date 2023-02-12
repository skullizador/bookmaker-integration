// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetclicGameDataModel.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetclicGameDataModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Presentation.WebAPI.DataModels.Betclic
{
    using HtmlAgilityPack;

    /// <summary>
    /// <see cref="BetclicGameDataModel"/>
    /// </summary>
    public class BetclicGameDataModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetclicGameDataModel"/> class.
        /// </summary>
        public BetclicGameDataModel()
        {
            this.Name = string.Empty;
            this.Odds = new();
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<BetclicOddDataModel> Odds { get; init; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; init; }

        public static BetclicGameDataModel DecodeHtml(HtmlNode html, DateTime date)
        {
            HtmlNode scoreBoardNode = html.SelectSingleNode("//scoreboards-scoreboard-global/div");

            string teamAName = GetNodeValue(scoreBoardNode);

            string teamBName = GetNodeValue(scoreBoardNode);

            string gameHours = GetNodeValue(scoreBoardNode);

            //TODO: CHECK IF THIS WORKS;
            DateTime hours = Convert.ToDateTime(gameHours);

            DateTime startDate = date.AddTicks(hours.Ticks);

            return new BetclicGameDataModel
            {
                Name = $"{teamAName} - {teamBName}",
                StartDate = startDate
            };
        }

        /// <summary>
        /// Gets the node value.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        private static string GetNodeValue(HtmlNode node)
        {
            return node.SelectSingleNode("//div").InnerText;
        }
    }
}