using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ninject.Infrastructure.Language;

namespace WebApiApricod.Model
{
    public class GameRepository : IRepository
    {
        private DBAppContext context;

        public GameRepository([FromServices] DBAppContext context)
        {
            this.context = context;
        }

        public List<ITableItem> GetByParameter(string value)
        {
            var gamesWithGenre = context.Games
                .Where(x => x.Genres.Contains(value))
                .Select(x => (ITableItem) x)
                .ToList();
            return gamesWithGenre;
        }

        public ITableItem GenerateFromList(List<string> paramsList)
        {
            var name = paramsList[0];
            var author = paramsList[1];
            var genres = paramsList[2].Split(",").ToList();
            return new Game(name, author, genres);
        }

        public List<ITableItem> GetAllItems()
        { 
            var currentGames = context.Games.Select(x => (ITableItem) x).ToList();
            return currentGames;
        }

        public bool CreateItem(ITableItem currentGame)
        {
            if (currentGame is null)
                return false;
            context.Games.Add((Game)currentGame);
            context.SaveChanges();
            return true;
        }

        public bool DeleteItem(long id)
        {
            var currentGame = context.Games.FirstOrDefault(x => x.Id == id);
            if (currentGame is null)
                return false;
            context.Games.Remove(currentGame);
            context.SaveChanges();
            return true;
        }

        public bool UpdateItem(long id, string value, string fieldName)
        {
            var currentGame = context.Games.FirstOrDefault(x => x.Id == id);
            if (currentGame is null)
                return false;
            switch (fieldName)
            {
                case "name":
                    currentGame.Name = value;
                    break;
                case "author":
                    currentGame.Author = value;
                    break;
                case "genres":
                    currentGame.Genres = value.Split(",").ToList();
                    break;
            }
            context.SaveChanges();
            return true;
        }
    }
}
