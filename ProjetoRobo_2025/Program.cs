namespace ProjetoRobo_2025;

internal class Program
{
    static void Main(string[] args)
    {

        funcoesRobo.cabecalhoProjetoRobo();


        bool validacao = true;
        while (validacao == true)
        {

            int[] posicaoRobo = funcoesRobo.posicaoInicialRobo();
            char OrientacaoRobo = funcoesRobo.OrientacaoAtualRobo();


            char[] comando = funcoesRobo.coordenadasRobo();



           OrientacaoRobo= funcoesRobo.MovimentoRobo(comando, posicaoRobo, OrientacaoRobo);
            if (posicaoRobo[0] > 5 || posicaoRobo[1] > 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("o robo esta fora do limite, insira outras coordenadas");
                Console.ResetColor();
                continue;
            }

            else
            {
                validacao = false;
            }

            funcoesRobo.MostrarPosicionamentoRobo(posicaoRobo, OrientacaoRobo);
            Console.WriteLine();

            Console.WriteLine("aperte ENTER para útilizar o robo 2"); Console.ReadLine();
            Console.WriteLine();

            funcoesRobo.cabecalhoSegundoRobo();

            int[] PosicaoRobo2 = funcoesRobo.posicaoInicialRobo();
            Console.WriteLine();
            char orientacaoRobo2 = funcoesRobo.OrientacaoAtualRobo();


            Console.WriteLine();
            char[] comandoRobo2 = funcoesRobo.coordenadasRobo();

            orientacaoRobo2= funcoesRobo.MovimentoRobo(comandoRobo2, PosicaoRobo2, orientacaoRobo2);
            funcoesRobo.MostrarPosicionamentoRobo(PosicaoRobo2, orientacaoRobo2);
            Console.ReadLine();
        }
        
    }
}
