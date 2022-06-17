using Movie_Ecommerce.Data.Base;
using Movie_Ecommerce.Models;

namespace Movie_Ecommerce.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        { 
        }

    }
}
