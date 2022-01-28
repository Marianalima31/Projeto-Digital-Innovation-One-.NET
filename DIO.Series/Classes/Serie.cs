using System;
using System.Collections.Generic;

namespace DIO.Series
{

   

    public class Serie : EntidadeBase
    {

         // Atributos

        private Genero Genero {get; set;}
        
        private string Titulo {get; set;}

        private  string Descricao{get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}
    
        // Metodos
          
        public Serie (int id , Genero genero, string titulo, string descricao, int ano)
        {
            This.Id = id;
            This.Genero = genero;
            This.Titulo = titulo;
            This.Descricao = descricao;
            This.Ano = ano;
            This.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Enviroment.NewLine;
            retorno += "Titulo:" + this.Titulo + Enviroment.NewLine;
            retorno += "Descrição:" + this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Titulo:" + this.Ano + Enviroment.NewLine;
            retorno += "Excluido:" + this.Excluido;
            return retorno ;

        }

         public string retornaTitulo()
          {
            return this.Titulo;
         }

        public string retornaId()
        {
            return this.Id;
        }

        
        public bool retornaExcluido()
        {
            return this.Excluido;
        }


        public void Excluir()
        {
            this.Excluido = true;
        }

    }

    


 
}