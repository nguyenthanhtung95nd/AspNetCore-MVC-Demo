using Movie_Ecommerce.Data.Base;
using Movie_Ecommerce.Data.ViewModels;
using Movie_Ecommerce.Models;
using System.Threading.Tasks;

namespace Movie_Ecommerce.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
