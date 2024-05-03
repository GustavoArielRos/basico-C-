namespace HelloWorld
{
    class teste3
    {   

        //Enum --> uma nova forma de criar variaveis (ele trabalha num universo fechado de posssibilidades)

        enum Cor { Azul, Verde, Amarelo, Vermelho} //essas são as únicas possibilidades que esse "Cor" pode ter
                                                   //a ordem é a mesma de array, começa do 0

        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;// eu to passando o vermelho
            Cor corFavoritaDaCarla = Cor.Azul;// eu to passando o azul

            //posso fazer um casting tbm
            Cor corlegal = (int)Cor.Amarelo // ai eu vou passar a enumeração que ele tem


            int index = int.Parse(Console.ReadLine());// convertendo o que o usuário digitou(string) para inteiro

            // a parada do Enum é que você pode converter de uma string para inteiro e vice-versa
            Cor corEscolhida = (Cor)index;//casting, passando de int para "string"

            switch (corEscolhida)
            {
                case Cor.Azul:
                    Console.WriteLine("adfasf");
                    break;

                case Cor.Verde:
                    Console.WriteLine("adfasf");
                    break;

                case Cor.Amarelo:
                    Console.WriteLine("adfasf");
                    break;

                case Cor.Vermelho:
                    Console.WriteLine("adfasf");
                    break;

                default:
                    Console.WriteLine("adfasf");
                    break;
                
            }
        }
    }
}