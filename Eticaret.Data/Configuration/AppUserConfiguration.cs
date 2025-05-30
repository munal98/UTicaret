﻿using Eticaret.Data.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().
            HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().
           HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().
           HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).
           HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.PasswordHash).IsRequired().
           HasColumnType("nvarchar(15)").HasMaxLength(15);
            builder.Property(x => x.UserName).
           HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    Id=1,
                    UserName="Admin",
                    Email="admin@eticaret.com",
                    IsActive=true,
                    IsAdmin=true,
                    Name="Mert",
                    SurName="Ünal",
                    PasswordHash="123456*",
                }
                );
        }
    }
}
