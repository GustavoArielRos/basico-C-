using System

namespace MyAplication
{
    class Program
    {
        public void Main(string[] args)
        {
            Car carro = new Car();//Criei o objeto carro (isso vai chamar o seu construtor)

            Console.WriteLine(carro.model);//vai printar o valor que está no construtor
        }
    }
}