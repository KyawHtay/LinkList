using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class List
    {
        public Node head;
        public Node current;
        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }
        public List()
        {
            size = 0;
            head = null;
        }
        public void Add(object content)
        {
            size++;

            Node node = new Node(content);

            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }
            current = node;
        }
        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.NodeContent);
                tempNode = tempNode.Next;
            }
        }
        public void Retrieve(int Position)
        {
            if (head == null)
            {
                Console.WriteLine("Linklist Empty");
            }
            else
            {
                Node tempNode = head;
                Node retNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        retNode = tempNode;
                        break;
                    }
                    count++;
                    tempNode = tempNode.Next;
                }
                Console.WriteLine("The Element at Node " + Position + " is " + retNode.NodeContent);

            }
        }
        public bool Delete(int Position)
        {
            if (Position == 1)
            {
                //Node tempNode = head;
                //head.Next = tempNode;
                //head = tempNode;

                //head = null;
                //current = null;

                Console.WriteLine("Plz delete some other Position element. This method is not working right now.");

                return true;
            }
            if (Position > 1 && Position <= size)
            {
                Node tempNode = head;

                Node lastNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == Position - 1)
                    {
                        lastNode.Next = tempNode.Next;
                        return true;
                    }
                    count++;

                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
            return false;
        }
    }
}
