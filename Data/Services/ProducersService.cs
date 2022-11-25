using Movies_eCommerce.Data.Base;
using Movies_eCommerce.Models;

namespace Movies_eCommerce.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
