using System;
using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class UserBusinessTypeConfiguration:EntityTypeConfiguration<UserBusiness>
    {
        public override void Configure(EntityTypeBuilder<UserBusiness> builder)
        {
            base.Configure(builder);

            builder.HasComment("사용자 매장");

            builder.Property(x => x.UserId)
                .HasMaxLength(VarcharLength.Identifier)
                .IsRequired()
                .HasComment("사용자 식별자")
                ;
            builder.Property(x => x.BusinessId)
                .HasMaxLength(VarcharLength.Identifier)
                .IsRequired()
                .HasComment("매장 식별자")
                ;

        }
    }
}
