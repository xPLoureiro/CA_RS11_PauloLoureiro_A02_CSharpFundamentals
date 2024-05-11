using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXR09_NomeApelidoPremio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             9. Escrever uma mensagem que peça ao utilizador o primeiro nome e o apelido e apresente o seguinte resultado: <nome> <apelido>, acabou de ganhar o 1º prémio. Parabéns!
             */
            string nome, apelido;
            Console.Write("Introduza o 1º nome: ");
            nome = Console.ReadLine();
            Console.Write("Introduza o apelido: ");
            apelido = Console.ReadLine();
            Console.WriteLine("{0} {1}, acabou de ganhar o 1º prémio. Parabéns!", nome, apelido);
        }
    }
}
