namespace HelloWorld
{
    class teste2
    {   
        //FUNÇÃO PRINCIPAL
        static void Main(string args [])
        {
            GerarPreco(50);
            GerarPreco(56);
            ExibirMsg();

            int soma1 = Somar(2,3,3);//essa função tem retorno
        } 

        //FUNÇÃO AUXILIAR

        // void ---> não retorna nada
        static void ExibirMsg()
        {
            Console.WriteLine("oi");
            Console.WriteLine("ooiii");
        }

        static void GerarPreco(int preco)
        {
            
            // Abs, faz a operação de módulo, coloca o número positivo sempre
            int precoAbs = Math.Abs(preco); 

            Console.WriteLine(preco);
        }

        //RETORNO DE FUNÇÃO
        static int Somar(int a , int b , int c)
        {
            int resultado = a + b + c;
            return resultado; // também posso retornar o número 10
        }

    }
}