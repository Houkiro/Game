using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAnswers(Guid questionId, bool trackChanges);
        Answer GetAnswer(Guid questionId, Guid id, bool trackChanges);
    }
}
