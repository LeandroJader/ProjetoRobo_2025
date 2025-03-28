namespace ProjetoRobo_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Robo_2025");

            int[] posicaoRobo = [0, 0];
            char OrientacaoRobo = 'n';

            char comando = 'm';
            //movimento para frente olhando ao norte


            if (comando=='m' && OrientacaoRobo == 'n')
            {
                posicaoRobo[1] += 1;
            }
            // movimento para trás
            else if (comando=='m'&& OrientacaoRobo=='s')
            {
                posicaoRobo[1] -= 1;
            }
            // o robo anda para a direita
            else if (comando == 'm' && OrientacaoRobo == 'l')
            {
                posicaoRobo[0] += 1;
            }
            // o robo anda para a esquerda
            else if (comando=='m' && OrientacaoRobo == 'o')
            {
                posicaoRobo[0] -= 1;
            }
            

            


        }
    }
}
