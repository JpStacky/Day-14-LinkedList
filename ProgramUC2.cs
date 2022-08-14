using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ProgramUC2
    { 
        public static void Main()
        {
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
