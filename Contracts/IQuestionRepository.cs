using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAllQuestions(bool trackChanges);
        Question GetQuestion(Guid id, bool trackChanges);
    }
}
