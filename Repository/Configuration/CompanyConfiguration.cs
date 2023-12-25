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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData
                (
                    new Question
                    {
                        Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        Text = "Какое животное является символом мудрости в многих культурах и философии Востока?"
                    },
                    new Question
                    {
                        Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                        Text = "Как называется наибольшая планета в Солнечной системе?"
                    }
            );
        }
    }
}
