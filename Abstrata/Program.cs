using System;

namespace MyApplication
{
    //Classe Abstrata
    abstract class Animal
    {
        //método abstrato (não tem corpo)
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("whonk whonk");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();//lembre-se não posso criar um objeto de classe abstrata

            p.sleep() //"Zzz"
            p.animalSound() //"whonk whonk" 
        }
    }
}