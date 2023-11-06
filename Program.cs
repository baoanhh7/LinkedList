using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KT_CTDL_DT_TH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 12, 89, 34, 56, 15 };

            LinkedList list = new LinkedList();
            list.InPut_AddHead(arr);

            list.Output();

            //Console.WriteLine("Is it empty? - " + list.Empty);
            Console.WriteLine("Is it empty?(Method) - " + list.Empty_Method());
            Console.WriteLine("Count - " + list.Count);

            Console.Write("Nhap so can tim: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"So {x} o vi tri: {list.FindX(x)}");

            Console.WriteLine("Nhap vi tri va so can them: ");
            int vt = int.Parse(Console.ReadLine());
            int so = int.Parse(Console.ReadLine());
            list.AddX(vt, so);
            list.Output();

            list.DelX(3);
            list.Output();

            list.SuaPT(4,99);
            list.Output();

            Console.ReadLine();
        }
    }
}
