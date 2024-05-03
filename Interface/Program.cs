using System;

namespace MyApplication
{   
    //INTERFACE
    interface IAnimal
    {
        void  animalSound(); //método da interface(não tem corpo)
    }

    //Porco implementa a interface "IAnimal"
    class Porco : Animal 
    {
        public void animalSound()//pegando o método e modificando
        {
            Console.WriteLine("o porco fala whonk whonk");
        }
    }

    class Program
    {
        public void Main(string[] args)
        {
            Porco p = new Porco();

            p.animalSound();
        }
    }
}