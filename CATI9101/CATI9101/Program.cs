using System;

namespace CATI9101

{
    internal class Program {
        // Atributos

        // Construtores

        // Métodos de acesso (get e set) - C# - Propriedades

        // Métodos de classe - função/operação/ação do objeto

        static void Main(string[] args) {



            // Declaração de variáveis

            /*
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

            int w = 0;
            byte l = 0;
     
            double A, B, C, D;
            A = 2.55;
            float c = 10.65f;


            // Formas de conversões de tipos
            

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de seu nascimento:");
            //int ano = int.Parse(Console.ReadLine());
            int ano = Convert.ToInt32(Console.ReadLine());
            //byte idade = (byte)(DateTime.Now.Year - (byte)ano);
            byte idade = Convert.ToByte(DateTime.Now.Year - ano);
            
            Console.WriteLine("Olá {0}, sua idade é {1}", nome, idade);
        */

        bool atende = false;
        int[] vnumero = new int[10];
        string sair = string.Empty;
        int cont = 10;

        while(sair != "s" && cont > 0) {

            Console.WriteLine("Digite um número de 1 a 10");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 0;
        
            do {

                if (!(numero > 0 && numero < 11)) {
                    Console.WriteLine("Você deve digitar um número de 1 a 10");
                    atende = false;
                    Console.ReadKey();
                    return;
                }

                for (int i = 1; i <= 10; i++) {
                    resultado = numero * i;
                    Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
                }
                atende = true;


            } while (!atende);

            cont--;
            vnumero[cont] = numero;

            Console.WriteLine("Deseja sair? (s) ou enter para continuar:");
            sair = Console.ReadLine();
            Console.Clear();
        } // Fim do While

        Console.Write("Você exibiu as tabuadas dos números: ");

        foreach (var item in vnumero) {
            if (item != 0) Console.Write($"{item}, ");
        }

        Console.ReadKey();
        
        } // Fim do Main       
    } // Fim da classe Program
} // Fim do namespace