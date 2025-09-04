using System;
using System.Globalization;

class DescontoInteligente
{
    static void Main(string[] args)
    {
        double valorOriginal;
        double percentualDesconto;

        if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out valorOriginal) &&
            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out percentualDesconto))
        {
            if (percentualDesconto < 0 || percentualDesconto > 100)
            {
                Console.WriteLine("Desconto invalido");
            }
            else
            {
                double valorFinal = valorOriginal * (1 - percentualDesconto / 100.0);
                Console.WriteLine(valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
