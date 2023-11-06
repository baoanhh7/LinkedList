using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_CTDL_DT_TH
{
    internal class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }

        public bool Empty
        {
            get { return this.size == 0; }
        }

        public bool Empty_Method()
        {
            if (this.head == null)
                return true;
            return false;
        }
        public int Count
        {
            get { return this.size; }
        }

    }
}
