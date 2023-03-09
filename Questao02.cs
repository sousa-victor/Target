namespace Questao2
{
    internal class Questao2
    {
        static void Main(string[] args)
        {
            int teste = 1597;
            bool pertence = false;

            if (teste == 0 || teste == 1)
            {
                pertence = true;
            }
            else
            {
                int[] seqFibonacci = new int[teste + 2];
                seqFibonacci[0] = 0;
                seqFibonacci[1] = 1;

                for (int i = 2; i < teste + 2; i++)
                {
                    seqFibonacci[i] = seqFibonacci[i - 1] + seqFibonacci[i - 2];
                    if (seqFibonacci[i] == teste)
                    {
                        pertence = true;
                        break;
                    }
                }
            }

            if (pertence == false)
            {
                Console.WriteLine("O número não pertence a sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine("O número pertence a sequencia Fibonacci");
            }
        }
    }
}