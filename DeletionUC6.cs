using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeletionUC6
    {
        NodeUC6 head, temp, tail, temp1;
        public void Insertion()
        {
            head = new NodeUC6();
            temp = head;

            temp.data = 56;
            temp.next = new NodeUC6();
            temp = temp.next;

            temp.data = 30;
            temp.next = new NodeUC6();
            temp = temp.next;

            temp.data = 70;
            temp.next = null;

            tail = temp;
        }
        public void PopAtTail()
        {
            temp = head;
            while (temp != tail)
            {
                temp1 = temp;
                temp=temp.next;
            }
            tail = temp1;

            Console.WriteLine("After deletion of First Element..");
            
            temp = head;
            for (int i = 0; temp.next!=null; i++)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
