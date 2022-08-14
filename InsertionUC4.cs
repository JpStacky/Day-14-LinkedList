using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InsertionUC4
    {
        NodeUC4 head, temp;
        public void Insertion()
        {
            head = new NodeUC4();
            temp = head;

            temp.data = 56;
            temp.next = new NodeUC4();
            temp = temp.next;

            temp.data = 70;
            temp.next = new NodeUC4();
            temp = temp.next;
        }
        public void InsertionAtMiddle(int number)
        {
            temp = head.next;
            NodeUC4 temp1 = new NodeUC4();
            temp1.data = number;
            temp1.next = temp;
            head.next = temp1;
        }
    }
}
