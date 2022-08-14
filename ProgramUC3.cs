using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ProgramUC3
    {
        public static void Main()
        {
            NodeUC3 node = new NodeUC3();

            NodeUC2 head = new NodeUC2();
            NodeUC2 temp = head;

            temp.data = 56;
            temp.next = new NodeUC2();
            temp = temp.next;

            temp.data = 30;
            temp.next = new NodeUC2();
            temp = temp.next;

            temp.data = 70;
            temp.next = new NodeUC2();
            temp = temp.next;
        }
    }
}
