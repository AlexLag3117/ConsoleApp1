using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
    public class A
    {
        public A()
        {
            Console.WriteLine("CA");
        }
        public void Print1()
        {
            Console.WriteLine("A1");
        }
        public void Print2()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("CB");
        }
        public void Print1()
        {
            Console.WriteLine("B");
        }
    }
    public class C : B
    {
        public C()
        {
            Console.WriteLine("CC");
        }
        new public void Print2()
        {
            Console.WriteLine("C");
        }
    }


    //class Counter
    //{
    //    public int Number { get; set; }

    //    // определение оператора сложения
    //    public static int operator +(int val, Counter counter)
    //    {
    //        return counter.Number + val;
    //    }
    //}
    public class Person
    {
        ~Person()
        {
            Console.Beep();
        }


    }
    class Program
    {
        static void Swap(ref int a1, ref int a2)
        {
            int temp = a1;
            a1 = a2;
            a2 = temp;
        }

        static int Part(int[]arr, int start, int end)
        {
            int part = start-1;
            for(int i = start; i < end; i++)
            {
                if (arr[i] < arr[end])
                {
                    part++;
                    Swap(ref arr[part], ref arr[i]);
                }
            }

            part++;
            Swap(ref arr[part], ref arr[end]);
            return part;
        }
        static int[] QSort(int[] arr, int start, int end)
        {
            if (start >= end)
                return arr;
            int part = Part(arr, start, end);
            QSort(arr, start, part - 1);
            QSort(arr, part + 1, end);
            return arr;
        }
        


        static void Main(string[] args)
        {
            //short i = 1;
            //object obj = i;
            //++i;
            //Console.WriteLine(i);
            //Console.WriteLine(obj);
            //Console.WriteLine((long)obj);
            int[] arr = { 4, 5, 6, 5, 3, 2, 2, 4, 64, 3, 2, 4 };
            foreach(var i1 in arr)
                Console.WriteLine(i1);
            arr = QSort(arr, 0, arr.Length - 1);
            foreach (var i1 in arr)
                Console.WriteLine(i1);

            Console.ReadKey();

        }
    }
}
