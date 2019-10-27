using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLinkedListApp.LinkedLists
{
  public   class myLinkedList :LinkedList<string>
    {
       LinkedListNode<string> listNode;
        public void  ourLinkedList()
        {
            string[] mystarray = new string[] { "doyo", "jkl", "4" ,"doyoJ"};

            foreach (var item in mystarray)
            {
                listNode = new LinkedListNode<string>(item);

                this.AddLast(listNode);
                
            }
            //this.AddFirst("jkl");
            //this.AddFirst("4");
            foreach (var item in this)
            {

               LinkedListNode<string> tr = new LinkedListNode<string>(item);
                
                Console.WriteLine( tr.Value.ToString() + "  " +  tr.GetHashCode().ToString());

                
            }
            LinkedListNode<string> trs = this.Find("4");
            Console.WriteLine(trs.Value.ToString()  + " " +  trs.Next.Value.ToString()  + " " +   trs.Previous.Previous.Value.ToString());
            Console.ReadLine();



        }
    }
}
