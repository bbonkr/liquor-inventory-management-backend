
using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class LogTypeConfiguration : IdentifierEntityTypeConfiguration<Log>
    {
        public override void Configure(EntityTypeBuilder<Log> builder)
        {
            base.Configure(builder);

            builder.HasComment("로그");

            builder.Property(x => x.Level)
                .IsRequired(true)
                .HasMaxLength(VarcharLength.Name)
                .HasComment("로그 레벨")
                ;
            builder.Property(x => x.Message)
                .IsRequired(true)
                .HasComment("메시지")
                ;
            builder.Property(x => x.Detail)
                .IsRequired(false)
                .HasComment("상세 메시지")
                ;
            builder.Property(x => x.UserId)
                .IsRequired(false)
                .HasComment("사용자 식별자")
                ;

        }
    }
}
