using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRm0510_CalculoPrecoTipoIva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10. Escrever um programa para calcular o valor total a pagar por um determinado artigo, sabendo que o tipo de artigoe preço sem iva. Supondo que a taxa de iva é de 6% para os produtos essenciais, 23% para os bens de luxo e 13%para os restantes.
             * SWITCH…CASE
             */
            float ps;
            int ta;
            Console.Write("Preço sem IVA: "); // Não é feita validação, ou seja, outilizador pode introduzir caracteres inválidos e como tal gerar excepções(ERROS)
            ps = Convert.ToSingle(Console.ReadLine());  
            Console.WriteLine("** Escolha o tipo de artigo **\n1- bens essenciais\n2- produtos de luxo\n3- restantes");
            ta = Convert.ToInt32(Console.ReadLine());
            switch (ta)
            {
                case 1: Console.WriteLine("Preço com IVA: {0}", ps * (1 + 0.06F)); break;
                case 2: Console.WriteLine("Preço com IVA: {0}", ps * (1 + 0.23F)); break;
                case 3: Console.WriteLine("Preço com IVA: {0}", ps * (1 + 0.13F)); break;
                default: Console.WriteLine("ERRO"); break;
            }
            Console.ReadLine();
        }
    }
}
