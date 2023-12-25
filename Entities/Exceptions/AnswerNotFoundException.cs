using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class AnswerNotFoundException : NotFoundException
    {
        public AnswerNotFoundException(Guid answerId) : base($"Answer with id: {answerId} doesn`t exist in the database.")
        {

        }
    }
}
