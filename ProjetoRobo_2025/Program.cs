namespace ProjetoRobo_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Robo_2025");

            int[] posicaoRobo = [1, 2];
            char OrientacaoRobo = 'n';
            int[] PosicaoRobo2 = [3, 3];
            char orientacaoRobo2 = 'l';


            char[] comando = funcoesRobo.coordenadasRobo();

            funcoesRobo.MovimentoRobo(comando, posicaoRobo, OrientacaoRobo);
            funcoesRobo.MostrarPosicionamentoRobo(posicaoRobo, OrientacaoRobo);


            char[] comandoRobo2 = funcoesRobo.coordenadasRobo();

            funcoesRobo.MovimentoRobo(comandoRobo2, PosicaoRobo2, orientacaoRobo2);
            funcoesRobo.MostrarPosicionamentoRobo(PosicaoRobo2, orientacaoRobo2);
            
        }
    }
}
