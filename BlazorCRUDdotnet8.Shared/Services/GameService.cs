using BlazorCRUDdotnet8.Shared.Data;
using BlazorCRUDdotnet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDdotnet8.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _dataContext;
        public GameService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Game> AddGame(Game game)
        {
            _dataContext.Games.Add(game);
            await _dataContext.SaveChangesAsync();
            return game;
        }

        public async Task<bool> DeleteGame(int id)
        {
            var dbGame = await _dataContext.Games.FindAsync(id);
            if (dbGame != null)
            {
                _dataContext.Remove(dbGame);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var dbGame = await _dataContext.Games.FindAsync(id);
            if (dbGame != null)
            {
                dbGame.Name = game.Name;
                await _dataContext.SaveChangesAsync();
                return dbGame;
            }
            throw new Exception("Game not found.");
        }

        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(1000);
            var games = await _dataContext.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _dataContext.Games.FindAsync(id);
        }
    }
}
