using System;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class OrderAlcoholTypeConfiguration : IdentifierEntityTypeConfiguration<OrderAlcohol>
    {
        public override void Configure(EntityTypeBuilder<OrderAlcohol> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.OrderDate)
                .IsRequired(true)
                .HasDefaultValue(DateTimeOffset.UtcNow)
                .HasComment("주문일자")
                ;
            //builder.Property(x => x.AlcoholId)
            //    .IsRequired(true)
            //    .HasMaxLength(VarcharLength.Id)
            //    .HasComment("주류 식별자");
            builder.Property(x => x.AlcoholSupplierId)
                .IsRequired()
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("주류-공급업체 식별자")
                ;
            builder.Property(x => x.Frequency)
                .IsRequired()
                .HasDefaultValue(0)
                .HasComment("도수")
                ;
            builder.Property(x => x.Volume)
                .IsRequired()
                .HasDefaultValue(0)
                .HasComment("용량")
                ;
            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasDefaultValue(0)
                .HasComment("수량")
                ;
            builder.Property(x => x.UnitPrice)
                .IsRequired()
                .HasDefaultValue(0)
                .HasComment("단위가격")
                ;
            //builder.Property(x => x.SupplierId)
            //    .IsRequired()
            //    .HasMaxLength(VarcharLength.Identifier)
            //    .HasComment("공급자 식별자")
            //    ;
            builder.Property(x => x.Amounts)
                .IsRequired()
                .HasDefaultValue(0)
                .HasComment("금액")
                ;
            builder.Property(x => x.PaymentId)
                .IsRequired()
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("지급방법코드 식별자")
                ;
            builder.Property(x => x.TaxBillId)
                .IsRequired()
                .HasMaxLength(VarcharLength.Identifier)
                .HasComment("세금계산서 구분 코드 식별자")
                ;
            builder.Property(x => x.Note)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("기록사항")
                ;

            // TODO: FK


        }
    }
}
