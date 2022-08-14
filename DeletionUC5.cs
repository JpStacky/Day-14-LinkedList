using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeletionUC5
    {
        NodeUC5 head, temp;
        public void Insertion()
        {
            head = new NodeUC5();
            temp = head;

            temp.data = 56;
            temp.next = new NodeUC5();
            temp = temp.next;

            temp.data = 30;
            temp.next = new NodeUC5();
            temp = temp.next;

            temp.data = 70;
            temp.next = new NodeUC5();
            temp = temp.next;
        }
        public void PopAtHead()
        {
            head = head.next;
            temp = head;
            Console.WriteLine("After deletion of First Element..");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(temp.data);
                temp= temp.next;
            }
        }
    }
}
