using System;

namespace MyApplication
{
    class Animal //classe base
    {
        public virtual void animalSound()
        {
            Console.WriteLine("O animal faz um som");
        }
    }

    class Pig : Animal //classe derivada
    {
        public override void animalSound()
        {
            Console.WriteLine("O porco faz: whonk whonk");
        }
    }

    class Dog : Animal //classe derivada
    {
        public override void animalSound()
        {
            Console.WriteLine("O cachorro faz: au au");
        }
    }

    class Program
    {
        public void Main(string[] args)
        {   
            //perceba que todos são da classe Animal
            Animal a = new Animal();
            Animal p = new Pig();
            Animal d = new Dog();

            a.animalSound(); //O animal faz um som
            p.animalSound(); //O porco faz: whonk whonk
            d.animalSound(); //O cachorro faz: au au
        }
    }
}