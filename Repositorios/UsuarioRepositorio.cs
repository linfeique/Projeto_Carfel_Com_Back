using System;
using System.Collections.Generic;
using System.IO;
using Senai.Projeto.Carfel.Models;

namespace Senai.Projeto.Carfel.Repositorios
{
    public class UsuarioRepositorio
    {

        public UsuarioModel BuscarEmailSenha(string email, string senha){
            List<UsuarioModel> lsUsuarios = CarregarDoCSV();

            foreach(UsuarioModel usuario in lsUsuarios){
                if(usuario.Email == email && usuario.Senha == senha){
                    return usuario;
                }
            }

            return null;
        }

        public List<UsuarioModel> CarregarDoCSV(){
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();

            String[] linhas = File.ReadAllLines("usuarios.csv");

            foreach (String linha in linhas)
            {
                if(string.IsNullOrEmpty(linha)){
                    continue;
                }

                string[] dados = linha.Split(";");

                UsuarioModel usuario = new UsuarioModel(
                    id: int.Parse(dados[0]),
                    nome: dados[1],
                    email: dados[2],
                    senha: dados[3]
                ); 

                lsUsuarios.Add(usuario);
            }

            return lsUsuarios;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario){
            
            if(File.Exists("usuarios.csv")){
                usuario.Id = File.ReadAllLines("usuarios.csv").Length + 1;
            } else{
                usuario.Id = 1;
            }

            using(StreamWriter escrever = new StreamWriter("usuarios.csv", true)){
                escrever.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha}");
            }

            return usuario;
        }
    }
}