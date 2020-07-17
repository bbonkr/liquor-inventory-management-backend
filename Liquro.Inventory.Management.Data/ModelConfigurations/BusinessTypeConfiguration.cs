using System;
using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class BusinessTypeConfiguration : EntityTypeConfiguration<Business>
    {
        public override void Configure(EntityTypeBuilder<Business> builder)
        {
            base.Configure(builder);
            
            builder.HasComment("매장");

            builder.Property(x => x.Name)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired()
                .HasComment("명칭")
                ;

            builder.Property(x => x.IsEnabled)
                .HasDefaultValue(true)
                .IsRequired()
                .HasComment("사용여부")
                ;
        }
    }
}
