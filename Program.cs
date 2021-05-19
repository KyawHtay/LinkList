using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

        A:
            Console.WriteLine("What You Want to Do ?\n\tAdd Element in LinkedList : Press 1\n\tDelete Element from LinkedList : Press 2\n\tCheck Element at Any Node : Press 3\n\tDisplay LinkedList Elements : Press 4");
            int reply = Convert.ToInt32(Console.ReadLine());

            if (reply == 1)
            {
                Console.WriteLine("How Many Elements you wants to Put in Linked List ?");
                int howMany = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= howMany; i++)
                {
                    Console.WriteLine("Put Element in Linked List");
                    string elementToPut = Console.ReadLine();
                    list.Add(elementToPut);
                }
            }
            else if (reply == 2)
            {
                Console.WriteLine("Which Node You want Delete ? e.g 4");
                int elementToDelete = Convert.ToInt32(Console.ReadLine());
                list.Delete(elementToDelete);
            }
            else if (reply == 3)
            {
                Console.WriteLine("At Which Node You want Check ? e.g 3");
                int elementToCheck = Convert.ToInt32(Console.ReadLine());

                list.Retrieve(elementToCheck);
            }
            else if (reply == 4)
            {
                Console.WriteLine("Here is Your LinkedList");
                list.ListNodes();
            }
            goto A;

        }
    }
  }

