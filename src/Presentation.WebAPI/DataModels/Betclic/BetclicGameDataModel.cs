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
            this.TeamBName = string.Empty;
            this.TeamAName = string.Empty;
            this.Odds = new();
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>The odds.</value>
        public List<BetclicOddDataModel> Odds { get; private set; }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets the name of the team a.
        /// </summary>
        /// <value>The name of the team a.</value>
        public string TeamAName { get; private set; }

        /// <summary>
        /// Gets the name of the team b.
        /// </summary>
        /// <value>The name of the team b.</value>
        public string TeamBName { get; private set; }

        /// <summary>
        /// Decodes the HTML.
        /// </summary>
        /// <param name="html">The HTML.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static BetclicGameDataModel DecodeHtml(HtmlNode html, DateTime date)
        {
            HtmlNode scoreBoardNode = html.SelectSingleNode("a/div/scoreboards-scoreboard/scoreboards-scoreboard-global/div");

            string teamAName = GetNodeValue(scoreBoardNode, "scoreboard_contestant scoreboard_contestant-1");

            string teamBName = GetNodeValue(scoreBoardNode, "scoreboard_contestant scoreboard_contestant-2");

            string gameHours = GetNodeValue(scoreBoardNode, "scoreboard_info");

            DateTime hours = Convert.ToDateTime(gameHours);

            DateTime startDate = new DateTime(
                date.Year,
                date.Month,
                date.Day,
                hours.Hour,
                hours.Minute,
                hours.Second);

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
        /// <param name="attributeValuePortion">The attribute value portion.</param>
        /// <returns></returns>
        private static string GetNodeValue(HtmlNode node, string attributeValuePortion)
        {
            HtmlNode childNode = node.ChildNodes
                .SingleOrDefault(x => x.Attributes
                    .Any(f => f.Value
                        .Contains(attributeValuePortion)));

            return childNode.SelectSingleNode("div")
                .InnerText
                .TrimStart()
                .TrimEnd(); ;
        }
    }
}