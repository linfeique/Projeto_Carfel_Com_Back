namespace Senai.Projeto.Carfel.Models
{
    public class ComentarioModel
    {
        public string Conteudo { get; set; }
        public int IdComentario { get; set; }
        public UsuarioModel usuarioModel { get; set; }
    }
}