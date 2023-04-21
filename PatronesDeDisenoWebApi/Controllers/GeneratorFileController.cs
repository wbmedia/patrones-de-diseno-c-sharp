using Microsoft.AspNetCore.Mvc;

namespace PatronesDeDisenoWebApi.Controllers
{
    public class GeneratorFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {

                return Json("Archivo Generado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
