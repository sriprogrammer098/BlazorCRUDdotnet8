using BlazorCRUDdotnet8.Shared.Data;
using BlazorCRUDdotnet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDdotnet8.Shared.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        Task<Game> AddGame(Game game);
        Task<Game> EditGame(int id, Game game);
        Task<bool> DeleteGame(int id);

    }
}
