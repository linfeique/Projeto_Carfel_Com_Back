using System;
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
            UsuarioModel usuarioModel = new UsuarioModel();

            ComentarioModel comentario = new ComentarioModel(
                conteudo: form["conteudo"],
                nome: usuarioModel.Nome,
                dataCriacao: DateTime.Now
            );

            return null;
        }
    }
}