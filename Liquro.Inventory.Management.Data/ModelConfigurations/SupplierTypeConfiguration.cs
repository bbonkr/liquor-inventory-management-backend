using System;
using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class SupplierTypeConfiguration : IdentifierEntityTypeConfiguration<Supplier>
    {
        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.NameOfCompany)
                .IsRequired()
                .HasMaxLength(VarcharLength.Name)
                .HasComment("업체명")
                ;
            builder
                .Property(x => x.Phone)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Phone)
                .HasComment("전화번호")
                ;
            builder
                .Property(x => x.Mobile)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Phone)
                .HasComment("휴대전화번호")
                ;
            builder
                .Property(x => x.Email)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Email)
                .HasComment("전자우편번호")
                ;
            builder
                .Property(x => x.BusinessRegistrationNumber)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.RegistrationNumber)
                .HasComment("사업자등록번호")
                ;
            builder
                .Property(x => x.CorporationRegistrationNumber)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.CorporationRegistrationNumber)
                .HasComment("법인등록번호")
                ;
            builder
                .Property(x => x.BusinessType)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("업태")
                ;
            builder
                .Property(x => x.BusinessItem)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("업종")
                ;

            builder
                .Property(x => x.BusinessZipcode)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Zipcode)
                .HasComment("사업장주소 우편번호")
                ;
            builder
                .Property(x => x.BusinessAddress)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Address)
                .HasComment("사업장 주소")
                ;
            builder
                .Property(x => x.BusinessAddressDetail)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Address)
                .HasComment("사업장 주소 상세")
                ;
            builder
                .Property(x => x.RepresentativeName)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Name)
                .HasComment("대표자 이름")
                ;
            builder
                .Property(x => x.Note)
                .IsRequired(false)
                .HasMaxLength(VarcharLength.Note)
                .HasComment("기록사항")
                ;

        }
    }
}
