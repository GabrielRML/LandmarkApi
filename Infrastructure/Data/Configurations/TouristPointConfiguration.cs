using LandmarkApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandmarkApi.Infrastructure.Data.Configurations;

public class TouristPointConfiguration : IEntityTypeConfiguration<TouristPoint>
{
    public void Configure(EntityTypeBuilder<TouristPoint> builder)
    {
        builder.ToTable("TouristPoints");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.Location)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(t => t.CityId)
            .IsRequired();

        builder.HasOne(t => t.City)
            .WithMany(c => c.TouristPoints)
            .HasForeignKey(t => t.CityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
