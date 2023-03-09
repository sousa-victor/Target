Console.WriteLine("Informe uma palavra.");
string entrada = Console.ReadLine();
string saida = "";


for (int i = (entrada.Length-1); i>=0; i--)
{
    saida = saida + entrada[i];
}
Console.WriteLine(saida);