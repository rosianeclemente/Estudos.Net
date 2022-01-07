using System;

namespace estudos1.Classes
{
    public class Serie : EntidadeBase{

    //Atributos
    private Genero Genero { get; set; }
    private string Titulo { get; set; }

    private string Discricao { get; set; }
    public int Ano { get; set; }
    public bool Excluido { get; set; }

    //Metodos
    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;

    }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Enviroment.NewLine;
            retorno += "Titulo: " + this.Titulo + Enviroment.NewLine;
            retorno += "Descrição " + this.Discricao + Enviroment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Enviroment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.id;
        }
        public void Excluir(){
           this.Excluido = true; 
        }
    }


}