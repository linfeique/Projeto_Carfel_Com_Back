<<<<<<< HEAD
=======
using System;
>>>>>>> 80754a9ef13e3b31921480b933bee5108c855348
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.Models;

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
<<<<<<< HEAD
=======
            UsuarioModel usuarioModel = new UsuarioModel();

            ComentarioModel comentario = new ComentarioModel(
                conteudo: form["conteudo"],
                nome: usuarioModel.Nome,
                dataCriacao: DateTime.Now
            );

>>>>>>> 80754a9ef13e3b31921480b933bee5108c855348
            return null;
        }
    }
}