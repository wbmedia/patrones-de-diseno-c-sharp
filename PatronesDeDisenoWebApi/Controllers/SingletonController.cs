using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PatronesDeDiseno.Singleton;
using PatronesDeDisenoWebApi.Configuration;

namespace PatronesDeDisenoWebApi.Controllers
{
    public class SingletonController : Controller
    {

        private readonly IOptions<MyConfig> _config;
        public SingletonController(IOptions<MyConfig> config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("entro a Index");
            return View();
        }
    }
}
