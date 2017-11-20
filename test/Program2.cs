using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    
    class List_Demo
    {
        private List<int> lst;
        private string Student_Name;
        private int Count;

        public List_Demo(string student_name, int count)
        {
            lst = new List<int>();
            this.Student_Name = student_name;
            this.Count = count;
        }

        public void ListFill()
        {
            switch (Count)
            {
                case 0:
                    Console.WriteLine("Okay. Bye.");
                    break;
                case 1:
                    Console.WriteLine("Please put your mark: ");
                    lst.Add(Int32.Parse(Console.ReadLine()));
                    break;
                case 2:
                    for (int i = 1; i <= Count; i++)
                    {
                        Console.WriteLine("Please put your marks: ");
                        lst.Add(Int32.Parse(Console.ReadLine()));
                    }
                    break;

                case 3:
                    for (int i = 1; i <= Count; i++)
                    {
                        Console.WriteLine("Please put your marks: ");
                        lst.Add(Int32.Parse(Console.ReadLine()));
                    }
                    break;

            }
        }

        public string St_Name()
        {
            return Student_Name;
        }

        public void ListAdd(int value)
        {
            lst.Add(value);
        }

        public void ListOut()
        {
            Console.WriteLine("\nStudent {0} has next marks ", Student_Name);
            foreach (var data in lst)
            {
                Console.Write("\nMark : " + data);
            }
            Console.Write("\n");
        }

        public double ListAverage()
        {
            double sum = 0;
            foreach (var data in lst)
            {
                sum += data;
            }
            return sum /= lst.Count();
        }

        public int ListMax()
        {
            return lst.Max();
        }
        public int ListMin()
        {
            return lst.Min();
        }
    }
}
