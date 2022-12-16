using Microsoft.EntityFrameworkCore;
using Models;

namespace Infra.Repository
{
    public class UserRepository : ARepository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
