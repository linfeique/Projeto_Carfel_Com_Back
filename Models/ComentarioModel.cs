using System;

namespace Senai.Projeto.Carfel.Models
{
    public class ComentarioModel
    {
        public string Conteudo { get; set; }
        public int IdComentario { get; set; }
        public string EmailUsuario { get; set; }
        public DateTime DataCriacao { get; set; }

        public ComentarioModel(){
        
        }

        public ComentarioModel(string conteudo, string nome, DateTime dataCriacao){
            this.Conteudo = conteudo;
            this.EmailUsuario = nome;
            this.DataCriacao = dataCriacao;
        }

        public ComentarioModel(string conteudo){
            this.Conteudo = conteudo;
        }
    }
}