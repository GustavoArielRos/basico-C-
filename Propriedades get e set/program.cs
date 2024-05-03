using System


namespace MyAplication
{
    class Program
    {
        public void Main(string[] args)
        {
            Person p = new Person();

            p.Name = "Augusto";

            Console.WriteLine(p.Name);//vai aparecer "Augusto"
        }
    }
}