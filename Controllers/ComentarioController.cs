using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Carfel_Com_Back.Repositorios;
using Senai.Projeto.Carfel.Models;

namespace Senai.Projeto.Carfel.Controllers {
    public class ComentarioController : Controller {
        [HttpGet]
        public IActionResult Comentar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Comentar (IFormCollection form) {

            if (!string.IsNullOrEmpty (HttpContext.Session.GetString ("idUsuario"))) {
                ViewBag.Mensagem = "logadinho";
                ComentarioModel comentario = new ComentarioModel (
                    conteudo: form["conteudo"]
                );

                comentario.EmailUsuario = HttpContext.Session.GetString ("emailUsuario");

                ViewData["Usuarios"] = comentario;

                ComentarioRepositorio comentarioRap = new ComentarioRepositorio ();
                comentarioRap.Comentar (comentario);

                ViewBag.Mensagem = "Comentário cadastrado com sucesso";
                return View ();
            } else {
                ViewBag.Mensagem = "nullzinho";
            }

            return RedirectToAction ("Login", "Usuario");
        }
    }
}