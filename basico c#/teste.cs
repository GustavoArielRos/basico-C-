//módulos
//C# dividida em módulos

using System;//trabalha com console
using System.Collections.Generic;//tem umas estruturas de dados importantes
using System.Linq;// liga com muitos dados
using System.Text;// manipular texto 
using System.Threading.Tasks;//criar um programa que roda em vários núcleos

//using --> para importar módulos

//"namespace HelloWorld" e "Program" tem haver com POO
namespace HelloWorld
{
    class teste
    {   

        //VARIÁVEL GLOBAL(todas as funções , até main(), pode usar ela)
        static string meuNomeCompleto = "oi"; // eu coloquei "static" porque a funções também são "static"
        
        static void Main(string[] args)// é a main() --> função principal
        {   
            
            // PRINTF E SCANF
            Console.WriteLine("oi");//printar no console
            Console.ReadLine();//é o "scanf" pega o que o cara escreve (o programa só fecha quando o usuário aperta "enter")

            
            //VARIÁVEIS
            string myText = "Hello";
            char myBool = 'D';
            bool myBool = true;
            float num = 232.23f;//precisa colocar o "f" no final do numero

            var meuTexto = "OI"; // variável (voce pode colocar "var", que identifica o tipo , criou e voce colocou uma string ele ja coloca que a variavel é uma string)

            dynamic cor_favorita = "Vermelho"; // dynamic --> o tipo da variável é mutável, ele fica do tipo que eu colocar como valor(é bom não usar)
            cor_favorita = 233;

            //CONSTANTES
            const float PI = 3.145565f;// não da para mudar o valor se eu colocar depois PI = 2; não vai rodar

            //TRABALHANDO COM ENTRADA

            Console.WriteLine("digite: \n");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);//exibe a variável na tela, da para printar variaveldo tipo int e talz

            // if e else if(else if é na mesma linha)

            //FUNÇÕES(nesse caso são métodos)

            //void , esse método não retorna nada
            static void ExibirMsg()
            {

            }

            //ARRAY

            string[] produtos = new string[5] { "Sea of thieves", "FIFA", "NBA", "Portal", "half-life"};

            Console.WriteLine(produtos[4]);//vai printar o FIFA
            produtos[3] = "Fifa3122";//alterando o valor
            
            int[] valores ={30,5,6,788,12,34}; // outra forma de criar array


        }
    }

}