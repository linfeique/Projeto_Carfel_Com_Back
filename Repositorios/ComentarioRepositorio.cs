using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Senai.Projeto.Carfel.Controllers;
using Senai.Projeto.Carfel.Models;

namespace Projeto_Carfel_Com_Back.Repositorios {
    public class ComentarioRepositorio {
        public ComentarioModel Comenta (ComentarioModel comentario) {

            if (File.Exists ("comentarios.csv")) {
                comentario.IdComentario = File.ReadAllLines ("comentarios.csv").Length + 1;
            } else {
                comentario.IdComentario = 1;
            }

            UsuarioController usuario = new UsuarioController ();
            string nomeUsuario = usuario.HttpContext.Session.GetString ("nomeUsuario");

            using (StreamWriter escrever = new StreamWriter ("comentario.csv", true)) {
                escrever.WriteLine ($"{comentario.IdComentario};{nomeUsuario};{comentario.Conteudo};{comentario.DataCriacao}");
            }

            return comentario;
        }
    }
}