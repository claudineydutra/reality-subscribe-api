using Infra.DBConfiguration.EFCore;
using Microsoft.EntityFrameworkCore;
using reality_subscribe_api.Model;

namespace Infra.Repository
{
    public class UserRepository : ARepository<User>
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
