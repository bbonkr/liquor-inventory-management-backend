using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class AlcoholTypeConfiguration : IdentifierEntityTypeConfiguration<Alcohol>
    {
        public override void Configure(EntityTypeBuilder<Alcohol> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired(true)
                .HasComment("명칭");
            builder.Property(x => x.KindsId)
                .HasMaxLength(VarcharLength.Identifier)
                .IsRequired(true)
                .HasComment("종류 식별자")
                ;
            builder.Property(x => x.Frequency)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasComment("도수")
                ;
            builder.Property(x => x.Volume)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasComment("용량")
                ;
            //builder.Property(x => x.UnitPrice)
            //    .IsRequired(true)
            //    .HasDefaultValue(0)
            //    .HasComment("단위 가격")
            //    ;
            //builder.Property(x => x.SupplierId)
            //    .IsRequired(true)
            //    .HasMaxLength(VarcharLength.Id)
            //    .HasComment("공급처 식별자")
            //    ;
            builder.Property(x => x.Note)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("비고")
                ;

            // TODO: FK
        }
    }
}
