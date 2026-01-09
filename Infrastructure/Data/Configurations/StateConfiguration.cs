using LandmarkApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LandmarkApi.Infrastructure.Data.Configurations;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Acronym)
            .IsRequired()
            .HasMaxLength(2);
        
        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(s => s.IbgeCode)
            .IsRequired()
            .HasMaxLength(2);
        
        builder.HasIndex(s => s.IbgeCode)
            .IsUnique();
        
        builder.HasIndex(s => s.Acronym)
            .IsUnique();
    }
}
