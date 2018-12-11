using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Senai.Projeto.Carfel.Controllers;
using Senai.Projeto.Carfel.Models;

namespace Senai.Projeto.Carfel.Repositorios {
    public class UsuarioRepositorio {

        static public UsuarioModel BuscarEmailSenha (string email, string senha) {
            List<UsuarioModel> lsUsuarios = CarregarDoCSV ();

            foreach (UsuarioModel usuario in lsUsuarios) {
                if (usuario.Email == email && usuario.Senha == senha) {
                    return usuario;
                }
            }

            return null;
        }

        static public List<UsuarioModel> CarregarDoCSV () {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            String[] linhas = File.ReadAllLines ("usuarios.csv");

            foreach (String linha in linhas) {
                if (string.IsNullOrEmpty (linha)) {
                    continue;
                }

                string[] dados = linha.Split (";");

                UsuarioModel usuario = new UsuarioModel (
                    id: int.Parse (dados[0]),
                    nome: dados[1],
                    email: dados[2],
                    senha: dados[3],
                    tipo: dados[4]
                );

                lsUsuarios.Add (usuario);
            }

            return lsUsuarios;
        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {

            if (File.Exists ("usuarios.csv")) {
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 2;

                using (StreamWriter escrever = new StreamWriter ("usuarios.csv")) {
                    escrever.WriteLine ($"1;admin;admin@carfel.com;admin;admin");
                }
            }

            using (StreamWriter escrever = new StreamWriter ("usuarios.csv", true)) {
                escrever.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};comum");
            }

            return usuario;
        }

        public UsuarioModel CadastroAdmin (UsuarioModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 2;

                using (StreamWriter escrever = new StreamWriter ("usuarios.csv")) {
                    escrever.WriteLine ($"1;admin;admin@carfel.com;admin;admin");
                }
            }

            using (StreamWriter escrever = new StreamWriter ("usuarios.csv", true)) {
                escrever.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Tipo}");
            }

            return usuario;
        }
    }
}