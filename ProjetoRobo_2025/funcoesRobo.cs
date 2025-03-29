
namespace ProjetoRobo_2025;
public class funcoesRobo
{

    public static char[] coordenadasRobo()
    {
        Console.WriteLine("informe as coordenadas que deseja passar para o robo");

        char[] comando = Console.ReadLine()!.ToLower().ToCharArray();
        return comando;

    }
        public static void MovimentarRobo(char orientacao,int[] posicaoRobo)
    {
        switch (orientacao)
        {
            case 'n': posicaoRobo[1] += 1; break;
            case 's': posicaoRobo[1] -= 1; ; break;
            case 'l': posicaoRobo[0] += 1;  break;
            case 'o': posicaoRobo[0] -= 1; break;
        }



    }


}



