using System.Collections;

namespace ConsoleAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //----Array----//
            //cons---fixed size (cannot grow/shrinks after creation).
            //prons---strongly type(can only store one type.)
            //better performance because of type safety.


            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            Console.WriteLine("Array Elements");

            //print
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //non-generic
            //---Arraylist-----
            ArrayList numberList = new ArrayList();

            //Add elements----not type safe

            numberList.Add(10);
            numberList.Add("Sanjay");
            numberList.Add(false);
            numberList.Add('A');


            //display output
            Console.WriteLine("Before insertion");
            foreach(object item in numberList)
            {
                Console.WriteLine(item);
            }
         
        }
            */


            //LIST--GENERIC COLLECTION

            //stronly type


            //declaration.
            List<int> numberlist = new List<int>();

            //Add an element
            numberlist.Add(44);
            numberlist.Add(12);
            numberlist.Add(153);
            numberlist.Add(23);

            //traversal through list
            Console.WriteLine("Before insert");
            foreach(int number in numberlist)

            {
                Console.WriteLine(number);

            }

            Console.WriteLine("after new insert");
            numberlist.Add(44);
            Console.WriteLine("After insert");
            foreach(int number in numberlist)
            {
                Console.WriteLine(number);
            }

            //sort
            Console.WriteLine("Sorting here");
            numberlist.Sort();
            

            Console.WriteLine("After sort");
            foreach (int number in numberlist)
            {
                Console.WriteLine(number);
            }




        }

    }
}
