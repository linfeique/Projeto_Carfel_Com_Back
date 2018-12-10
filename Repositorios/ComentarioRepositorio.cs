using System;
using System.Collections.Generic;
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
            comentario.Aprovado = false;

            using (StreamWriter escrever = new StreamWriter ("comentario.csv", true)) {
                escrever.WriteLine ($"{comentario.IdComentario};{comentario.EmailUsuario};{comentario.Conteudo};{comentario.DataCriacao};{comentario.Aprovado}");
            }

            return comentario;
        }

        // static public List<ComentarioModel> CarregarDoCSV(){
        //     List<ComentarioModel> lsComentario = new List<ComentarioModel>();

        //     string[] linhas = File.ReadAllLines("comentario.csv");

        //     foreach (string comentar in linhas)
        //     {
        //         if(string.IsNullOrEmpty(comentar)){
        //             continue;
        //         }
                
        //         string[] dadosDaLinha = comentar.Split(";");

        //         ComentarioModel comentario = new ComentarioModel(
        //             id_: int.Parse(dadosDaLinha[0]),
        //             nome: dadosDaLinha[1],
        //             conteudo: dadosDaLinha[2],
        //             dataCriacao: DateTime.Parse(dadosDaLinha[3])
        //         );
        //         lsComentario.Add(comentario);
        //     }
        //     return lsComentario;
        // }
    }
}