using System;


namespace MyApplication
{
    class Program
    {
        public void Main(string[] args)
        {
            Carro car = new Carro();

            car.buzina();

            Console.WriteLine(car.modelName); // vai printar o nome do carro(class Carro)

            Console.WriteLine(car.brand); // vai printar a marca do carro (class veiculo)

        }
    }
}