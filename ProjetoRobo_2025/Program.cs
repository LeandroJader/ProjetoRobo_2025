namespace ProjetoRobo_2025;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Robo_2025");



        bool validacao = true;
        while (validacao == true)
        {

            int[] posicaoRobo = funcoesRobo.posicaoInicialRobo();
            char OrientacaoRobo = 'l';
            int[] PosicaoRobo2 = [3, 3];
            char orientacaoRobo2 = 'l';

            char[] comando = funcoesRobo.coordenadasRobo();



            funcoesRobo.MovimentoRobo(comando, posicaoRobo, OrientacaoRobo);
            if (posicaoRobo[0] > 5 || posicaoRobo[1] > 5)
            {
                Console.WriteLine("o robo esta fora do limite, insira outras coordenadas");
                continue;
            }
            else
            {
                validacao = false;
            }


            funcoesRobo.MostrarPosicionamentoRobo(posicaoRobo, OrientacaoRobo);



            char[] comandoRobo2 = funcoesRobo.coordenadasRobo();

            funcoesRobo.MovimentoRobo(comandoRobo2, PosicaoRobo2, orientacaoRobo2);
            funcoesRobo.MostrarPosicionamentoRobo(PosicaoRobo2, orientacaoRobo2);


        }
    }
}
