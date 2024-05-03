namespace HelloWorld
{
    class teste4
    {
        static void Main(string[] args)
        {
            string[] palavras = {"pera","uva", "maca", "abacaxi"};

            //FOREACTH ---> "para cada" , vai percorrer o array ( é bom para percorrer cada elemento do array)

            foreach(string palavra in palavras)//cada elemento do vetor(palavras) é simbolizado pela string "palavra
            {
                Console.WriteLine("foreach rodando!!!");
                Console.WriteLine(palavra);
            }

            //FOR 
            for(int contador = 0; contador < 10 ; contador++)
            {
                Console.WriteLine("FOR RODANDO!!!");
            }

            for(int contador = 0 ; contador < palavras.Length ; contador++)
            {
                Console.WriteLine(palavras[contador]);
            }

            //percorrer em ordem descrecente
            for(int contador2 = palavras.Length - 1; contador2 > -1 ; contador2--) //palavras.Length - 1 --> pegar o índice do último elemento do array
            {
                Console.WriteLine(palavras[contador]);
            }

        }
    }
}