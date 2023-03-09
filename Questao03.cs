
/*
 Infelizmente inda não sei usar json ou xml, conforme instruído no teste.
 Não queria abandonar o teste por isso e gostaria que ainda pudessem levar em consideração
 Utilizei um vetor gerado com números pseudo-aleatorios
*/

using System.Globalization;

double[] faturamento = new double[30];

Random aleatorio = new Random();
double menor = 0;
double maior = 0;
double media = 0;
int diasZerados = 0;
int faturamentoSuperior = 0;

for (int i = 0; i < faturamento.Length; i++)
{
    faturamento[i] = (aleatorio.NextDouble()) * 100000;
    if (faturamento[i] != 0.0)
    {
        media += faturamento[i];
    }
    else
    {
        diasZerados++;
    }
}

media = media / (30.0 - (double)(diasZerados));

for (int i = 0; i < faturamento.Length; i++)
{
    if (menor == 0 && maior == 0 && faturamento[i] != 0)
    {
        menor = faturamento[i];
        maior = faturamento[i];
    }

    if (faturamento[i] > media)
    {
        faturamentoSuperior++;
    }

}

for (int i = 1; i < faturamento.Length; i++)
{

    if (faturamento[i] > maior)
    {
        maior = faturamento[i];
    }
    if (faturamento[i] < menor)
    {
        menor = faturamento[i];
    }
}

for (int i = 0; i<faturamento.Length; i++)
{
    Console.WriteLine(faturamento[i]);
}

Console.WriteLine("O menor valor de faturamento foi de: R$ " + menor.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("O maior valor de faturamento foi de: R$ " + maior.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine($"Houve {faturamentoSuperior} dias com faturamento superior à media mensal");