using System;

namespace CATI9101 {
    public class Exerc {
        public void run() { 
            
            // Manipulação de strings
            string nome = "Wellington Vieira dos Santos";

            // Retorna o número de caracteres
            Console.WriteLine(nome.Length);

            // Removendo espaços do começo ao fim
            nome = nome.Trim();
            Console.WriteLine(nome);

            // Exibindo os primeiros 4 caracteres do nome
            Console.WriteLine(nome.Substring(0, 4));

            // Alterando a variável para manter apenas os primeiros 4 caracteres
            // nome = nome.Substring(0, 4);

            //nome = nome.Remove(4);
            Console.WriteLine(nome.Remove(4)); // Mantém os 4 primeiros

            nome = nome.Replace("Well", "Past");
            Console.WriteLine(nome);

            // Substituindo Caracteres
            Console.WriteLine(nome.Replace(" ", "-"));

            // Insere caracteres em uma string
            Console.WriteLine(nome.Insert(0, "Mr. "));

            // Retorna a posição da primeira ocorrência da string
            Console.WriteLine(nome.IndexOf("i"));

            // Deixar todas as letras minusculas
            Console.WriteLine(nome.ToLower());

            // Deixar todas as letras maiusculas
            Console.WriteLine(nome.ToUpper());

            // Dividir caracteres na string
            string[] nomes = nome.Split(' ');

            foreach(string i in nomes) {
                Console.WriteLine(i);
            }

            string texto = "rapaz";

            // inverter texto convertendo para array
            char[] textoArray = texto.ToCharArray();
            Array.Reverse(textoArray);
            Console.WriteLine(new string(textoArray));
            
            Console.ReadKey();

        }
    }
}
