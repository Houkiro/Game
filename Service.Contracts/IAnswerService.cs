using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IAnswerService
    {
        IEnumerable<AnswerDto> GetAnswers(Guid questionId, bool trackChanges);
        AnswerDto GetAnswer(Guid questionId, Guid id, bool trackChanges);
    }
}
