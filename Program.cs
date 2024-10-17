using System.ComponentModel;

namespace MergingTwoSortedArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(10);
            l1.AddLast(90);
            l1.AddLast(30);
            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(12);
            l2.AddLast(5);
            l2.AddLast(60);
            Console.WriteLine("BEFORE SORTING");
            LinkedList<int> result = new LinkedList<int>();
            foreach(int i in l1)
            {
                result.AddFirst(i);
            }
            foreach(int i in l2)
            {
                result.AddAfter(result.First,i);
            }
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            var res=result.Order();
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("REVERSE LINKESLIST");
            var rever = res.Reverse();
            foreach(int i in rever)
            {
                Console.WriteLine(i);

            }
            
        }
    }
}
