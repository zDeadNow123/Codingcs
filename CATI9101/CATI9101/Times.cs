using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATI9101 {
    internal class Times {
        public static void run() {

            // Declaração de matrizes
            string[] jogadores = {"José", "Paulo", "Gabriel", "Júlio", "Marcos"};
            //int[,] pontos = { { 0, 2 }, { 1, 3 }, { 2, 5 }, { 3, 4 } };
            string[] times = new string[10];
            int[,] tabela = new int[5, 6];

            // Matriz de 4 linhas e 2 colunas
            // [,] = [linha , coluna]
            int[,] m = new int[4, 2];

            foreach(string jogador in jogadores) {
                
                Console.WriteLine(jogador);
            }

            for (int i = 0; i < jogadores.Length; i++) {
                Console.WriteLine("Digite o nome do {0}º jogador:", i + 1);
                jogadores[i] = Console.ReadLine();
            }

/*
            // [linha, coluna] = valor
            m[0, 0] = 0;
            m[1, 0] = 1;
            m[2, 0] = 2;
            m[3, 0] = 3;

            m[0, 1] = 2;
            m[1, 1] = 3;
            m[2, 1] = 5;
            m[3, 1] = 4;
*/

            // Aguarda a entrada do usuário
            Console.ReadKey();
        }
    }
}