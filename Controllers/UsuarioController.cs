using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.Models;
using Senai.Projeto.Carfel.Repositorios;

namespace Senai.Projeto.Carfel.Controllers {
    public class UsuarioController : Controller {

        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpGet]
        public IActionResult Index_Logado () {
            return View ();
        }

        [HttpGet]
        public IActionResult Sair () {
            HttpContext.Session.Remove ("idUsuario");
            HttpContext.Session.Remove ("tipoUsuario");
            HttpContext.Session.Remove ("emailUsuario");

            return RedirectToAction ("Login", "Usuario");
        }

        [HttpGet]
        public IActionResult Cadastro () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {

            UsuarioModel usuarioModel = new UsuarioModel (form["nome"], form["email"], form["senha"]);
            HttpContext.Session.SetString ("emailUsuario", usuarioModel.Email);

            string teste = HttpContext.Session.GetString ("emailUsuario");

            using (StreamReader ler = new StreamReader ("comentario.csv")) {
                string leitura = ler.ReadToEnd ();
                if (leitura.Contains (teste)) {
                    ViewBag.Mensagem = "Esse usuário já existe";
                    return RedirectToAction ("Login", "Usuario");
                }
            }

            UsuarioRepositorio usuarioRap = new UsuarioRepositorio ();
            usuarioRap.Cadastrar (usuarioModel);

            return RedirectToAction ("Login", "Usuario");
        }

        [HttpGet]
        public IActionResult Login () => View ();

        [HttpPost]
        public IActionResult Login (IFormCollection form) {

            UsuarioModel usuarioModel = new UsuarioModel (
                senha: form["senha"],
                email: form["email"]
            );

            UsuarioModel usuario = UsuarioRepositorio.BuscarEmailSenha (usuarioModel.Email, usuarioModel.Senha);

            if (usuario != null) {
                HttpContext.Session.SetString ("idUsuario", usuario.Id.ToString ());
                HttpContext.Session.SetString ("tipoUsuario", usuario.Tipo.ToString ());
                HttpContext.Session.SetString ("emailUsuario", usuario.Email.ToString ());

                if (HttpContext.Session.GetString ("tipoUsuario") != "comum") {
                    // return RedirectToAction("Comentar", "Comentario");
                    return RedirectToAction ("Administrador", "Comentario");
                } else {
                    // return RedirectToAction("Avaliar", "Comentario");
                    return RedirectToAction ("Comentar", "Comentario");
                }

            } else {
                ViewBag.Mensagem = "Email ou senha estão incorretos";
            }

            return View ();
        }

        [HttpGet]
        public IActionResult CadastroAdmin () {
            return View ();
        }

        [HttpPost]
        public IActionResult CadastroAdmin (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel (form["nome"], form["email"], form["senha"], form["tipo"]);
            HttpContext.Session.SetString ("emailUsuario", usuarioModel.Email);

            string teste = HttpContext.Session.GetString ("emailUsuario");

            UsuarioRepositorio usuarioRap = new UsuarioRepositorio ();
            usuarioRap.CadastroAdmin (usuarioModel);

            return RedirectToAction ("Administrador", "Comentario");
        }
    }
}