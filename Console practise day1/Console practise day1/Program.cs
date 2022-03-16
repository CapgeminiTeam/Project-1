using System;

namespace Console_practise_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Your Entered Data are - Name = " + name + " , Age = " + age + "");
            //Console.WriteLine("Your Entered Data are - Name = {0}, Age = {1}", name ,age);
            //Console.WriteLine($"Your Entered Data are - Name = {name} , Age = {age}");


            //Console.WriteLine("Enter First number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Add= {num1 + num2}");
            //Console.WriteLine($"Sub= {num1 - num2}");



            //Console.WriteLine("Enter First number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > 0 || num2 > 0)
            //{
            //    Console.WriteLine($"Add= {num1 + num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Sub= {num1 - num2}");
            //}




            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Value of i : {i}");
            //}


            //Console.WriteLine("Enter First number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter operation");
            //string type = Console.ReadLine();

            //if (type == "add")
            //{
            //    Console.WriteLine($"Add= {num1 + num2}");
            //}
            //else if (type == "sub")
            //{
            //    Console.WriteLine($"sub= {num1 - num2}");
            //}
            //else if (type == "div")
            //{
            //    Console.WriteLine($"Div= {num1 / num2}");
            //}
            //else if (type == "mul")
            //{
            //    Console.WriteLine($"Mul= {num1 * num2}");
            //}


            //Console.WriteLine("Enter First number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter operation");
            //string type = Console.ReadLine();

            //switch (type)
            //{
            //    case "Add":
            //        Console.WriteLine($"Add: {num1 + num2}");
            //        break;
            //    case "Sub":
            //        Console.WriteLine($"Sub: {num1 - num2}");
            //        break;
            //    case "Mul":
            //        Console.WriteLine($"Mul: {num1 * num2}");
            //        break;
            //    case "Div":
            //        Console.WriteLine($"Div: {num1 / num2}");
            //        break;
            //}


            //int i = 10;
            //while (i <= 15)
            //{
            //    Console.WriteLine($"The value of I: {i}");
            //    i++;
            //}

            //int i = 10;
            //do
            //{
            //    Console.WriteLine($"The Value of I: {i}");
            //    i++;
            //}
            //while (i < 15);


            // It prints the number upto 8
            //for (int i = 0; i < 20; i++) 
            //{
            //    if (i==8)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //// It prints all the number except 8
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i == 8)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}



            //Ternary Operator
            //string name = "Dravid";
            //string result = name == "Dracid" ? "Value is correct" : "Incorrect";
            //Console.WriteLine(result);

            //object fname = "Hi";
            //char[] fname2 = { 'H', 'i' };
            //object lname = new string(fname2);
            //Console.WriteLine($"Check for == :  {fname == lname}");
            //Console.WriteLine($"Check foe equals : {fname.Equals(lname)}");

            /*********************************************************************************************
            //string fname = "Hi";
            //fname = "Welcome";
            //fname += " Capgemini";
            //Console.WriteLine(fname);


            //StringBuilder builder = new StringBuilder();
            //builder.Append("IBM");
            //builder.Append("Infosys");
            //builder.Append("Capgemini");
            //builder.Append(fname);
            //Console.WriteLine(fname)
            ********************************************************************************************/




            //Console.WriteLine("Enter the number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1 % 2 == 0)
            //    Console.WriteLine("The {0} is even number", num1);
            //else
            //    Console.WriteLine("The {0} is odd number", num1);



            //Console.WriteLine("Enter the 1st number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the 2nd number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //    Console.WriteLine("1st number is greater than 2nd");
            //else if (num1 < num2)
            //    Console.WriteLine("2nd number is grater than 1st");
            //else
            //    Console.WriteLine("Both are equal");


            //Console.WriteLine("Enter the radius of circle: ");
            //int r = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The area of circle: {0}", 3.14 * r * r);
            //Console.WriteLine("The perimeter of circle: {0}", 3.14 * r * 2);


            //Console.WriteLine("Enter length of side: ");
            //int s = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The area of square: {0}", s*s);
            //Console.WriteLine("The perimeter of square: {0}",4*s);


            Console.WriteLine("Enter length of rectangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The area of rectangle:{0}", l * b);
            Console.WriteLine("The area of rectangle:{0}", 2* l * b);








        }
    }
}