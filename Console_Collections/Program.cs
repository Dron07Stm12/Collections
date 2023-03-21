using System;
using System.Collections.Generic;

namespace Console_Collections
{


    public class MyClass
    {
        
        public string MyProperty { get; set; } = "dron";

        
        public void Fu() { Console.WriteLine(MyProperty); }

    }



    internal class Program
    {
        static void Main(string[] args)
        {


            MyClass myClass = new MyClass();
            myClass.Fu();
            myClass.MyProperty = "2";
            Console.WriteLine(myClass.MyProperty);
           
           
           
            


            List<string> list = new List<string>() {"Dron7","Nata","Lero" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***");

            Console.WriteLine(list[1]);
            list[0] = "Papa";
            Console.WriteLine(list[0]);
            Console.WriteLine("***");

           
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***");

            List<string> list2= new List<string>(list) {"Kampot"};
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***");

            list2.Add("Mike");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***");
            Console.WriteLine(list2.Count);
            Console.WriteLine("***");
            string[] str = new string[] {"Андрей","Наташа","Лера" };  
            list2.AddRange(str);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***");
            int i = list2.BinarySearch("Андрей");
            Console.WriteLine(i);
            list2.Sort();
            int i2 = list2.BinarySearch(list2[6]);
            Console.WriteLine(i2);  
        }
    }
}
