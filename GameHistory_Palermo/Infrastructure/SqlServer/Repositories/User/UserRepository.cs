using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;
using NotImplementedException = System.NotImplementedException;

namespace Infrastructure.SqlServer.Repositories.User
{
    // TODO: complete the repo
    public class UserRepository : IUserRepository
    {
        public List<Domain.User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.User Create(Domain.User user)
        {
            throw new NotImplementedException();
        }
    }
}