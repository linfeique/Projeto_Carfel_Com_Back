using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Senai.Projeto.Carfel.Models;
using Senai.Projeto.Carfel.Repositorios;

namespace Senai.Projeto.Carfel
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ComentRapSerie comentRap = new ComentRapSerie();

            if(File.Exists("comentario.dat")){
                List<ComentarioModel> comentarioSalvos = comentRap.LerArqSerie();
            } else{
                ComentarioModel comentario = new ComentarioModel();

                comentario.Aprovado = false;
                comentario.Conteudo = "Compre o nosso produto";
                comentario.DataCriacao = DateTime.Now;
                comentario.EmailUsuario = "Admin@carfel.com";
                comentario.IdComentario = 1;
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
