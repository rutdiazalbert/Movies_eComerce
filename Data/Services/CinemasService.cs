using Movies_eCommerce.Data.Base;
using Movies_eCommerce.Models;

namespace Movies_eCommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
