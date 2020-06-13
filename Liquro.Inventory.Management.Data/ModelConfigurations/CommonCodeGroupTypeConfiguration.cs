
using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class CommonCodeGroupTypeConfiguration : IdentifierEntityTypeConfiguration<CommonCodeGroup>
    {
        public override void Configure(EntityTypeBuilder<CommonCodeGroup> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Group)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Name)
                .HasComment("그룹 코드");
            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Title)
                .HasComment("그룹 명칭");
            builder.Property(x => x.Note)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("기록사항")
                ;

        }
    }
}
