
using System.Security.Cryptography.X509Certificates;

namespace ProjetoRobo_2025;
public class funcoesRobo
{

    public static char[] coordenadasRobo()
    {
        Console.WriteLine("informe as coordenadas que deseja passar para o robo");

        char[] comando = Console.ReadLine()!.ToLower().ToCharArray();
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

        Console.WriteLine($"o robo esta na posição x{posicaoRobo[0]} {posicaoRobo[1]}y olhando para :{OrientacaoRobo}");
        Console.ReadLine();

    }
    public static void MostrarPosicionamentoRobo2(int[] posicaoRobo, char OrientacaoRobo)
    {

    }


}



