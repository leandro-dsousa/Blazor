using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorWebAssembly.Server.Domain.UserAccounts;

namespace BlazorWebAssembly.Server.Infraestructure.UserAccounts
{
    internal class UserAccountEntityTypeConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {

            builder.ToTable("userAccounts");

            builder.HasKey(b => b.accountId);

            builder.OwnsOne(b => b.userName).Property(b => b.username).IsRequired().HasColumnName("Username");

            builder.OwnsOne(b => b.password).Property(b => b.password).IsRequired().HasColumnName("Password"); 

            builder.OwnsOne(b => b.role).Property(b => b.name).IsRequired().HasColumnName("Role"); 

        }
    }
}
