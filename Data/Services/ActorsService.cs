using Microsoft.EntityFrameworkCore;
using Movies_eCommerce.Data.Base;
using Movies_eCommerce.Models;

namespace Movies_eCommerce.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
