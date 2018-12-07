using System;
using System.IO;
using Senai.Projeto.Carfel.Controllers;
using Senai.Projeto.Carfel.Models;

namespace Projeto_Carfel_Com_Back.Repositorios {
    public class ComentarioRepositorio {
        public ComentarioModel Comentar (ComentarioModel comentario) {

            if (File.Exists ("comentario.csv")) {
                comentario.IdComentario = File.ReadAllLines ("comentario.csv").Length + 1;
            } else {
                comentario.IdComentario = 1;
            }

            comentario.DataCriacao = DateTime.Now;

            using (StreamWriter escrever = new StreamWriter ("comentario.csv", true)) {
                escrever.WriteLine ($"{comentario.IdComentario};{comentario.EmailUsuario};{comentario.Conteudo};{comentario.DataCriacao}");
            }

            return comentario;
        }
    }
}