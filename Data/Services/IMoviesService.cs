using Movies_eCommerce.Data.Base;
using Movies_eCommerce.Data.ViewModels;
using Movies_eCommerce.Models;

namespace Movies_eCommerce.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
