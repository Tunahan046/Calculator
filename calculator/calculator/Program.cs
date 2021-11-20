using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double opposite;
            double number1, number2; string procces;
            Console.WriteLine("plaese enter a number");

            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("plaese enter the second number");

            number2 = Convert.ToDouble(Console.ReadLine());



            Console.Write("please select a transaction");
            Console.WriteLine("[*],[/],[-],[+]");
            procces = Console.ReadLine();
            if (procces != "*" && procces != "/" && procces != "-" && procces != "+")
                Console.WriteLine("please select a valid transaction!!!");
            else
                Console.WriteLine("the process you choose:{0}", procces);


            if (procces == "*")
            {
                Console.WriteLine("result of the transaction=" + ((float)number2 * (float)number1));
            }
            if (procces == "/")
            {
                if (number2 != 0)
                {
                    Console.WriteLine("result of the transaction=" + ((float)number1 / (float)number2));

                }
                else if (number2 == 0)
                {

                    Console.WriteLine("uncertain");
                }



            }
            if (procces == "+")
            {
                Console.WriteLine("result of the transaction=" + ((float)number1 + (float)number2));
            }
            if (procces == "-")
            {
                if (number2 < number1)
                    Console.WriteLine("result of the transaction=" + ((float)number1 - (float)number2));
                else if (number1 < number2)
                {
                    opposite = number2 - number1;
                    Console.WriteLine("result of the transaction=" + (0 - opposite));
                }

            }
        }
}
