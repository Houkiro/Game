using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        { 
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges) => FindAll(trackChanges).OrderBy(u => u.Name).ToList();

        public User GetUser(Guid userId, bool trackChanges) => FindByCondition(u => u.Id.Equals(userId), trackChanges).SingleOrDefault();
    }
}
