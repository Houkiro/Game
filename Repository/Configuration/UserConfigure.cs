using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = new Guid("f2d1b0a4-76c5-11ec-87d0-0242ac130003"),
                    Name = "Houkiro"
                },
                new User
                {
                    Id = new Guid("e5e3498b-48f0-4c12-a97e-f7baa9f0b6c7"),
                    Name = "ChatGPT"
                }
            );
        }
    }
}
