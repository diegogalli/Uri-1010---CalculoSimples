using System;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodPc1, CodPc2, NrPc1, NrPc2;
            double ValorPc1, ValorPc2, ValorPago;

            string[] valores = Console.ReadLine().Split(' ');
            CodPc1 = int.Parse(valores[0]);
            NrPc1 = int.Parse(valores[1]);
            ValorPc1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            CodPc2 = int.Parse(valores[0]);
            NrPc2 = int.Parse(valores[1]);
            ValorPc2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            ValorPago = ValorPc1 * NrPc1 + ValorPc2 * NrPc2;

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorPago.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
