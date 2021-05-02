using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApricod.Model
{
    public class Game : ITableItem
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public List<string> Genres { get; set; }

        public Game(string name, string author, List<string> genres)
        {
            Name = name;
            Author = author;
            Genres = genres;
        }
    }
}
