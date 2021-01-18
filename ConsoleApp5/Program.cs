using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int number1 =60 ;
            int number2 = 90 ;
            var result2 = Add3(  number1 , number2);
           
            Console.WriteLine(Add1(2));
            Console.ReadLine();
            Console.WriteLine(result2);
            
        }

        static void Add()
        {
            Console.WriteLine("added");
        }

        static int Add1(int number1,int number2=30)
        {

            return number1 + number2;

        }

        static int Add3(int number1 ,int number2)
        {
            int number = 90;
            var result2 = number1 + number2;
            return result2;
        }
    }
}
