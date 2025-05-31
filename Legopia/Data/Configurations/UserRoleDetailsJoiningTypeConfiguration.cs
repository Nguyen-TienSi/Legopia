using Legopia.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Legopia.Data.Configurations
{
    public class UserRoleDetailsJoiningTypeConfiguration : IEntityTypeConfiguration<UserRoleDetailsJoining>
    {
        public void Configure(EntityTypeBuilder<UserRoleDetailsJoining> builder)
        {
            builder.HasKey(x => new { x.UserDetailsId, x.UserRoleId });
        }
    }
}
