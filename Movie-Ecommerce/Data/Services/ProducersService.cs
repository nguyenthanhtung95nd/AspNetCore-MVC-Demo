using Movie_Ecommerce.Data.Base;
using Movie_Ecommerce.Models;

namespace Movie_Ecommerce.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
