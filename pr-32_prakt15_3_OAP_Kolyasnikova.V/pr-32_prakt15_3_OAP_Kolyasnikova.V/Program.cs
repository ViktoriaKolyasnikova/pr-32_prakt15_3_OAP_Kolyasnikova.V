using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt15_3_OAP_Kolyasnikova.V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int r = Convert.ToInt32(Console.ReadLine());
            Queue q = new Queue();
            for (int i = 1; i <= r; i++)
            {
                q.Enqueue(i);
            }  
            Console.WriteLine("Размерность очереди: " + q.Count);
            Console.WriteLine("Верхний элемент очереди: " + q.Peek());
            Console.Write("Содержимое очереди: ");
            while (q.Count != 0)
            {
                Console.Write(" "+q.Dequeue());
            }
            Console.WriteLine("\nНовая размерность очереди: " + q.Count);
            Console.ReadKey();
        }
    }
}
