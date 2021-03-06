using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Projeto.Carfel.Interfaces;
using Senai.Projeto.Carfel.Models;

namespace Senai.Projeto.Carfel.Repositorios
{
    public class ComentRapSerie : IComents
    {
        private List<ComentarioModel> comentariosSalvos {get; set;}

        public ComentRapSerie(){
            if(File.Exists("comentario.dat")){
                comentariosSalvos = LerArqSerie();
            } else{
                comentariosSalvos = new List<ComentarioModel>();
            }
        }

        public ComentarioModel Comentar (ComentarioModel comentario){
            comentario.IdComentario = comentariosSalvos.Count + 1;
            comentariosSalvos.Add(comentario);

            EscreverArq();

            return comentario;
        }

        public void EscreverArq(){
            MemoryStream memoria = new MemoryStream();

            BinaryFormatter serializaAmemoria = new BinaryFormatter();

            serializaAmemoria.Serialize(memoria, comentariosSalvos);

            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("comentario.dat", bytes);
        }

        public List<ComentarioModel> Listar(){
            return comentariosSalvos.OrderBy(x => x.DataCriacao).Reverse().ToList();
        }

        public List<ComentarioModel> LerArqSerie(){
            byte[] comentarioSerie = File.ReadAllBytes("comentario.dat");

            MemoryStream memoria = new MemoryStream(comentarioSerie);

            BinaryFormatter serializaAmemoria = new BinaryFormatter();

            return (List<ComentarioModel>) serializaAmemoria.Deserialize(memoria);
        }

        public ComentarioModel BuscarPorId(int id){
            foreach (ComentarioModel comentario in comentariosSalvos)
            {
                if(id == comentario.IdComentario){
                    return comentario;
                }
            }
            return null;
        }

        public void Aprovar(int id_aprova){
            ComentarioModel comentarioBuscado = BuscarPorId(id_aprova);

            if(comentarioBuscado != null){
                comentarioBuscado.Aprovado = true;
                EscreverArq();
            }
        }

        public void Excluir(int id_reprova){
            ComentarioModel comentarioBuscado = BuscarPorId(id_reprova);

            if(comentarioBuscado != null){
                comentariosSalvos.Remove(comentarioBuscado);
                EscreverArq();
            }
        }
    }
}