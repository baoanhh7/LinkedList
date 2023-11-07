using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_CTDL_DT_TH
{
    internal class Node
    {
        private int data;
        private Node next;

        public Node()
        {
            data = 0;
        }
        public Node(int data)
        {
            this.data = data;
        }

        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Node AddLast(int value)
        {
            Node newNode = new Node(value);
            next = newNode;
            return newNode;
        }
        public int GetValue()
        {
            return data;
        }
        public Node GetNext()
        {
            return next;
        }
    }
}
