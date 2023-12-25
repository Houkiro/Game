using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IQuestionService
    {
        IEnumerable<QuestionDto> GetAllQuestions(bool trackChanges);
        QuestionDto GetQuestion(Guid questionId, bool trackChanges);
    }
}
