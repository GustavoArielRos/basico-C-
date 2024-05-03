using System

namespace MyApplication
{
    class Program
    {   
        //Essa é a classe principal, onde só tem a int main()
        static void Main(string[] args)
        {
            Car carro = new Car();
            Console.WriteLine(carro.color);// vai printar red
        }
    }
}