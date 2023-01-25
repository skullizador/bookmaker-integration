// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerIntegration.Infrastructure.EntityConfiguration
{
    using BookmakerIntegration.Domain.AggregateModels.Bookmaker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// BookmakerEntityTypeConfiguration
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Bookmaker}"/>
    internal class BookmakerEntityTypeConfiguration : EntityTypeConfiguration<Bookmaker>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Bookmaker";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Bookmaker> builder)
        {
            builder.HasMany(b => b.Sports);

            builder.Property(b => b.BookmakerId)
                .IsRequired();

            builder.Property(b => b.BaseUrl)
                .IsRequired();
        }
    }
}