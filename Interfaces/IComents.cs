using System.Collections.Generic;
using Senai.Projeto.Carfel.Models;

namespace Senai.Projeto.Carfel.Interfaces
{
    public interface IComents
    {
        ComentarioModel Comentar (ComentarioModel comentario);

        List<ComentarioModel> Listar();
    }
}