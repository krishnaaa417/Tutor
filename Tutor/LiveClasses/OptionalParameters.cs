using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.LiveClasses
{
    internal class OptionalParameters
    {
        static void Main(string[] args)
        {
            //Sum(10);

            //Books book;

            //book.Id = 1;
            //book.Name = "Books";
            //book.gender = 'M';
            //book.Pnumber = 0123456789;

            //Console.WriteLine(book.Id);
            //Console.WriteLine(book.Name);
            //Console.WriteLine(book.gender);
            //Console.WriteLine(book.Pnumber);

            //dynamic d = 1;
            //d = "Krishna";

            //var a = 1;
            //a = "name";
            //Console.WriteLine(a);

            // Console.WriteLine(d);

            int arg1 = 0;
            int arg2;

            Console.WriteLine("arg1 before passing to a method.."+arg1);
            Method1(ref arg1);
            Console.WriteLine("arg 1 after passing to a method.." + arg1);

            //Console.WriteLine("arg 2 after passing to a method.." + arg2);
            Method2(out arg2);
            Console.WriteLine(arg2);
        }


        public static void Method1(ref int value)
        {
            value = 123;
        }

        public static void Method2(out int value)
        {
            value = 2; // must be intialized
        }



        private static void Sum(int a, int b = 34)
        {
            Console.WriteLine(a+b);
        }
    }

    public struct Books
    {
        public int Id;
        public string Name;
        public char gender;
        public long Pnumber;
        


    };


}
