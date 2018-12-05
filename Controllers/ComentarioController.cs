using System;
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

            UsuarioModel usuarioModel = new UsuarioModel ();
            ComentarioModel comentaModel = new ComentarioModel (
                conteudo: form["conteudo"],
                nome: form["nome"],
                dataCriacao: DateTime.Now
            );

            ComentarioRepositorio comentarioRap = new ComentarioRepositorio();
            comentarioRap.Comenta(comentaModel);

            return View();
        }
    }
}