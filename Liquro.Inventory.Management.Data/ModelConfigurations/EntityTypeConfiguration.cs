using System;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class EntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .Property(x => x.CreatedAt)
                .HasDefaultValue(DateTimeOffset.UtcNow)
                .HasComment("입력시각");
            builder
                .Property(x => x.UpdatedAt)
                .HasDefaultValue(DateTimeOffset.UtcNow)
                .HasComment("갱신시각");

            builder
                .Property(x => x.CreatedBy)
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("입력 사용자 식별자");
            builder
                .Property(x => x.UpdatedBy)
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("갱신 사용자 식별자");
        }
    }
}
