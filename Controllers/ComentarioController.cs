using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Senai.Projeto.Carfel.Controllers
{
    public class ComentarioController : Controller
    {
        [HttpGet]
        public IActionResult Comentar(){
            return View();
        }

        [HttpPost]
        public IActionResult Comentar(IFormCollection form){
            return null;
        }
    }
}