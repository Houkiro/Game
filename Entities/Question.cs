using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Question
    {
        [Column("QuestionId")]
        public Guid Id { get; set; }
        public string? Text { get; set; }
        public string? MediaType { get; set; }
        public byte[]? MediaContent {  get; set; }
    }
}
