namespace Animax.Classes
{
    public class Animacao
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinopse  {get; set;}
        private int Ano { get; set; }
        private int DuracaoMinutos { get; set;}
        private bool Excluido { get; set;}

        public Animacao(int id, string Genero, string Titulo, string Sinopse, int Ano, int DuracaoMinutos)
        {
            this.id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Sinopse = Sinopse;
            this.Ano = Ano;
            this.DuracaoMinutos = DuracaoMinutos;
            this.Excluido = false;

        }
    }
}