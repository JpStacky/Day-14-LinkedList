using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortUC10
    {
        NodeUC10 head, temp, temp1;
        public void Insertion()
        {
            head = new NodeUC10();
            temp = head;

            temp.data = 70;
            temp.next = new NodeUC10();
            temp = temp.next;

            temp.data = 40;
            temp.next = new NodeUC10();
            temp = temp.next;

            temp.data = 30;
            temp.next = null;
            temp = temp.next;

            temp.data = 56;
            temp.next = null;
        }
        public void Sort()
        {
            temp = head;
            temp1 = temp.next;
            for (int i = 1; i <= 3; i++)
            {
                int j = 0;
                while (j <= (3-i))
                {
                    if (temp.data > temp1.data)
                    {
                        int num = temp.data;
                        temp.data = temp1.data;
                        temp1.data = num;
                    }
                }
            }
            Console.WriteLine("After Sorting...");

            for (temp = head; temp.next != null;)
            {
                Console.WriteLine("  "+temp.data);
                temp = temp.next;
            }
            Console.WriteLine("  " + temp.data);
        }
    }
}
