using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class CommonCodeTypeConfiguration : IdentifierEntityTypeConfiguration<CommonCode>
    {
        public override void Configure(EntityTypeBuilder<CommonCode> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Code)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Code)
                .HasComment("코드")
                ;
            builder.Property(x => x.Text)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Name)
                .HasComment("문자열 값")
                ;
            builder.Property(x => x.Abbreviation)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Name)
                .HasComment("약어")
                ;
            builder.Property(x => x.Enabled)
                .IsRequired(true)
                .HasDefaultValue(true)
                .HasComment("사용여부")
                ;
            builder.Property(x => x.Ordinal)
                .IsRequired(true)
                .HasDefaultValue(1)
                .HasComment("출력순서")
                ;
            builder.Property(x => x.Note)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                ;
            builder.Property(x => x.GroupId)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("그룹 식별자")
                ;

            // TODO: FK
        }
    }
}
