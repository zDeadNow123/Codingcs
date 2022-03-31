using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATI9101 {
    public class Conversaodetipos {
        public static void run() {

            // Declaração de variáveis
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
        }
    }
}
