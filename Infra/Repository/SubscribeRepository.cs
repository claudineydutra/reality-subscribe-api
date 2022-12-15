using Infra.DBConfiguration.EFCore;
using Microsoft.EntityFrameworkCore;
using reality_subscribe_api.Model;

namespace Infra.Repository
{
    public class SubscribeRepository : ARepository<Subscribe>
    {
        public SubscribeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
