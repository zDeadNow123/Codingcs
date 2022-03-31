using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATI9101 {
    public class Tabuada {
        public static void run() {

            // Declaração de variáveis
            int[] vnumero = new int[10];
            string sair = string.Empty;
            int cont = 10;

            // While utilizado para repetir a operação enquanto o usuário não digitar "s" (sair)
            while (sair != "s" && cont > 0) {

                // Mensagem de entrada do usuário
                Console.WriteLine("Digite um número de 1 a 10");

                // Declaração de variáveis
                int numero = int.Parse(Console.ReadLine());
                int resultado = 0;

                // Verifica se o numero não é maior que 0 e se não é menor que 11
                if (!(numero > 0 && numero < 11)) {
                    Console.WriteLine("Você deve digitar um número de 1 a 10");
                    Console.ReadKey();
                    return;
                }

                // Percorre os números da tabuada escolhida de 1 a 10 e exibe o resultado
                for (int i = 1; i <= 10; i++) {
                    resultado = numero * i;
                    Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
                }

                // Declaração de variáveis
                cont--;
                vnumero[cont] = numero;

                // Definindo a saída
                Console.WriteLine("Deseja sair? (s) ou enter para continuar:");
                sair = Console.ReadLine();
                Console.Clear();
            }

            // Após o usuário digitar "s" (sair) o programa exibe os números que o usuário digitou

            // Exibindo a tabuada
            Console.Write("Você exibiu as tabuadas dos números: ");

            // Percorre o vetor vnumero e exibe os valores
            foreach (var item in vnumero) {
                if (item != 0) Console.Write($"{item}, ");
            }

            // Aguarda a entrada do usuário
            Console.ReadKey();
        }
    }
}
