using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Shop
    {
        static void Main(string[] args)
        {
            string name;
            int count;

            Console.Write("Hi, you are a teacher. You will rate your student. Please type name: \n");
            name = Console.ReadLine();

            Console.WriteLine("You can add up to 3 marks. How much you want? 1, 2 or 3");
            count = Int32.Parse(Console.ReadLine());

            List_Demo obj = new List_Demo(name, count);
            obj.ListFill();
            obj.ListOut();
            Console.WriteLine("\nYour student {0} has average mark : {1} \n", obj.St_Name(), obj.ListAverage());
            Console.WriteLine("Max mark is {0}. Min mark is {1}", obj.ListMax(), obj.ListMin());
            Console.ReadKey();
        }
    }    
}
