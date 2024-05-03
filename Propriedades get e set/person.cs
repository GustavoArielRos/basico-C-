using System

namespace MyAplication
{
    class Person
    {   
        //-a propriedade tem relação com o atributo
        //-voce cria o atributo e faz a propriedade que da ao atributo o "get" e "set"
        
        private string name; // atributo

        public string Name //propriedade
        {
            get { return name; } // le
            set { name = value}  // escreve
        }
    }
}