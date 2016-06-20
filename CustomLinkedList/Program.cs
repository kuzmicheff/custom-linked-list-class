using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> intSampleList = new CustomLinkedList<int>();
            intSampleList.AddFirstNode(5);
            intSampleList.AddLastNode(15);
            intSampleList.AddFirstNode(25);
            CustomLinkedList<string> stringSampleList = new CustomLinkedList<string>();
            stringSampleList.AddFirstNode("Adam");
            stringSampleList.AddLastNode("Andrew");
            stringSampleList.AddFirstNode("Mike");
            intSampleList.PrintLinkedList();
            stringSampleList.PrintLinkedList();

            Console.WriteLine("Press any key to quit:");
            Console.ReadKey();
        }
    }
}
