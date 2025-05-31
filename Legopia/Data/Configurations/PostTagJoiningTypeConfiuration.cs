using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Legopia.Data.Configurations
{
    public class PostTagJoiningTypeConfiuration : IEntityTypeConfiguration<PostTagJoining>
    {
        public void Configure(EntityTypeBuilder<PostTagJoining> builder)
        {
            builder.HasKey(x => new { x.PostId, x.TagId });
        }
    }
}
