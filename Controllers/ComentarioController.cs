using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Carfel_Com_Back.Repositorios;
using Senai.Projeto.Carfel.Interfaces;
using Senai.Projeto.Carfel.Models;
using Senai.Projeto.Carfel.Repositorios;

namespace Senai.Projeto.Carfel.Controllers {
    public class ComentarioController : Controller {

        public IComents ComentarioRepositorio {get; set;}

        // Se caso der merda é só colocar uppercase no C

        public ComentarioController(){
            ComentarioRepositorio = new ComentRapSerie();
        }

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

                ComentarioRepositorio.Comentar (comentario);

                ViewBag.Mensagem = "Comentário cadastrado com sucesso";
                return View ();
            } else {
                ViewBag.Mensagem = "nullzinho";
            }

            return RedirectToAction ("Login", "Usuario");
        }


        [HttpGet]
        public IActionResult Administrador(){
            ViewData["dados"] =  ComentarioRepositorio.Listar();
            return View();
        }


    }
}