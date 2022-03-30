using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATI9101 {
    internal class Introducao {
        public static void run() {

            var x = 10;
            var nome = "Maria";
            var teste = true;
            var valor = 12.89;
            var num = 15f;
            var y = false;
            byte[] vetor = new byte[5]; // Matriz de bytes
            vetor[0] = 87;
            vetor[1] = 101;
            vetor[2] = 108;
            vetor[3] = 108;
            vetor[4] = 115;

            for (int i = 0; i < vetor.Length; i++) {

                Console.Write(vetor[i]);
            }

        }
    }
}
