// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitionEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CompetitionEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.EntityConfiguration
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="CompetitionEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Competition}"/>
    internal class CompetitionEntityTypeConfiguration : EntityTypeConfiguration<Competition>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Competition";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Competition> builder)
        {
            builder.Property(c => c.CompetitionId)
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.FinalUrl)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}