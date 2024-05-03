using System;


namespace MyAplication
{
    class Car
    {

        public string model;
        public string color;
        public int year;

        //Construtor
        public Car()
        {
            model = "Fiat";//valor inicial do model toda vez que um objeto do tipo carro é criado
        }

        public void Frase()
        {
            Console.WriteLine("o Carro acelera");
        }
    }
}