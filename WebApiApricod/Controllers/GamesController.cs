using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiApricod.Model;
using WebApiApricod.View;

namespace WebApiApricod.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {

        private IRepository _repo;
        private IView _view;

        public GamesController(IRepository repo, IView view)
        {
            _repo = repo;
            _view = view;
        }

        [HttpGet("read")]
        public string GetAllGames(int id)
        {
            var items = _repo.GetAllItems();
            return _view.ViewAllItems(items);
        }

        [HttpGet("read/{value}")]
        public string GetAllGames(string value)
        {
            var items = _repo.GetByParameter(value);
            return _view.ViewAllItems(items);
        }

        [HttpPost("create")]
        public void CreateGame(string name, string author, string genres)
        {
            var params_ = new List<string> {name, author, genres};
            var item = _repo.GenerateFromList(params_);
            _repo.CreateItem(item);
        }

        [HttpPost("delete/{id}")]
        public void DeleteGame(long id)
        {
            _repo.DeleteItem(id);
        }

        [HttpPost("update/name/{id}")]
        public void UpdateGameName(long id, string name)
        {
            _repo.UpdateItem(id, name, "name");
        }

        [HttpPost("update/author/{id}")]
        public void UpdateGameAuthor(long id, string author)
        {
            _repo.UpdateItem(id, author, "author");
        }

        [HttpPost("update/genres/{id}")]
        public void UpdateGameGenres(long id, string genres)
        {
            _repo.UpdateItem(id, genres, "genres");
        }
    }
}
