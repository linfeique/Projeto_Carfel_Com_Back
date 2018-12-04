using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.Models;
using System.Collections.Generic;
using System.IO;
using Senai.Projeto.Carfel.Repositorios;

namespace Senai.Projeto.Carfel.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }
        
        [HttpGet]
        public ActionResult Cadastro(){
            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastro(IFormCollection form){
            
            UsuarioModel usuarioModel = new UsuarioModel(form["nome"], form["email"], form["senha"]);

            UsuarioRepositorio usuarioRap = new UsuarioRepositorio();
            usuarioRap.Cadastrar(usuarioModel);

            return RedirectToAction("Login", "Usuario");
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(IFormCollection form){
            
            UsuarioModel usuarioModel = new UsuarioModel(
                form["email"], 
                form["senha"]
            );

            UsuarioRepositorio usuarioRap = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRap.BuscarEmailSenha(usuarioModel.Email, usuarioModel.Senha);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuarioModel.Email.ToString());

                return RedirectToAction("Cometar", "Comentario");
            } else{
                ViewBag.Mensagem = "Email ou senha estão incorretos";
            }

            return View();
        }
    }
}