using System;
using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class AlcoholSupplierTypeConfiguration : IdentifierEntityTypeConfiguration<AlcoholSupplier>
    {
        public override void Configure(EntityTypeBuilder<AlcoholSupplier> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.AlcoholId)
                .IsRequired()
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("주류 식별자")
                ;
            builder.Property(x => x.SupplierId)
                .IsRequired()
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("공급자 식별자")
                ;

            builder.Property(x => x.UnitPrice)
                .IsRequired(true)
                .HasDefaultValue(0)
                .HasComment("단위 가격")
                ;
            builder.Property(x => x.Note)
                .IsRequired(false)
                .HasComment("기록사항")
                ;

            // TODO: FK
        }
    }
}
