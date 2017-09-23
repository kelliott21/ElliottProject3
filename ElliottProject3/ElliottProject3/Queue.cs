using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject3
{
    class Queue
    {
        public LinkedList list = new LinkedList();

        public Queue()
        {
            
        }

        public void addQueue(int value)
        {
            //if (head == null)
            //{
            //    Link temp = new Link();
            //    temp.value = value;
            //    head = temp;
            //    tail = temp;
            //}
            //else
            //{
            //    Link temp = new Link();
            //    temp.value = value;
            //    tail.nextLink = temp;
            //    tail = temp;
            //}
            list.add(value);

        }

        //int? is a nullable int that can accept a null value
        public int? deQueue()
        {
            //int? returned;
            //if(head != null)
            //{
            //    returned = head.value;
            //    //First value is cut from the list
            //    head = head.nextLink;
            //}
            ////Does this if the queue is empty
            //else
            //{
            //    returned = null;
            //}
            //return returned;
           return list.removeFirst();
        }

      public string Display()
        {
            return list.printOut();
        }
    }
}
