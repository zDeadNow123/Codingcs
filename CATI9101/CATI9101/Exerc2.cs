using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATI9101 {
    public class Exerc2 {
        
        public void run() {
            // Manipulação de matrizes

            Console.WriteLine();
            int[] numeros = new int[6];
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++) {

                int sorteado = random.Next(1, 60);

                if (i == 0) numeros[i] = sorteado;

                if (Array.BinarySearch(numeros, sorteado) < 0) {
                    numeros[i] = sorteado;
                }

                if (i != numeros.Length - 1) Console.Write(numeros[i] + "-");
                else Console.Write(numeros[i]);
            }

            Console.WriteLine();
            Array.Sort(numeros); // ordena os números no vetor

            for (int i = 0; i < numeros.Length; i++) {
                if (i != numeros.Length - 2) Console.Write(numeros[i] + "-");
                else Console.Write(numeros[i]);
            }

            Console.ReadKey();
        }
    }
}
