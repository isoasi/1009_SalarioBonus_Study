using System;
using System.Globalization;
using System.Numerics;

class URÌ
{
    static void Main(string[] args)
    {
        string nomeVendedor;
        double salarioFixo, vendas, totalSalario;

        nomeVendedor = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        totalSalario = salarioFixo + (vendas * 0.15);
        //It calculates the total amount to be received by adding the fixed salary to 15% of the total sales
        //(vendas * 0.15 represents the commission).
        
        Console.WriteLine("TOTAL = R$ " + totalSalario.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadLine();

    }
}