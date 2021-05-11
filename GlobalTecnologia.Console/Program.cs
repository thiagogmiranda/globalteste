using System;

namespace GlobalTecnologia
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resposta = CalcularMenorNumeroDivisivelPor(num1, num2);

            Console.WriteLine($"O número divisível pelos número de {num1} a {num2} é {resposta}.");
        }

        static int CalcularMenorNumeroDivisivelPor(int num1, int num2)
        {
			var numeros = ObterRange(num1, num2);
            bool ok = false;
			int numero = num2;

			while (!ok)
			{
				ok = true;

				for (int i = 0; i < numeros.Length; i++)
				{
					if (numero % numeros[i] != 0)
					{
						ok = false;
						break;
					}
				}

				if (!ok)
				{
					numero += 2;
				}
			}

            return numero;
		}

        static int[] ObterRange(int start, int end)
        {
            int length = end - start;
            int[] range = new int[length];

			for (int i = 0; i < length; i++, start++)
			{
                range[i] = start;
			}

            return range;
		}
    }
}
