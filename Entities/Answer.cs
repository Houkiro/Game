using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Answer
    {
        [Column("AnswerId")]
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string? Text { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
