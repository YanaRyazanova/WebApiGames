using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiApricod.Model;

namespace WebApiApricod.View
{
    public class ViewGames : IView
    {
        public string ViewAllItems(ICollection<ITableItem> items)
        {
            var res = new StringBuilder();
            foreach (var item in items)
            {
                var allGenres = new StringBuilder();
                var gameItem = (Game) item;
                foreach (var genre in gameItem.Genres)
                    allGenres.Append(genre + ", ");
                allGenres.Remove(allGenres.Length - 2, 2);
                res.Append($"ID:{gameItem.Id}, " +
                           $"Name:{gameItem.Name}, " +
                           $"Author:{gameItem.Author}, " +
                           $"Genres:{allGenres}" + 
                           "\n");
            }

            return res.ToString();
        }
    }
}
