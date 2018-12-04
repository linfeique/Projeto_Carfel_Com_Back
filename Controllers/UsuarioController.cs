using System;
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
                senha: form["senha"],
                email: form["email"] 
            );
            
            UsuarioModel usuario = UsuarioRepositorio.BuscarEmailSenha(usuarioModel.Email, usuarioModel.Senha);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                HttpContext.Session.SetString("tipoUsuario", usuario.Tipo.ToString());

<<<<<<< HEAD
                if(HttpContext.Session.GetString("tipoUsuario") != "comum"){
                    // return RedirectToAction("Comentar", "Comentario");
                    return RedirectToAction("", "");
                } else{
                    // return RedirectToAction("Avaliar", "Comentario");
                    return RedirectToAction("", "");
                }
                
=======
                return RedirectToAction("Cometar", "Comentario");
>>>>>>> 80754a9ef13e3b31921480b933bee5108c855348
            } else{
                ViewBag.Mensagem = "Email ou senha estão incorretos";
            }

            return View();
        }
    }
}