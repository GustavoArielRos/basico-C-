using System;


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carro = new Car();

            carro.model = "Fiat";
            carro.color = "blue";
            carro.year = 2039;

            carro.fullThrottle();//chamando o método
        }
    }
}