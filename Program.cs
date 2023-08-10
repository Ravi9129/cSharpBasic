using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //static void Greet(string name)
        //{
        //    Console.WriteLine("Good Morning " + name);

        //}
        //static float Avarage(int a, int b, int c)
        //{
        //    int sum = a + b + c;
        //    return sum / 3;
        //}

      
        
        static void Main(string[] args)
        {
            //Greet("Ravi");
            //Console.WriteLine(Avarage(1,2,3));

            //float temp = Avarage(9, 3, 0);
            //Console.WriteLine(temp);

           // int ravi = 24; //integer variable

            /* Data Types in c# with size
            integer -int ravi ---4 bytes
            floating point number - float that; -- 4 bytes
            Long --long ravi; --8bytes
            double - double ravi -----8bytes

            charcter- char a = 'A'; --2 bytes
            Boolean - bool isgreat = true; -- 1 bit(1byte=1biit)
            String - string inp = "Harry"; -- 2byte per character

             */



            // Taking inputs
            /*
             string inp = Console.ReadLine();
             Console.WriteLine(inp);
              */

            //Console.WriteLine("Hello World");
            // Console.WriteLine("Ravi Rajput");
            // Console.WriteLine("i love  World " + ravi);

            //  Console.WriteLine("Kolhapur");


            //typecasting
            /*
            int a = 34;
            float b = 34.5F;
            double d = 34.5D;
            bool isGreate = true;
            char c = 'r';
            string e= "This is a string";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(isGreate);
            Console.WriteLine(c);
            Console.WriteLine(e);
            */


            //Data types Example

            //int a = 34;
            //float b = 34.5F;
            //double d = 34.5D;
            //bool isGreate = true;
            //char c = 'r';
            //string e = "This is a string";


            // Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(d);
            //Console.WriteLine(isGreate);
            //Console.WriteLine(c);
            //Console.WriteLine(e);


            //Type Casting
            // There are two types of type casting
            //   1. Implicit casting

            //   char to int to long to float to double

            //  int x = 3;
            //  double y = x;
            //  int z = 'y';
            //  Console.WriteLine(x);
            //  Console.WriteLine(y);
            //  Console.WriteLine(z);

            //   2. Explicit Casting

            // int x = (int) 3.5; Explicit casting
            // double x1 = (double)3.5;
            // Console.WriteLine(x1);


            // int x = 3;
            // double y = 4;
            //int z = 'y';
            // float varr = Convert.ToInt32(3.55);
            // float varr = Convert.ToInt64(3.55);
            // Convert.ToDouble
            //Convert.ToString
            //  string sx = "Random string ";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //ASCII-Binary Value


            //Taking User Name

            //Console.WriteLine("Enter Your Name");
            //string name=Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name);

            //Console.WriteLine("How Many choclates you want");
            //string choclate = Console.ReadLine();
            //Console.WriteLine("you will get 2 more choclate " + (Convert.ToInt32(choclate) +2) );

            /*Operators in c#
             1. Arithmatic Operators
            2. Assignment Operators
            3. Logical Operators
            4. Comparison Operators
            */

            //Arithmatic Operators
            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a + b is : " + (a + b));
            //Console.WriteLine("The value of a - b is : " + (a - b));
            //Console.WriteLine("The value of a / b is : " + (a / b));
            //Console.WriteLine("The value of a * b is : " + (a * b));

            //Assignment Oprators
            //int a = 4;
            //int b = a;
            //b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;
            //Console.WriteLine(b);

            //Logical Operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true); 

            //Camparison Operators

            //Console.WriteLine(324>555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(324 == 555);

            //Math Classes

            // int a = Math.Max(34, 345);
            //double a = Math.Sqrt(3);
            //int a = Math.Abs(-39);
            //int a = Math.Abs(+39);
            //Console.WriteLine(a);

            //String Methods
            //string hello = "hello world this is ravi";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello + " You are nice ");
            //Console.WriteLine(string.Concat(hello, " You are nice"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"your name is {name}. you will get {candies}");

            // string hello = "Hello world this \n \t is Ravi";
            //Console.WriteLine(hello[1]);
            // Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(1));
            // Console.WriteLine(hello);

            //IF Else
            /*
            Console.WriteLine("Enter Your Age");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);
            bool isBanned = true;

            if(age<2 && isBanned)

            {
                Console.WriteLine("You are just born");

            }
            else if(age<10)
            {
                Console.WriteLine("Please finish your high school");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18");
            }

            else if(age<75)
            {

                Console.WriteLine("you can drive");
            }

            else {
                Console.WriteLine("You can not drive");
            }
            */

            // Switch Case
            /*
            int age = 18;
            switch (age)
            {

                case 18:
                    Console.WriteLine("Please wait for an year");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;
                default:
                    Console.WriteLine("Emjoy");
                    break;

            }
            */

            // Loops in C sharp
            //Console.WriteLine(1);
            // Console.WriteLine(2);
            // Console.WriteLine(3);
            // Console.WriteLine(4);
            // Console.WriteLine(5);

            //Better Alternative --Loops
            // while Loops
            /*
            int i = 0;
            while (i < 5)
            {
            Console.WriteLine(i+1);
                i++;
            }
            */
            // Do while loop

            /*
            int i = 0;

            do{
               Console.WriteLine(i+1);
                i++;
            }
            while (i < 5);
            */


            //for loop
            /*
            for(int i = 0; i < 5; i++)
            {
                continue;
                Console.WriteLine(i+1);
            break;
            }
            */

            //Break and CContinue
            /*
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                
                Console.WriteLine(i + 1);
              //  break;
            }
            */
            // Break- Leave this loop forever
            //Continue- leave this particular iteration of the loop



            // Methods - functions

            //OOPs class and objects
            Player tommy = new Player();
            //  Console.WriteLine(tommy.health);
            Console.WriteLine(tommy.getHealth());
            tommy.setHealth(57);
            Console.WriteLine(tommy.getHealth());

            Console.ReadLine();
        }
    }
}
