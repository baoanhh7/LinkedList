using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_CTDL_DT_TH
{
    internal class Queue
    {
        private LinkedList list;

        public Queue()
        {
            list = new LinkedList();
        }

        public void enQueue(int x)
        {
            list.AddLast(x);
        }
        public int Dequeue()
        {
            int value = list.GetHead();
            list.RemoveHead();
            return value;
        }
        public bool Empty()
        {
            return list.Empty_Method();
        }
        public int Peak()
        {
            return list.GetHead();
        }
    }
}
