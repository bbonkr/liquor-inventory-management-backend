using System;
using System.Collections.Generic;
using System.Text;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liquro.Inventory.Management.Data.ModelConfigurations
{
    internal class UserTypeConfiguration:EntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasComment("사용자");

            builder.Property(x => x.UserName)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired()
                .HasComment("사용자 계정 이름")
                ;
            builder.Property(x => x.LastName)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired()
                .HasComment("성")
                ;
            builder.Property(x => x.FirstName)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired()
                .HasComment("이름")
                ;
            builder.Property(x => x.DisplayName)
                .HasMaxLength(VarcharLength.Name)
                .IsRequired()
                .HasComment("이름")
                ;
            builder.Property(x => x.Password)
                .HasMaxLength(VarcharLength.Note)
                .IsRequired()
                .HasComment("비밀번호")
                ;
            builder.Property(x => x.Email)
                .HasMaxLength(VarcharLength.Email)
                .IsRequired()
                .HasComment("전자우편주소")
                ;
            builder.Property(x => x.FailCount)
                .HasDefaultValue(0)
                .IsRequired()
                .HasComment("로그인 실패 횟수")
                ;
            builder.Property(x => x.IsEnabled)
                .HasDefaultValue(true)
                .IsRequired()
                .HasComment("사용여부")
                ;
            builder.Property(x => x.RecentlySignIn)
                .IsRequired(false)
                .HasComment("최근 로그인 시각")
                ;
        }
    }
}
