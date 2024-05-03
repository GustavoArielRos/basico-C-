using System;;
using System.IO;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string escreverTexto = "OLaa";
            File.WriteAllText("filename.txt", writeText);//cria o arquivo

            string lerTexto = File.ReadAllText("filename.txt");//transfere o arquivo para o lerTexto
            Console.WriteLine(lerTexto);
        }
    }
}