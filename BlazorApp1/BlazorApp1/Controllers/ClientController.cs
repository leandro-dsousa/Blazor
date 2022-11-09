using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    public class ClientController : Controller
    {

        private readonly AppDbContext _db;


        public ClientController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objClientList = _db.Clients.ToList();
            return View();
        }

        public List<Client> GetClients() => _db.Clients.ToList();
    }
}
