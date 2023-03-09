using System.Globalization;

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;
double total = sp + rj + mg + es + outros;

Console.WriteLine("Com o dígito correspondente, informe o Estado em que deseja saber a proporção de faturamento.");
Console.WriteLine("1 - SP");
Console.WriteLine("2 - RJ");
Console.WriteLine("3 - MG");
Console.WriteLine("4 - ES");
Console.WriteLine("5 - Outros");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("O percentual do estado selecionado é de: "+ (sp*100/total).ToString("F2",CultureInfo.InvariantCulture) + "%");
        break;

    case 2:
        Console.WriteLine("O percentual do estado selecionado é de: " + (rj * 100 / total).ToString("F2", CultureInfo.InvariantCulture) + "%");
        break;

    case 3:
        Console.WriteLine("O percentual do estado selecionado é de: " + (mg * 100 / total).ToString("F2", CultureInfo.InvariantCulture) + "%");
        break;

    case 4:
        Console.WriteLine("O percentual do estado selecionado é de: " + (es * 100 / total).ToString("F2", CultureInfo.InvariantCulture) + "%");
        break;

    case 5:
        Console.WriteLine("O percentual do estado selecionado é de: " + (outros * 100 / total).ToString("F2", CultureInfo.InvariantCulture) + "%");
        break;

    default:
        Console.WriteLine("Valor inválido.");
        break;
}
