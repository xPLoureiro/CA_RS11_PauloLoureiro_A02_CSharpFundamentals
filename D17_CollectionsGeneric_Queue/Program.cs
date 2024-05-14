using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D17_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Queue (fila = FIFO)
            Queue<int> queueIntegers = new Queue<int>();

            queueIntegers.Enqueue(0);
            queueIntegers.Enqueue(1);

            for (int i = 2; i < 4; i++) 
            {
                queueIntegers.Enqueue(i);
            }

            Utility.WriteTitle("Enqueue");

            foreach (int item in queueIntegers)
            {
                Utility.WriteMessage(item.ToString(), "\n");    // 0, 1, 2, 3
            }

            Utility.WriteTitle("Dequeue", "\n\n\n");

            int countQueue = queueIntegers.Count;  // variável para percorrer o valores

            for (int i = 0; i < countQueue; i++)
            {
                Utility.WriteMessage($"{queueIntegers.Dequeue()}", "\n");   // 0, 1, 2, 3
            }
            #endregion

            Utility.TerminateConsole();

        }
    }
}
