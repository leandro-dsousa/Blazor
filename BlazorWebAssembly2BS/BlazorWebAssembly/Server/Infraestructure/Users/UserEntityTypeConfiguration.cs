using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorWebAssembly.Server.Domain.Users;

namespace BlazorWebAssembly.Server.Infraestructure.Users
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.UserId);

            builder.OwnsOne(b => b.Username);

            builder.OwnsOne(b => b.Password);

        }
    }
}
