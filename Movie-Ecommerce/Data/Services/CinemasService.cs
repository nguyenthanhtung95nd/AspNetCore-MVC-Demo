using Movie_Ecommerce.Data.Base;
using Movie_Ecommerce.Models;

namespace Movie_Ecommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
