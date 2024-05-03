using System;

// as classe é uma só porém podemos ter vários objetos que são dessa classe

namespace MyApplication
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj2 = new Car()

            Console.WriteLine(myObj.color) // vai aparecer na tela "red"
            Console.WriteLine(myObj2.color) // vai aparecer na tela "red"
        }
    }
}