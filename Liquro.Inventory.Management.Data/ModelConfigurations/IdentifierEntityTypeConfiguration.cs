
using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class IdentifierEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : BaseIdentifierModel
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasMaxLength(VarcharLength.Identifier)
                .IsRequired(true)
                .HasComment("식별자")
                ;
        }
    }
}
