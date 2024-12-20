using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_01
{
     class Class1
    {

        string name = "ali";
        int age = 12;
        public void data()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 a = new Class1();
            a.data();

        }
    }
}
