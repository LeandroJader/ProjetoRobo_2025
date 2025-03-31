namespace ProjetoRobo_2025;
public class funcoesRobo
{

    public static void cabecalhoProjetoRobo()
    {
        Console.WriteLine("-----------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Projeto Robo_2025");
        Console.ResetColor();
        Console.WriteLine("-----------------");
    }

    public static void cabecalhoSegundoRobo()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Passe as informações do segundo robo");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }



    
    public static int [] posicaoInicialRobo()
    {
        bool validacao = true;
        int[] posicaoInicialRobo = new int[2];
        while (validacao == true)
        {
            Console.WriteLine("insira a posiçao inicial do robo");

            for (int i = 2; i <= posicaoInicialRobo.Length; i++)
            {
                posicaoInicialRobo[0] = Convert.ToInt32(Console.ReadLine());
                if (posicaoInicialRobo[0] > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("a posição do robo deve estar dentro do limite de 5x5, insira novamente");
                    Console.ResetColor();
                    continue;
                }

                Console.WriteLine("insira a proxima posição");
                posicaoInicialRobo[1] = Convert.ToInt32(Console.ReadLine());
                if (posicaoInicialRobo[1] > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("a posição do robo deve estar dentro do limite de 5x5, insira novamente");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    validacao = false;
                }
            }
            
            
        }
        return posicaoInicialRobo;
    }
    public static char OrientacaoAtualRobo()
    {
        bool validacao = true;
        char orientacaoAtual=' ';
        while (validacao == true)
        {
            Console.WriteLine("insira a orientação atual N,S,L,O");
           orientacaoAtual = Convert.ToChar(Console.ReadLine().ToLower());
            if (orientacaoAtual != 'n' && orientacaoAtual != 's' && orientacaoAtual != 'l' && orientacaoAtual != 'o')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O comando nao responde a nenhuma orientação tente usar N,S,L,O");
                Console.ResetColor();
                continue;
            }
            else
            {
                validacao = false;
            }
        }
        return orientacaoAtual;
    }



    public static char[] coordenadasRobo()
    {
        char[] comando = [];
        bool validacaocoordenadas= true;
        while (validacaocoordenadas == true) {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("informe as coordenadas que deseja passar para o robo");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("M para andar frente E para virar 90 graus para esquerda e D 90 Graus para direita");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------");
             comando = Console.ReadLine()!.ToLower().ToCharArray();
            
            if (comando.All(c => c == 'm' || c == 'e' || c == 'd'))
            {
                validacaocoordenadas = false;
                        
            }
            else
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira coordenadas válidas");
                Console.ResetColor();
                Console.WriteLine("--------------------------");
                continue;
            }
        }
                return comando;
    }
    public static void MovimentoRobo(char[] comando, int[] posicaoRobo, char OrientacaoRobo)

    {
        
        
        foreach (char i in comando)
        {

            if (i == 'm' && OrientacaoRobo == 'n')
            {
                posicaoRobo[1] += 1;
            }
            // movimento para trás
            else if (i == 'm' && OrientacaoRobo == 's')
            {
                posicaoRobo[1] -= 1;
            }
            // o robo anda para a direita
            else if (i == 'm' && OrientacaoRobo == 'l')
            {
                posicaoRobo[0] += 1;
            }
            // o robo anda para a esquerda
            else if (i == 'm' && OrientacaoRobo == 'o')
            {
                posicaoRobo[0] -= 1;
            }



            //o robo vira para a direita
            if (i == 'd' && OrientacaoRobo == 'n')
            {
                OrientacaoRobo = 'l';
            }

            else if (i == 'd' && OrientacaoRobo == 's')
            {
                OrientacaoRobo = 'o';
            }

            else if (i == 'd' && OrientacaoRobo == 'l')
            {
                OrientacaoRobo = 's';
            }

            else if (i == 'd' && OrientacaoRobo == 'o')
            {
                OrientacaoRobo = 'n';
            }


            //o robo vira para a esquerda 
            if (i == 'e' && OrientacaoRobo == 'n')
            {
                OrientacaoRobo = 'o';
            }


            else if (i == 'e' && OrientacaoRobo == 's')
            {
                OrientacaoRobo = 'l';
            }

            else if (i == 'e' && OrientacaoRobo == 'l')
            {
                OrientacaoRobo = 'n';
            }

            else if (i == 'e' && OrientacaoRobo == 'o')
            {
                OrientacaoRobo = 's';
            }
        }
    
     
        
    }
  
    
    public static void MostrarPosicionamentoRobo(int[] posicaoRobo, char OrientacaoRobo)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"o robo esta na posição x{posicaoRobo[0]} {posicaoRobo[1]}y olhando para :{OrientacaoRobo}");
        Console.ResetColor();
        
    }
    

}



