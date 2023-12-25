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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData
                (
                new Answer
                {
                    Id = new Guid("7fc9d268-89a3-4e6d-bbd7-5f0c6e872a9a"),
                    Text = "Сова",
                    UserId = new Guid("f2d1b0a4-76c5-11ec-87d0-0242ac130003"),
                    QuestionId = new Guid("C9D4C053-49B6-410C-BC78-2D54A9991870")
                },
                new Answer
                {
                    Id = new Guid("a0b5f6e7-cd23-4a89-b12d-98e97f561234"),
                    Text = "Юпитер",
                    UserId = new Guid("e5e3498b-48f0-4c12-a97e-f7baa9f0b6c7"),
                    QuestionId = new Guid("3D490A70-94CE-4D15-9494-5248280C2CE3")
                }
                );
        }
    }
}
