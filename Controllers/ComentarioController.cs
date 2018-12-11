using System;
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

                comentario.DataCriacao = DateTime.Now;

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
            ViewData["comentarios"] = ComentarioRepositorio.Listar().Where(x => !x.Aprovado).ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Aprovar(int id_aprova){
            ComentarioRepositorio.Aprovar(id_aprova);

            // if(HttpContext.Session.GetString("tipoUsuario") == "admin"){
            //     return RedirectToAction("Administrador", "Comentario");
            // }
            // return RedirectToAction("Login", "Usuario");
            return RedirectToAction("Administrador", "Comentario");
        }

        [HttpGet]
        public IActionResult Excluir(int id_reprova){
            ComentarioRepositorio.Excluir(id_reprova);

            // if(HttpContext.Session.GetString("tipoUsuario") == "admin"){
            //     return RedirectToAction("Administrador", "Comentario");
            // }
            // return RedirectToAction("Login", "Usuario");
            
            return RedirectToAction("Administrador", "Comentario");
        }

        [HttpGet]
        public IActionResult Comentarios_Aprovados(){
            ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();

            return View();
        }
    }
}