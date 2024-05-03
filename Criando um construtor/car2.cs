using System;


namespace MyAplication
{
    class Car2
    {
        public string model;
        public string color;
        public int year;

        //construtor
        public Car2()
        {
            model = "Fiat";
        }

        //construtor
        public Car2(string colorName, int yearName )
        {
            color = colorName;
            year = yearName
        }

        static void Main(string[] args)
        {
            Car carro = new Car("red", 2090);//eu criei e com isso já roda os construtores


        }
    }
}